using clientsil.Properties;
using System;
using System.Globalization;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace clientsil
{
    public partial class Form1 : Form
    {
        private readonly int serverPort = 5000;

        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Dil seçenekleri
            comboBoxLanguage.Items.Add("Türkçe");
            comboBoxLanguage.Items.Add("English");
            comboBoxLanguage.SelectedIndex = 0; 
            comboBoxLanguage.SelectedIndexChanged += comboBoxLanguage_SelectedIndexChanged;

            ApplyLanguage();
        }

        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLanguage.SelectedItem.ToString() == "English")
                SetLanguage("en");
            else
                SetLanguage("tr");

            ApplyLanguage();
        }

        private void SetLanguage(string cultureCode)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultureCode);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(cultureCode);
        }

        private void ApplyLanguage()
        {
            this.Text = Resource.App_Title;
            lblServerIP.Text = Resource.Label_ServerIP;
            lblInput.Text = Resource.Label_Input;
            btnSendData.Text = Resource.Button_Send;
            LanguageCh.Text = Resource.lang;
            label1.Text = Resource.namm;
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            string serverIP = textBoxServerIP.Text.Trim();
            string input = txtInput.Text.Trim();

            if (string.IsNullOrEmpty(serverIP) || string.IsNullOrEmpty(input))
            {
                MessageBox.Show(Resource.Msg_MissingFields);
                return;
            }

            string[] parts = input.Split(',');
            if (parts.Length != 3)
            {
                MessageBox.Show(Resource.Msg_WrongFormat);
                return;
            }

            string ad = parts[0].Trim();
            string soyad = parts[1].Trim();
            string yas = parts[2].Trim();

            try
            {
                string dataPacket = $"{ad},{soyad},{yas}";
                SendData(serverIP, dataPacket);
                MessageBox.Show(Resource.Msg_SendSuccess);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Resource.Msg_SendError + " " + ex.Message);
            }
        }

        private void SendData(string serverIP, string dataPacket)
        {
            using (TcpClient client = new TcpClient())
            {
                client.Connect(serverIP, serverPort);

                using (NetworkStream ns = client.GetStream())
                using (var writer = new System.IO.StreamWriter(ns, Encoding.UTF8))
                {
                    writer.AutoFlush = true;
                    writer.WriteLine(dataPacket);
                }
            }
        }
    }
}
