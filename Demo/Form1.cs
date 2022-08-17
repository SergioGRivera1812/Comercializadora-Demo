using Demo.Properties;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=Demo;Integrated Security=True");
        System.Diagnostics.Process oskProcess = null;
        private delegate void DelegadoAcceso(string accion);
        public Form1()
        {
            InitializeComponent();
            
        }

        public Form1(object selectedValue)
        {
            SelectedValue = selectedValue;
        }

        [DllImport("user32.dll")]
        public static extern int FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern int SendMessage(int hWnd, uint Msg, int wParam, int lParam);

        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_CLOSE = 0xF060;

        public object SelectedValue { get; }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'demoDataSetBaudios.Baudios' Puede moverla o quitarla según sea necesario.
            this.baudiosTableAdapter.Fill(this.demoDataSetBaudios.Baudios);
            // TODO: esta línea de código carga datos en la tabla 'demoDataSetPuertos.Puertos' Puede moverla o quitarla según sea necesario.
            this.puertosTableAdapter.Fill(this.demoDataSetPuertos.Puertos);
            // TODO: esta línea de código carga datos en la tabla 'demoDataSet1.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter1.Fill(this.demoDataSet1.Producto);
            Fecha.Text = DateTime.Now.ToString("d");
            CargarConf();
            string P = textPuerto.Text;
            Settings.Default.Puerto = P;
            string B = textBaudio.Text;
            Settings.Default.Baudio = B;
            int Bau = Int32.Parse(B);



            try
            {
                serialPort1 = new SerialPort(P,Bau, Parity.None, 8, StopBits.One);
                serialPort1.Handshake = Handshake.None;
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
                serialPort1.ReadTimeout = 500;
                serialPort1.WriteTimeout = 500;
                serialPort1.Open();
                serialPort1.Write("0P");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

            void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
            {
                if (this.Enabled == false)
                {
                    MessageBox.Show("Error de comunicación", "ERROR");
                }
                else
                {
                    try
                    {


                        //Thread.Sleep(500);
                        string data = serialPort1.ReadLine();

                        data = data.Replace("KG", string.Empty);
                        data = data.Replace("M", string.Empty);
                        data = data.Replace("G", string.Empty);
                        data = data.Replace("N", string.Empty);
                        data = data.Replace("l", string.Empty);
                        data = data.Replace("M", string.Empty);
                        data = data.Replace("O", string.Empty);

                    string cadenaLimpia = data.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("", string.Empty).Replace(" ", string.Empty);


                        this.BeginInvoke(new DelegadoAcceso(si_DataReceived), new object[] { data });

                    }
                    catch (Exception)
                    {

                        MessageBox.Show("El indicador no envia datos", "ERROR");
                    }

                }

            }
        
       private void si_DataReceived(string accion)
        {
               Indicador.Text = accion;

       }
        

        private void button1_Click(object sender, EventArgs e)
        {        
            closeOnscreenKeyboard();

        }

        private void textParv_Click(object sender, EventArgs e)
        {
            string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
            string keyboardPath = Path.Combine(progFiles, "TabTip.exe");
            oskProcess= Process.Start(keyboardPath);

        }

        private void closeOnscreenKeyboard()
        {
             
            int iHandle = FindWindow("IPTIP_Main_Window", "");
            if (iHandle > 0)
            {
                    
                SendMessage(iHandle, WM_SYSCOMMAND, SC_CLOSE, 0);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string v = DateTime.Now.ToString("T");
            Hora.Text = v;
        }

        private void Cargar_Click(object sender, EventArgs e)
        {
            if (comboProd.Text == String.Empty || textParv.Text == string.Empty)
            {
                MessageBox.Show("Selecciona el tipo de producto o introduce el numero de Parvada/Caseta para continuar", "ERROR");
            }
            else 
            {
                try
                {
                    string cadena = Indicador.Text;
                    String cadena2;
                    cadena = cadena.Replace("KG", "");
                    cadena2 = cadena.Replace("M", "");
                    string cadenaLimpia = cadena2.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("", "").Replace(" ", "");
                    int Peso = Int32.Parse(cadenaLimpia);



                    this.productoTableAdapter1.Guardar(DateTime.Now.ToString("d"), DateTime.Now.ToString("t"), Peso, comboProd.Text, textParv.Text);
                    this.productoTableAdapter1.Fill(this.demoDataSet1.Producto);

                    // FormQR q = new FormQR();
                    string contenido = comboProd.Text + "  P/C" + textParv.Text + Indicador.Text + "Kg" + " " + Fecha.Text + " " + Hora.Text;
                    QRCodeGenerator qrGenerador = new QRCodeGenerator();
                    QRCodeData qrDatos = qrGenerador.CreateQrCode(contenido, QRCodeGenerator.ECCLevel.H);
                    QRCode qrCodigo = new QRCode(qrDatos);

                    Bitmap qrImagen = qrCodigo.GetGraphic(5, Color.Black, Color.White, true);
                    pictureBox1.Image = qrImagen;

                    printDocument1 = new PrintDocument();
                    PrinterSettings ps = new PrinterSettings();
                    printDocument1.PrinterSettings = ps;
                    printDocument1.PrintPage += Imprimir;
                    printDocument1.Print();

                }
                catch (Exception )
                {
                    MessageBox.Show("Ocurrio un problema al imprimir el producto", "ERROR");
                }
            }
            


        }




        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            //FormQR q = new FormQR();
            string f = Fecha.Text, h = Hora.Text, p = Indicador.Text, pr = comboProd.Text, c = textParv.Text;
            Font font = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);
            int width = 600;
            
            e.Graphics.DrawString("Etiqueta de Producto", font, Brushes.Black, new RectangleF(10,20, width, 20));
            e.Graphics.DrawString("Fecha:  "+f, font, Brushes.Black, new RectangleF(10,   60, width, 20));
            e.Graphics.DrawString("Hora:  "+h, font, Brushes.Black, new RectangleF(10,   80, width, 20));
            e.Graphics.DrawString("Tipo de producto:  "+pr, font, Brushes.Black, new RectangleF(10, 100, width, 20));
            e.Graphics.DrawString("Parvada:  " + c, font, Brushes.Black, new RectangleF(10, 120, width, 20));
            e.Graphics.DrawString("Peso del producto:  "+p +"Kg", font, Brushes.Black, new RectangleF(10, 140 , width, 20));
            e.Graphics.DrawImage(pictureBox1.Image,240,250,130,130);
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuracion c = new Configuracion();
            c.Show();
            
        }

        private void reImpresiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reimpresion R = new Reimpresion();
            R.Show();
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            RestablecerConfig();
        }

        private void checkConf_CheckedChanged(object sender, EventArgs e)
        {
            Confirmar cn = new Confirmar();
            
            if (checkConf.Checked) {
                textBox1.Visible = true;
                button4.Visible = true;


            }
            else
            {
                textBox1.Visible = false;
                button4.Visible = false;
                textBox1.Text = "";
                
                

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin")
            {
                PanelOc.Visible = false;
                textBox1.Visible = false;
                button4.Visible = false;
               checkConf.Checked = false;
                closeOnscreenKeyboard();
            }
            else
            {
                MessageBox.Show("Constraseña incorrecta","AVISO");
                closeOnscreenKeyboard();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PanelOc.Visible=true;
            Fecha.Text = DateTime.Now.ToString("d");
            string P, B;
            P = textPuerto.Text;
            B = textBaudio.Text;
            int Bau =Int32.Parse(B);
            //CargarConf();
        }
        
        private void CargarConf()
        {
            textPuerto.Text = Settings.Default.Puerto;
            textBaudio.Text = Settings.Default.Baudio;


        }

        private void RestablecerConfig()
        {
            Settings.Default.Reset();
            CargarConf();
            MessageBox.Show("Se han Restablecido correctamente");
        }
        
        private void GuardarConfig()
        {
            Settings.Default.Puerto = textPuerto.Text;
            Settings.Default.Baudio = textBaudio.Text;
            Settings.Default.Save();
            MessageBox.Show("Se han guardado los cambios correctamente");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Puerto = textPuerto.Text;
            Settings.Default.Baudio = textBaudio.Text; 
            Settings.Default.Save();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GuardarConfig();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte r = new Reporte();
            r.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
            string keyboardPath = Path.Combine(progFiles, "TabTip.exe");
            oskProcess = Process.Start(keyboardPath);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            closeOnscreenKeyboard();
        }

        private void textPuerto_Click(object sender, EventArgs e)
        {
            string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
            string keyboardPath = Path.Combine(progFiles, "TabTip.exe");
            oskProcess = Process.Start(keyboardPath);
        }

        private void textBaudio_Click(object sender, EventArgs e)
        {
            string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
            string keyboardPath = Path.Combine(progFiles, "TabTip.exe");
            oskProcess = Process.Start(keyboardPath);
        }
    }
}
