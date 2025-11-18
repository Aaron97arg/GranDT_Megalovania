using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Game___Gran_ET12
{
    public partial class F_InicioSesion : Form
    {
        public F_InicioSesion()
        {
            InitializeComponent();
        }

        private void F_InicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //El Var es un tipo de variable que depende del contexto en la cual hace referencia a lo que inicializa (para definir y reservar memoria en la variable "para rellenar")  

            if(textBox1.Text == "ADMIN" && textBox2.Text == "12345" )
            {
                var adm_Jugadores = new Adm_Jugadores();

                adm_Jugadores.Show();

                this.Hide();
            }
            else
            {
                var f_menu = new F_Menu ();

                f_menu.Show();

                this.Hide();
            }


        }
    }
}
