using ClosedXML.Excel;
using serversil.Properties;
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace serversil
{
    public partial class Form1 : Form
    {
        private TcpListener listener;
        private Thread listenThread;
        private readonly int serverPort = 5000;
        private bool serverRunning = false;
        private string excelPath = "GelenVeri.xlsx";
        private System.Windows.Forms.Timer alertTimer;
        private int alertCounter = 0;

        public Form1()
        {
            InitializeComponent();

            // Dil seçenekleri
            comboBoxLanguage.Items.Add("Türkçe");
            comboBoxLanguage.Items.Add("English");
            comboBoxLanguage.SelectedIndex = 0;
            comboBoxLanguage.SelectedIndexChanged += comboBoxLanguage_SelectedIndexChanged;

            ApplyLanguage();

            if (!File.Exists(excelPath))
            {
                using (var wb = new XLWorkbook())
                {
                    var ws = wb.Worksheets.Add("Veri");
                    ws.Cell(1, 1).Value = "IP Adresi";
                    ws.Cell(1, 2).Value = "Ad";
                    ws.Cell(1, 3).Value = "Soyad";
                    ws.Cell(1, 4).Value = "Yaş";
                    wb.SaveAs(excelPath);
                }
            }

            alertTimer = new System.Windows.Forms.Timer();
            alertTimer.Interval = 500;
            alertTimer.Tick += AlertTimer_Tick;

            btnAlert.BackColor = SystemColors.Control;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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
            btnStartServer.Text = Resource.Button_Start;
            btnStopServer.Text = Resource.Button_Stop;
            brnClear.Text = Resource.Button_Clear;
            LanguageCh.Text = Resource.LanguageCh;
            label1.Text = Resource.namm;
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            if (!serverRunning)
            {
                try
                {
                    listener = new TcpListener(IPAddress.Any, serverPort);
                    listener.Start();

                    listenThread = new Thread(ListenForClients);
                    listenThread.IsBackground = true;
                    listenThread.Start();

                    serverRunning = true;
                    txtLog.AppendText(Resource.Msg_ServerStartSuccess + "\r\n");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Resource.Msg_ServerStartFail + " " + ex.Message);
                }
            }
        }

        private void ListenForClients()
        {
            try
            {
                while (serverRunning)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    Thread clientThread = new Thread(HandleClientComm);
                    clientThread.IsBackground = true;
                    clientThread.Start(client);
                }
            }
            catch { }
        }

        private void HandleClientComm(object clientObj)
        {
            using (TcpClient client = (TcpClient)clientObj)
            using (NetworkStream ns = client.GetStream())
            using (var reader = new System.IO.StreamReader(ns, Encoding.UTF8))
            {
                try
                {
                    string message = reader.ReadLine();
                    if (!string.IsNullOrEmpty(message))
                    {
                        string clientIP = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();
                        string[] parts = message.Split(',');
                        if (parts.Length != 3) return;
                        string ad = parts[0].Trim();
                        string soyad = parts[1].Trim();
                        string yas = parts[2].Trim();

                        txtLog.Invoke(new Action(() =>
                            txtLog.AppendText(string.Format(Resource.Msg_ClientDataReceived, clientIP, ad, soyad, yas) + "\r\n")));

                        SaveToExcel(clientIP, ad, soyad, yas);

                        if (ad.ToLower() == "bilal" && soyad.ToLower() == "koc")
                        {
                            txtLog.Invoke(new Action(() =>
                            {
                                btnAlert.BackColor = Color.Black;
                                alertCounter = 0;
                                alertTimer.Start();
                            }));
                        }
                    }
                }
                catch (Exception ex)
                {
                    txtLog.Invoke(new Action(() =>
                        txtLog.AppendText(Resource.Msg_DataError + " " + ex.Message + "\r\n")));
                }
            }
        }

        private void SaveToExcel(string ip, string ad, string soyad, string yas)
        {
            try
            {
                using (var wb = new XLWorkbook(excelPath))
                {
                    var ws = wb.Worksheet("Veri");
                    int lastRow = ws.LastRowUsed()?.RowNumber() ?? 1;
                    int newRow = lastRow + 1;

                    ws.Cell(newRow, 1).Value = ip;
                    ws.Cell(newRow, 2).Value = ad;
                    ws.Cell(newRow, 3).Value = soyad;
                    ws.Cell(newRow, 4).Value = yas;

                    wb.Save();
                }
            }
            catch (Exception ex)
            {
                txtLog.Invoke(new Action(() =>
                    txtLog.AppendText(Resource.Msg_ExcelSaveError + " " + ex.Message + "\r\n")));
            }
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            try
            {
                serverRunning = false;
                listener.Stop();
                txtLog.AppendText(Resource.Msg_ServerStop + "\r\n");
            }
            catch { }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
        }

        private void AlertTimer_Tick(object sender, EventArgs e)
        {
            alertCounter++;

            if (btnAlert.BackColor == Color.Black)
                btnAlert.BackColor = Color.Red;
            else
                btnAlert.BackColor = Color.Black;

            if (alertCounter >= 4)
            {
                alertTimer.Stop();
                btnAlert.BackColor = SystemColors.Control;
                alertCounter = 0;
            }
        }

        private void brnClear_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
        }
    }
}
