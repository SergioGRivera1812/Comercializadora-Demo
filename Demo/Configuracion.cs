using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data.SqlClient;

namespace Demo
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'demoDataSetPuertos2.Puertos' Puede moverla o quitarla según sea necesario.
            this.puertosTableAdapter1.Fill(this.demoDataSetPuertos2.Puertos);
            // TODO: esta línea de código carga datos en la tabla 'demoDataSetBaudios.Baudios' Puede moverla o quitarla según sea necesario.
            this.baudiosTableAdapter.Fill(this.demoDataSetBaudios.Baudios);
            // TODO: esta línea de código carga datos en la tabla 'demoDataSetPuertos.Puertos' Puede moverla o quitarla según sea necesario.
            this.puertosTableAdapter.Fill(this.demoDataSetPuertos.Puertos);
            string P, B;
            B = comboBaudio.DataSource.ToString();
            P = comboPuerto.Text; 

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            /*int selectedIndex = comboPuerto.SelectedIndex;
            Object selectedItem = comboPuerto.SelectedItem;

            MessageBox.Show("Selected Item Text: " + selectedItem.ToString() + "\n" +
                            "Index: " + selectedIndex.ToString());*/

            //MessageBox.Show(B);



        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            Nuevo n = new Nuevo();
            n.Show();
        }

        private void comboPuerto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
