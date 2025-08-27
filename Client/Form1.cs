using System;
using System.Net.Sockets;
using System.Text;
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

        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            string serverIP = textBoxServerIP.Text.Trim();
            string input = txtInput.Text.Trim(); 

            if (string.IsNullOrEmpty(serverIP) || string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Lütfen Sunucu IP ve veriyi giriniz!");
                return;
            }

            string[] parts = input.Split(',');
            if (parts.Length != 3)
            {
                MessageBox.Show("Lütfen veriyi 'Ad,Soyad,Yaş' formatında giriniz!");
                return;
            }

            string ad = parts[0].Trim();
            string soyad = parts[1].Trim();
            string yas = parts[2].Trim();

            try
            {
                string dataPacket = $"{ad},{soyad},{yas}";
                SendData(serverIP, dataPacket);
                MessageBox.Show("Veri başarıyla gönderildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri gönderim hatası: " + ex.Message);
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
