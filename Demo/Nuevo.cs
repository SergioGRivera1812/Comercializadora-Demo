using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Nuevo : Form
    {
        public Nuevo()
        {
            InitializeComponent();
        }

        private void AñadirP_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=Demo;Integrated Security=True");
            
            string query = "INSERT INTO Puertos (Puerto) VALUES (@Puerto)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@Puerto", Puerto.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Puerto añadido");
        }

        private void AñadirB_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=Demo;Integrated Security=True");

            string query = "INSERT INTO Baudios (Baudio) VALUES (@Baudio)";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@Baudio", Baudio.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("Baudio añadido");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
