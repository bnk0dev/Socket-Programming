namespace serversil
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStopServer = new System.Windows.Forms.Button();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.brnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LanguageCh = new System.Windows.Forms.Label();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.btnAlert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStopServer
            // 
            this.btnStopServer.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStopServer.Location = new System.Drawing.Point(94, 94);
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.Size = new System.Drawing.Size(75, 23);
            this.btnStopServer.TabIndex = 0;
            this.btnStopServer.Text = "STOP";
            this.btnStopServer.UseVisualStyleBackColor = true;
            this.btnStopServer.Click += new System.EventHandler(this.btnStopServer_Click);
            // 
            // btnStartServer
            // 
            this.btnStartServer.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStartServer.Location = new System.Drawing.Point(13, 94);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(75, 23);
            this.btnStartServer.TabIndex = 1;
            this.btnStartServer.Text = "START";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(13, 123);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(311, 235);
            this.txtLog.TabIndex = 2;
            // 
            // brnClear
            // 
            this.brnClear.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.brnClear.Location = new System.Drawing.Point(249, 364);
            this.brnClear.Name = "brnClear";
            this.brnClear.Size = new System.Drawing.Size(75, 23);
            this.brnClear.TabIndex = 4;
            this.brnClear.Text = "CLEAR";
            this.brnClear.UseVisualStyleBackColor = true;
            this.brnClear.Click += new System.EventHandler(this.brnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(102, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "SERVER";
            // 
            // LanguageCh
            // 
            this.LanguageCh.AutoSize = true;
            this.LanguageCh.Location = new System.Drawing.Point(10, 42);
            this.LanguageCh.Name = "LanguageCh";
            this.LanguageCh.Size = new System.Drawing.Size(0, 13);
            this.LanguageCh.TabIndex = 12;
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Location = new System.Drawing.Point(13, 58);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(75, 21);
            this.comboBoxLanguage.TabIndex = 11;
            // 
            // btnAlert
            // 
            this.btnAlert.Location = new System.Drawing.Point(249, 94);
            this.btnAlert.Name = "btnAlert";
            this.btnAlert.Size = new System.Drawing.Size(75, 23);
            this.btnAlert.TabIndex = 13;
            this.btnAlert.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 403);
            this.Controls.Add(this.btnAlert);
            this.Controls.Add(this.LanguageCh);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brnClear);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnStartServer);
            this.Controls.Add(this.btnStopServer);
            this.Name = "Form1";
            this.Text = "Server TCP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStopServer;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button brnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LanguageCh;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.Button btnAlert;
    }
}

