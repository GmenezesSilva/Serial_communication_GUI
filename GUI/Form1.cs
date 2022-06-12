using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace GUI
{
    public partial class ControlCenter : Form
    {
        string bfRecebe = string.Empty;             // Variavel para receber dados da Serial
        string pwmreceive = string.Empty;           // Variável para receber dados do PWM
        public delegate void Fdelegate(string a);   // Objeto para referenciar um método

        //Variáveis para controle dos LEDs
        bool invLED0 = true;
        bool invLED1 = true;
        bool invLED2 = true;
        bool invLED3 = true;
        bool invLED4 = true;
        bool invLED5 = true;
        bool invLED6 = true;
        bool invLED7 = true;

        //Controle do Relé
        bool cntrele = true;

        //Conrole do PWM
        bool pwm;
        int aux = 0;

        public ControlCenter()
        {
            InitializeComponent();
            VarreCOMs();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataReceived); // Metodo para receber dados
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)         //Função para tratar o recebimento de dados
        {
            bfRecebe = serialPort1.ReadExisting();  //Variavel para receber dados
        }

       

        private void VarreCOMs()
        {
            #region Config_Port
            string[] valoresPort = SerialPort.GetPortNames();
            for (int i = 0; i < valoresPort.Length;i++)
            {
                cbPort.Items.Add(valoresPort[i]);
            }
            cbPort.Text = "COM1";
            #endregion

            #region Config_Baud
            int[] valoresBaud = { 2400, 4800, 9600, 57600, 115200 };
            for (int i = 0; i < valoresBaud.Length; i++)
            {
                cbBaud.Items.Add(valoresBaud[i].ToString());
            }
            cbBaud.Text = "9600";
            #endregion
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true) serialPort1.Close();
            else
            {
                serialPort1.PortName = cbPort.Text;
                serialPort1.BaudRate = int.Parse(cbBaud.Text);
                serialPort1.DataBits = 8;
                serialPort1.Parity = Parity.None;
                serialPort1.StopBits = StopBits.One;
            }
            try 
            {
                serialPort1.Open();
                btConnect.Enabled = false;
                btDisconect.Enabled = true;
                cbPort.Enabled = false;
                cbBaud.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Erro de comunicação com a porta Serial");
                MessageBox.Show("Configure a Porta COM e o Baud Rate da conexão Serial");

                
                btConnect.Enabled = true;
                btDisconect.Enabled = false;
                cbPort.Enabled = true;
                cbBaud.Enabled = true;
            }
        }

        private void btDisconect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                btConnect.Enabled = true;
                btDisconect.Enabled = false;
                cbBaud.Enabled = true;
                cbPort.Enabled = true;
            }
            catch
            {
                btConnect.Enabled = false;
                btDisconect.Enabled = true;
                cbBaud.Enabled = true;
                cbPort.Enabled = true;
            }
        }

        private void btLeituraAD_Click(object sender, EventArgs e)
        {
            tbLeitura.Text = "";
            serialPort1.Write("l");
            tbLeitura.AppendText(bfRecebe); //Ao clicar no botão é apresentada na texbox a informação recebida
        }

        private void btLED0_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen == true & invLED0 == true)
            {
                serialPort1.Write("0");
                btLED0.BackColor = Color.Green;
                invLED0 = false;
            }
            else if (serialPort1.IsOpen == true & invLED0 == false)
            {
                serialPort1.Write("0");
                btLED0.BackColor = Color.LightGray;
                invLED0 = true;
            }
            if(serialPort1.IsOpen == false)
            {
                MessageBox.Show("Erro de comunicação, verifique o Controle de Conexão Serial");
            }
        }

        private void btLED1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true & invLED1 == true)
            {
                serialPort1.Write("1");
                btLED1.BackColor = Color.Green;
                invLED1 = false;
            }
            else if (serialPort1.IsOpen == true & invLED1 == false)
            {
                serialPort1.Write("1");
                btLED1.BackColor = Color.LightGray;
                invLED1 = true;
            }
            if (serialPort1.IsOpen == false)
            {
                MessageBox.Show("Erro de comunicação, verifique o Controle de Conexão Serial");
            }
        }

        private void btLED2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true & invLED2 == true)
            {
                serialPort1.Write("2");
                btLED1.BackColor = Color.Green;
                invLED2 = false;
            }
            else if (serialPort1.IsOpen == true & invLED2 == false)
            {
                serialPort1.Write("2");
                btLED1.BackColor = Color.LightGray;
                invLED2 = true;
            }
            if (serialPort1.IsOpen == false)
            {
                MessageBox.Show("Erro de comunicação, verifique o Controle de Conexão Serial");
            }
        }

        private void btLED3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true & invLED3 == true)
            {
                serialPort1.Write("3");
                btLED3.BackColor = Color.Green;
                invLED3 = false;
            }
            else if (serialPort1.IsOpen == true & invLED3 == false)
            {
                serialPort1.Write("3");
                btLED3.BackColor = Color.LightGray;
                invLED3 = true;
            }
            if (serialPort1.IsOpen == false)
            {
                MessageBox.Show("Erro de comunicação, verifique o Controle de Conexão Serial");
            }
        }

        private void btLED4_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true & invLED4 == true)
            {
                serialPort1.Write("4");
                btLED4.BackColor = Color.Green;
                invLED4 = false;
            }
            else if (serialPort1.IsOpen == true & invLED4 == false)
            {
                serialPort1.Write("4");
                btLED4.BackColor = Color.LightGray;
                invLED4 = true;
            }
            if (serialPort1.IsOpen == false)
            {
                MessageBox.Show("Erro de comunicação, verifique o Controle de Conexão Serial");
            }
        }

        private void btLED5_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true & invLED5 == true)
            {
                serialPort1.Write("5");
                btLED5.BackColor = Color.Green;
                invLED5 = false;
            }
            else if (serialPort1.IsOpen == true & invLED5 == false)
            {
                serialPort1.Write("5");
                btLED5.BackColor = Color.LightGray;
                invLED5 = true;
            }
            if (serialPort1.IsOpen == false)
            {
                MessageBox.Show("Erro de comunicação, verifique o Controle de Conexão Serial");
            }
        }

        private void btLED6_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true & invLED6 == true)
            {
                serialPort1.Write("6");
                btLED6.BackColor = Color.Green;
                invLED6 = false;
            }
            else if (serialPort1.IsOpen == true & invLED6 == false)
            {
                serialPort1.Write("6");
                btLED6.BackColor = Color.LightGray;
                invLED6 = true;
            }
            if (serialPort1.IsOpen == false)
            {
                MessageBox.Show("Erro de comunicação, verifique o Controle de Conexão Serial");
            }
        }

        private void btLED7_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true & invLED7 == true)
            {
                serialPort1.Write("7");
                btLED7.BackColor = Color.Green;
                invLED7 = false;
            }
            else if (serialPort1.IsOpen == true & invLED7 == false)
            {
                serialPort1.Write("7");
                btLED7.BackColor = Color.LightGray;
                invLED7 = true;
            }
            if (serialPort1.IsOpen == false)
            {
                MessageBox.Show("Erro de comunicação, verifique o Controle de Conexão Serial");
            }
        }

        private void btRele_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen == true & cntrele == true)
            {
                serialPort1.Write("r");
                btRele.Text = "Ligado";
                btRele.BackColor = Color.Green;
                cntrele = false;
            }
            else if (serialPort1.IsOpen == true & cntrele == false)
            {
                serialPort1.Write("r");
                btRele.Text = "Desligado";
                btRele.BackColor = Color.LightGray;
                cntrele = true;
            }
            if (serialPort1.IsOpen == false)
            {
                MessageBox.Show("Erro de comunicação, verifique o Controle de Conexão Serial");
            }
        }

        private void cbCtrlPWM_CheckedChanged(object sender, EventArgs e)
        {
            if(pwm)
            {
                pwm = false;                                                //Liga o PWM
                serialPort1.WriteLine("<");
                TrPWM.Enabled = false;
            }
            else
            {
                pwm = true;                                                 //Desliga o PWM
                serialPort1.WriteLine(">");
                TrPWM.Enabled = true;
            }
        }

        private void TrPWM_Scroll(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {

                if(pwm)
                {
                    if(TrPWM.Value < 11)
                    {
                        if(TrPWM.Value > aux)
                        {
                            serialPort1.WriteLine("]"); //Incrementa o Duty Cicle do PWM
                            aux = TrPWM.Value;
                        }
                        if(TrPWM.Value < aux)
                        {
                            serialPort1.WriteLine(")"); //Decrementa o Duty Cicle do PWM
                            aux = TrPWM.Value;
                        }
                    }
                }
            }
        }
    }
}
