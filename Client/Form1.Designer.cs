namespace clientsil
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.textBoxServerIP = new System.Windows.Forms.TextBox();
            this.btnSendData = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblServerIP = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.LanguageCh = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxServerIP
            // 
            this.textBoxServerIP.Location = new System.Drawing.Point(23, 136);
            this.textBoxServerIP.Name = "textBoxServerIP";
            this.textBoxServerIP.Size = new System.Drawing.Size(186, 20);
            this.textBoxServerIP.TabIndex = 0;
            // 
            // btnSendData
            // 
            this.btnSendData.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSendData.Location = new System.Drawing.Point(80, 239);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(75, 31);
            this.btnSendData.TabIndex = 1;
            this.btnSendData.Text = "SEND";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(23, 195);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(186, 20);
            this.txtInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(75, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "CLIENT";
            // 
            // lblServerIP
            // 
            this.lblServerIP.AutoSize = true;
            this.lblServerIP.Location = new System.Drawing.Point(20, 120);
            this.lblServerIP.Name = "lblServerIP";
            this.lblServerIP.Size = new System.Drawing.Size(72, 13);
            this.lblServerIP.TabIndex = 7;
            this.lblServerIP.Text = "IP ADDRESS";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(20, 179);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(36, 13);
            this.lblInput.TabIndex = 8;
            this.lblInput.Text = "DATA";
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Location = new System.Drawing.Point(23, 74);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(58, 21);
            this.comboBoxLanguage.TabIndex = 9;
            this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguage_SelectedIndexChanged);
            // 
            // LanguageCh
            // 
            this.LanguageCh.AutoSize = true;
            this.LanguageCh.Location = new System.Drawing.Point(20, 58);
            this.LanguageCh.Name = "LanguageCh";
            this.LanguageCh.Size = new System.Drawing.Size(0, 13);
            this.LanguageCh.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 286);
            this.Controls.Add(this.LanguageCh);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblServerIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnSendData);
            this.Controls.Add(this.textBoxServerIP);
            this.Name = "Form1";
            this.Text = "Client TCP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxServerIP;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblServerIP;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.Label LanguageCh;
    }
}
