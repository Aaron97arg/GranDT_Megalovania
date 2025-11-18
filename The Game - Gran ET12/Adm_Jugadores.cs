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
    public partial class Adm_Jugadores : Form
    {
        public Adm_Jugadores()
        {
            InitializeComponent();
        }



        // -------------------< Para elementos en tiempo de ejecucion, como inicializaciones,"Para cargar cuando se ejecuta el form" >-------------------
        private void Adm_Jugadores_Load(object sender, EventArgs e) //ok 
        {
            dtgridview1.Columns.Add("Nombre", "Nombre");
            dtgridview1.Columns.Add("Tipo", "Tipo");
            dtgridview1.Columns.Add("Cotizacion", "Cotizacion");
            dtgridview1.Columns.Add("Apodo", "Apodo");

        }

        // -------------------< Boton "Agregar", agrega nuevos Jugadores por los "txtBox" >-------------------
        private void bttn_Agregar_Click(object sender, EventArgs e) //ok 
        {
            if (txtBox_ID.Text == "" || txtBox_Nombre.Text == "" || txtBox_Cotizacion.Text == "")
            {
                MessageBox.Show("Error de campo vacio", "Error no se puede agregar con campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Sino se Inicializa una variable 
            {
                dtgridview1.Rows.Add(txtBox_ID.Text, txtBox_Nombre.Text, txtBox_Cotizacion.Text, txtBox_Apodo.Text);

                //Al agregar borra lo escrito anteriormente 
                txtBox_ID.Clear();
                txtBox_Nombre.Clear();
                txtBox_Cotizacion.Clear();
                txtBox_Apodo.Clear();

            }
        }

        // -------------------< Boton "Cancelar", borra lo que se esta escribiendo en los "txtBox"  >-------------------
        private void btton_Cancelar_Click_1(object sender, EventArgs e) //OK
        {
            //Borra lo escrito, "Cancelando" 
            txtBox_ID.Clear();
            txtBox_Nombre.Clear();
            txtBox_Cotizacion.Clear();
            txtBox_Apodo.Clear();
        }

        // -------------------< Boton "Borrar", borra lo de la lista de juegos en el "dtgridview_Juegos" >-------------------
        private void btton_Borrar_Click_1(object sender, EventArgs e) //OK
        {
            if (dtgridview1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgridview1.SelectedRows)
                {
                    dtgridview1.Rows.Remove(row);

                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.");

            }
        }

        // -------------------< DataGridView donde se guardan y muestran los valores "dtgridview_Juegos" >-------------------


        private void btton_Puntuaciones_Click(object sender, EventArgs e) //ok
        {
            var adm_Puntuaciones = new Adm_Puntuaciones();
            adm_Puntuaciones.Show();

            this.Hide();
        }

        
    }
}


