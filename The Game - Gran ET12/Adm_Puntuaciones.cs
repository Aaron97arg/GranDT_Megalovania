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
    public partial class Adm_Puntuaciones : Form
    {
        public Adm_Puntuaciones()
        {
            InitializeComponent();
        }

        // -------------------< Para elementos en tiempo de ejecucion, como inicializaciones,"Para cargar cuando se ejecuta el form" "Carga las Columnas del dtgridview1" >-------------------
        private void Adm_Puntuaciones_Load(object sender, EventArgs e) //OK
        {
            dtgridview1.Columns.Add("Nombre", "Nombre");
            dtgridview1.Columns.Add("Tipo", "Tipo");
            dtgridview1.Columns.Add("Puntuacion", "Puntuacion");

        }

        // -------------------< Boton "Agregar", agrega nuevos jugadores por los "txtBox"  >-------------------
        private void btton_Agregar_Click_1(object sender, EventArgs e) //OK
        {
            if (txtBox_Nombre.Text == "" ||  txtBox_Tipo.Text == "" || txtBox_Puntuacion.Text == "")
            {
                MessageBox.Show("Error de campo vacio", "Error no se puede agregar con campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Sino se Inicializa una variable 
            {
                dtgridview1.Rows.Add(txtBox_Nombre.Text, txtBox_Tipo.Text , txtBox_Puntuacion.Text);

                //Al agregar borra lo escrito anteriormente 
                txtBox_Tipo.Clear();
                txtBox_Nombre.Clear();
                txtBox_Puntuacion.Clear();

            }
        }

        // -------------------< Boton "Cancelar", borra lo que se esta escribiendo en los "txtBox"  >-------------------
        private void btton_Cancelar_Click_1(object sender, EventArgs e) //OK
        {
            //Borra lo escrito, "Cancelando" 
            txtBox_Tipo.Clear();
            txtBox_Nombre.Clear();
            txtBox_Puntuacion.Clear();
        }

        // -------------------< Boton "Borrar", borra lo de la lista de jugadores en el "dtgridview1" >-------------------
        private void btton_Borrar_Click_1(object sender, EventArgs e) //ok
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
    
    }
}

