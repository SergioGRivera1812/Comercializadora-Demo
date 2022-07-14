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
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Reimpresion : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=Demo;Integrated Security=True");
        DataTable Producto = new DataTable(); //DataTable

        public Reimpresion()
        {
            InitializeComponent();
            dataGridView1.DataSource = Producto;
        }
        [DllImport("user32.dll")]
        public static extern int FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern int SendMessage(int hWnd, uint Msg, int wParam, int lParam);

        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_CLOSE = 0xF060;

        private void Reimpresion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'demoDataSet1.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.demoDataSet1.Producto);

            Fecha.Text = "";
            Hora.Text = "";
            TipoProd.Text = "";
            Parvada.Text = "";
            Peso.Text = "";



        }
        private void closeOnscreenKeyboard()
        {

            int iHandle = FindWindow("IPTIP_Main_Window", "");
            if (iHandle > 0)
            {

                SendMessage(iHandle, WM_SYSCOMMAND, SC_CLOSE, 0);
            }
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
            string keyboardPath = Path.Combine(progFiles, "TabTip.exe");
            Process.Start(keyboardPath);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            closeOnscreenKeyboard();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void Buscar_KeyUp(object sender, KeyEventArgs e)
        {
            conexion.Open();

            SqlCommand cmd = conexion.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Producto where TProducto like ('" + Buscar.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            dataGridView1.DataSource = dt;
            //SqlDataReader registro = cmd.ExecuteReader();



            conexion.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string F = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string H = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string P = this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string Pr = this.dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                string C = this.dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

                // ID.Text = id;
                Fecha.Text = F;
                Hora.Text = H;
                TipoProd.Text = Pr;
                Parvada.Text = C;
                Peso.Text = P;


            }
            catch (System.ArgumentOutOfRangeException)
            {

                MessageBox.Show("Favor de seleccionar la primera columna para continuar", "AVISO");
            }


        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            if(this.dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Favor de llenar los campos para poder continuar", "AVISO");
            }
            else
            {
                string contenido = Fecha.Text + "\n" + Hora.Text + "\n" + TipoProd.Text + "\n" + "P/C " + Parvada.Text + "\n" + Peso.Text + " KG";
                QRCodeGenerator qrGenerador = new QRCodeGenerator();
                QRCodeData qrDatos = qrGenerador.CreateQrCode(contenido, QRCodeGenerator.ECCLevel.H);
                QRCode qrCodigo = new QRCode(qrDatos);

                Bitmap qrImagen = qrCodigo.GetGraphic(5, Color.Black, Color.White, true);
                pictureBox2.Image = qrImagen;

                printDocument1 = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                printDocument1.PrinterSettings = ps;
                printDocument1.PrintPage += RImprimir;
                printDocument1.Print();
            }
            
        }

        private void RImprimir(object sender, PrintPageEventArgs e)
        {
            //FormQR q = new FormQR();
            string f = Fecha.Text, h = Hora.Text, p = Peso.Text, pr = TipoProd.Text, c = Parvada.Text;
            Font font = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);
            int width = 600;

            e.Graphics.DrawString("Etiqueta de Producto", font, Brushes.Black, new RectangleF(10, 20, width, 20));
            e.Graphics.DrawString("Fecha:  " + f, font, Brushes.Black, new RectangleF(10, 60, width, 20));
            e.Graphics.DrawString("Hora:  " + h, font, Brushes.Black, new RectangleF(10, 80, width, 20));
            e.Graphics.DrawString("Tipo de producto:  " + pr, font, Brushes.Black, new RectangleF(10, 100, width, 20));
            e.Graphics.DrawString("Parvada:  " + c, font, Brushes.Black, new RectangleF(10, 120, width, 20));
            e.Graphics.DrawString("Peso del producto:  " + p + " Kg", font, Brushes.Black, new RectangleF(10, 140, width, 20));
            e.Graphics.DrawImage(pictureBox2.Image, 240, 250, 130, 130);
        }
    
    }
}
