using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Confirmar : Form
    {
        public Confirmar()
        {
            InitializeComponent();
        }

        private void textContraseña_KeyUp(object sender, KeyEventArgs e)
        {
            //textBox1.Text = "";
            // The password character is an asterisk.
            // The control will allow no more than 14 characters.
            textContraseña.PasswordChar = '*';
            textContraseña.MaxLength = 14;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textContraseña.Text == "admin")
            {
                //this.Dispose();   

            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta", "AVISO");
            }
        }
    }
}
