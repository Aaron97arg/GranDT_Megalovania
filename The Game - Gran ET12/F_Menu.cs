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
    public partial class F_Menu : Form
    {
        public F_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //El Var es un tipo de variable que depende del contexto en la cual hace referencia a lo que inicializa (para definir y reservar memoria en la variable "para rellenar")  

            var f_InicioSesion = new F_InicioSesion();

            f_InicioSesion.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f_CrearCuenta = new F_CrearCuenta();

            f_CrearCuenta.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var f_Game1 = new F_Game1();

            f_Game1.Show();

            this.Hide();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Opcion de menu Salir (Cierra el programa):
            /*Muestra con Show(preguntando S/N cerrar el programa), y con If evalua si el mensaje es igual a "DialogResult.Yes" lo cierra, sino
            no hace nada. 
            */

            DialogResult MensajeCerrarP = MessageBox.Show("Quiere cerrar el programa? S/N", "Alerta Cerrar Programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (MensajeCerrarP == DialogResult.Yes)
            {

                Application.Exit();
                //this.Close();
            }

        }
    }
}
