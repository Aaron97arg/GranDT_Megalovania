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
    public partial class F_CrearCuenta : Form
    {
        public F_CrearCuenta()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var f_Menu = new F_Menu();

            f_Menu.Show();

            this.Hide();
        }
    }
}
