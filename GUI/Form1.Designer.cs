
namespace GUI
{
    partial class ControlCenter
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBaud = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lbLEDCtrl = new System.Windows.Forms.Label();
            this.tbLeitura = new System.Windows.Forms.TextBox();
            this.btLED1 = new System.Windows.Forms.Button();
            this.btLED3 = new System.Windows.Forms.Button();
            this.btLED6 = new System.Windows.Forms.Button();
            this.btLED2 = new System.Windows.Forms.Button();
            this.btLED4 = new System.Windows.Forms.Button();
            this.btLED5 = new System.Windows.Forms.Button();
            this.btLED7 = new System.Windows.Forms.Button();
            this.btLED0 = new System.Windows.Forms.Button();
            this.btRele = new System.Windows.Forms.Button();
            this.btLeituraAD = new System.Windows.Forms.Button();
            this.TrPWM = new System.Windows.Forms.TrackBar();
            this.cbCtrlPWM = new System.Windows.Forms.CheckBox();
            this.lbCtrlMot = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btDisconect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrPWM)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(228, 417);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(121, 21);
            this.cbPort.TabIndex = 0;
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(482, 417);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(75, 23);
            this.btConnect.TabIndex = 1;
            this.btConnect.Text = "Conectar";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "COM";
            // 
            // cbBaud
            // 
            this.cbBaud.FormattingEnabled = true;
            this.cbBaud.Location = new System.Drawing.Point(355, 417);
            this.cbBaud.Name = "cbBaud";
            this.cbBaud.Size = new System.Drawing.Size(121, 21);
            this.cbBaud.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baud";
            // 
            // lbLEDCtrl
            // 
            this.lbLEDCtrl.AutoSize = true;
            this.lbLEDCtrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLEDCtrl.Location = new System.Drawing.Point(333, 177);
            this.lbLEDCtrl.Name = "lbLEDCtrl";
            this.lbLEDCtrl.Size = new System.Drawing.Size(164, 20);
            this.lbLEDCtrl.TabIndex = 5;
            this.lbLEDCtrl.Text = "Controle dos LED\'s";
            // 
            // tbLeitura
            // 
            this.tbLeitura.Location = new System.Drawing.Point(305, 115);
            this.tbLeitura.Multiline = true;
            this.tbLeitura.Name = "tbLeitura";
            this.tbLeitura.Size = new System.Drawing.Size(206, 18);
            this.tbLeitura.TabIndex = 6;
            this.tbLeitura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btLED1
            // 
            this.btLED1.Location = new System.Drawing.Point(305, 200);
            this.btLED1.Name = "btLED1";
            this.btLED1.Size = new System.Drawing.Size(75, 57);
            this.btLED1.TabIndex = 7;
            this.btLED1.Text = "LED1";
            this.btLED1.UseVisualStyleBackColor = true;
            this.btLED1.Click += new System.EventHandler(this.btLED1_Click);
            // 
            // btLED3
            // 
            this.btLED3.Location = new System.Drawing.Point(561, 200);
            this.btLED3.Name = "btLED3";
            this.btLED3.Size = new System.Drawing.Size(75, 57);
            this.btLED3.TabIndex = 9;
            this.btLED3.Text = "LED3";
            this.btLED3.UseVisualStyleBackColor = true;
            this.btLED3.Click += new System.EventHandler(this.btLED3_Click);
            // 
            // btLED6
            // 
            this.btLED6.Location = new System.Drawing.Point(436, 295);
            this.btLED6.Name = "btLED6";
            this.btLED6.Size = new System.Drawing.Size(75, 57);
            this.btLED6.TabIndex = 12;
            this.btLED6.Text = "LED6";
            this.btLED6.UseVisualStyleBackColor = true;
            this.btLED6.Click += new System.EventHandler(this.btLED6_Click);
            // 
            // btLED2
            // 
            this.btLED2.Location = new System.Drawing.Point(436, 200);
            this.btLED2.Name = "btLED2";
            this.btLED2.Size = new System.Drawing.Size(75, 57);
            this.btLED2.TabIndex = 14;
            this.btLED2.Text = "LED2";
            this.btLED2.UseVisualStyleBackColor = true;
            this.btLED2.Click += new System.EventHandler(this.btLED2_Click);
            // 
            // btLED4
            // 
            this.btLED4.Location = new System.Drawing.Point(169, 295);
            this.btLED4.Name = "btLED4";
            this.btLED4.Size = new System.Drawing.Size(75, 57);
            this.btLED4.TabIndex = 15;
            this.btLED4.Text = "LED4";
            this.btLED4.UseVisualStyleBackColor = true;
            this.btLED4.Click += new System.EventHandler(this.btLED4_Click);
            // 
            // btLED5
            // 
            this.btLED5.Location = new System.Drawing.Point(305, 295);
            this.btLED5.Name = "btLED5";
            this.btLED5.Size = new System.Drawing.Size(75, 57);
            this.btLED5.TabIndex = 16;
            this.btLED5.Text = "LED5";
            this.btLED5.UseVisualStyleBackColor = true;
            this.btLED5.Click += new System.EventHandler(this.btLED5_Click);
            // 
            // btLED7
            // 
            this.btLED7.Location = new System.Drawing.Point(561, 295);
            this.btLED7.Name = "btLED7";
            this.btLED7.Size = new System.Drawing.Size(75, 57);
            this.btLED7.TabIndex = 18;
            this.btLED7.Text = "LED7";
            this.btLED7.UseVisualStyleBackColor = true;
            this.btLED7.Click += new System.EventHandler(this.btLED7_Click);
            // 
            // btLED0
            // 
            this.btLED0.Location = new System.Drawing.Point(169, 200);
            this.btLED0.Name = "btLED0";
            this.btLED0.Size = new System.Drawing.Size(75, 57);
            this.btLED0.TabIndex = 17;
            this.btLED0.Text = "LED0";
            this.btLED0.UseVisualStyleBackColor = true;
            this.btLED0.Click += new System.EventHandler(this.btLED0_Click);
            // 
            // btRele
            // 
            this.btRele.Location = new System.Drawing.Point(365, 47);
            this.btRele.Name = "btRele";
            this.btRele.Size = new System.Drawing.Size(84, 30);
            this.btRele.TabIndex = 19;
            this.btRele.Text = "Desligado";
            this.btRele.UseVisualStyleBackColor = true;
            this.btRele.Click += new System.EventHandler(this.btRele_Click);
            // 
            // btLeituraAD
            // 
            this.btLeituraAD.Location = new System.Drawing.Point(374, 139);
            this.btLeituraAD.Name = "btLeituraAD";
            this.btLeituraAD.Size = new System.Drawing.Size(75, 23);
            this.btLeituraAD.TabIndex = 20;
            this.btLeituraAD.Text = "Leitura";
            this.btLeituraAD.UseVisualStyleBackColor = true;
            this.btLeituraAD.Click += new System.EventHandler(this.btLeituraAD_Click);
            // 
            // TrPWM
            // 
            this.TrPWM.LargeChange = 1;
            this.TrPWM.Location = new System.Drawing.Point(704, 51);
            this.TrPWM.Name = "TrPWM";
            this.TrPWM.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrPWM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TrPWM.Size = new System.Drawing.Size(45, 332);
            this.TrPWM.TabIndex = 22;
            this.TrPWM.Scroll += new System.EventHandler(this.TrPWM_Scroll);
            // 
            // cbCtrlPWM
            // 
            this.cbCtrlPWM.AutoSize = true;
            this.cbCtrlPWM.Location = new System.Drawing.Point(704, 389);
            this.cbCtrlPWM.Name = "cbCtrlPWM";
            this.cbCtrlPWM.Size = new System.Drawing.Size(78, 17);
            this.cbCtrlPWM.TabIndex = 23;
            this.cbCtrlPWM.Text = "Ligar motor";
            this.cbCtrlPWM.UseVisualStyleBackColor = true;
            this.cbCtrlPWM.CheckedChanged += new System.EventHandler(this.cbCtrlPWM_CheckedChanged);
            // 
            // lbCtrlMot
            // 
            this.lbCtrlMot.AutoSize = true;
            this.lbCtrlMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCtrlMot.Location = new System.Drawing.Point(614, 28);
            this.lbCtrlMot.Name = "lbCtrlMot";
            this.lbCtrlMot.Size = new System.Drawing.Size(174, 20);
            this.lbCtrlMot.TabIndex = 25;
            this.lbCtrlMot.Text = "Velocidade do Motor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(334, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Controle do Relé";
            // 
            // btDisconect
            // 
            this.btDisconect.Location = new System.Drawing.Point(561, 417);
            this.btDisconect.Name = "btDisconect";
            this.btDisconect.Size = new System.Drawing.Size(75, 23);
            this.btDisconect.TabIndex = 27;
            this.btDisconect.Text = "Desconectar";
            this.btDisconect.UseVisualStyleBackColor = true;
            this.btDisconect.Click += new System.EventHandler(this.btDisconect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(361, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Leitura AD";
            // 
            // ControlCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btDisconect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbCtrlMot);
            this.Controls.Add(this.cbCtrlPWM);
            this.Controls.Add(this.TrPWM);
            this.Controls.Add(this.btLeituraAD);
            this.Controls.Add(this.btRele);
            this.Controls.Add(this.btLED7);
            this.Controls.Add(this.btLED0);
            this.Controls.Add(this.btLED5);
            this.Controls.Add(this.btLED4);
            this.Controls.Add(this.btLED2);
            this.Controls.Add(this.btLED6);
            this.Controls.Add(this.btLED3);
            this.Controls.Add(this.btLED1);
            this.Controls.Add(this.tbLeitura);
            this.Controls.Add(this.lbLEDCtrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbBaud);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.cbPort);
            this.Name = "ControlCenter";
            this.Text = "ControlCenter";
            ((System.ComponentModel.ISupportInitialize)(this.TrPWM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBaud;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lbLEDCtrl;
        private System.Windows.Forms.TextBox tbLeitura;
        private System.Windows.Forms.Button btLED1;
        private System.Windows.Forms.Button btLED3;
        private System.Windows.Forms.Button btLED6;
        private System.Windows.Forms.Button btLED2;
        private System.Windows.Forms.Button btLED4;
        private System.Windows.Forms.Button btLED5;
        private System.Windows.Forms.Button btLED7;
        private System.Windows.Forms.Button btLED0;
        private System.Windows.Forms.Button btRele;
        private System.Windows.Forms.Button btLeituraAD;
        private System.Windows.Forms.TrackBar TrPWM;
        private System.Windows.Forms.CheckBox cbCtrlPWM;
        private System.Windows.Forms.Label lbCtrlMot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btDisconect;
        private System.Windows.Forms.Label label4;
    }
}

