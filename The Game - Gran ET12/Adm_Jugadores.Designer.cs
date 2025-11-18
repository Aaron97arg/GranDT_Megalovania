namespace The_Game___Gran_ET12
{
    partial class Adm_Jugadores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox_ListaJ = new GroupBox();
            btton_Puntuaciones = new Button();
            dtgridview1 = new DataGridView();
            btton_Actualizar = new Button();
            btton_Borrar = new Button();
            label_Titulo = new Label();
            groupBox1 = new GroupBox();
            txtBox_Apodo = new TextBox();
            label2 = new Label();
            txtBox_Cotizacion = new TextBox();
            label1 = new Label();
            btton_Cancelar = new Button();
            label_Nombre = new Label();
            bttn_Agregar = new Button();
            label_Tipo = new Label();
            txtBox_Nombre = new TextBox();
            txtBox_ID = new TextBox();
            groupBox_ListaJ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgridview1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_ListaJ
            // 
            groupBox_ListaJ.BackColor = SystemColors.ActiveCaption;
            groupBox_ListaJ.Controls.Add(btton_Puntuaciones);
            groupBox_ListaJ.Controls.Add(dtgridview1);
            groupBox_ListaJ.Controls.Add(btton_Actualizar);
            groupBox_ListaJ.Controls.Add(btton_Borrar);
            groupBox_ListaJ.Location = new Point(78, 204);
            groupBox_ListaJ.Name = "groupBox_ListaJ";
            groupBox_ListaJ.Size = new Size(647, 188);
            groupBox_ListaJ.TabIndex = 12;
            groupBox_ListaJ.TabStop = false;
            groupBox_ListaJ.Text = "Jugadores Nuevos";
            // 
            // btton_Puntuaciones
            // 
            btton_Puntuaciones.Location = new Point(528, 44);
            btton_Puntuaciones.Name = "btton_Puntuaciones";
            btton_Puntuaciones.Size = new Size(101, 40);
            btton_Puntuaciones.TabIndex = 11;
            btton_Puntuaciones.Text = "Puntuaciones";
            btton_Puntuaciones.UseVisualStyleBackColor = true;
            btton_Puntuaciones.Click += btton_Puntuaciones_Click;
            // 
            // dtgridview1
            // 
            dtgridview1.AllowUserToOrderColumns = true;
            dtgridview1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgridview1.Location = new Point(25, 22);
            dtgridview1.Name = "dtgridview1";
            dtgridview1.Size = new Size(482, 150);
            dtgridview1.TabIndex = 10;
            // 
            // btton_Actualizar
            // 
            btton_Actualizar.Location = new Point(528, 136);
            btton_Actualizar.Name = "btton_Actualizar";
            btton_Actualizar.Size = new Size(101, 40);
            btton_Actualizar.TabIndex = 9;
            btton_Actualizar.Text = "Actualizar";
            btton_Actualizar.UseVisualStyleBackColor = true;
            // 
            // btton_Borrar
            // 
            btton_Borrar.Location = new Point(528, 90);
            btton_Borrar.Name = "btton_Borrar";
            btton_Borrar.Size = new Size(101, 40);
            btton_Borrar.TabIndex = 8;
            btton_Borrar.Text = "Eliminar";
            btton_Borrar.UseVisualStyleBackColor = true;
            btton_Borrar.Click += btton_Borrar_Click_1;
            // 
            // label_Titulo
            // 
            label_Titulo.AutoSize = true;
            label_Titulo.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label_Titulo.Location = new Point(299, 6);
            label_Titulo.Name = "label_Titulo";
            label_Titulo.Size = new Size(230, 37);
            label_Titulo.TabIndex = 11;
            label_Titulo.Text = "Cargar Jugadores";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(txtBox_Apodo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBox_Cotizacion);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btton_Cancelar);
            groupBox1.Controls.Add(label_Nombre);
            groupBox1.Controls.Add(bttn_Agregar);
            groupBox1.Controls.Add(label_Tipo);
            groupBox1.Controls.Add(txtBox_Nombre);
            groupBox1.Controls.Add(txtBox_ID);
            groupBox1.Location = new Point(12, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(764, 141);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // txtBox_Apodo
            // 
            txtBox_Apodo.Location = new Point(650, 48);
            txtBox_Apodo.Name = "txtBox_Apodo";
            txtBox_Apodo.Size = new Size(100, 23);
            txtBox_Apodo.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(581, 46);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 11;
            label2.Text = "Apodo";
            // 
            // txtBox_Cotizacion
            // 
            txtBox_Cotizacion.Location = new Point(471, 46);
            txtBox_Cotizacion.Name = "txtBox_Cotizacion";
            txtBox_Cotizacion.Size = new Size(99, 23);
            txtBox_Cotizacion.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(360, 41);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 9;
            label1.Text = "Cotizacion";
            // 
            // btton_Cancelar
            // 
            btton_Cancelar.Location = new Point(407, 88);
            btton_Cancelar.Name = "btton_Cancelar";
            btton_Cancelar.Size = new Size(144, 35);
            btton_Cancelar.TabIndex = 8;
            btton_Cancelar.Text = "Cancelar";
            btton_Cancelar.UseVisualStyleBackColor = true;
            btton_Cancelar.Click += btton_Cancelar_Click_1;
            // 
            // label_Nombre
            // 
            label_Nombre.AutoSize = true;
            label_Nombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Nombre.Location = new Point(8, 41);
            label_Nombre.Name = "label_Nombre";
            label_Nombre.Size = new Size(86, 25);
            label_Nombre.TabIndex = 6;
            label_Nombre.Text = "Nombre";
            // 
            // bttn_Agregar
            // 
            bttn_Agregar.Location = new Point(245, 88);
            bttn_Agregar.Name = "bttn_Agregar";
            bttn_Agregar.Size = new Size(144, 35);
            bttn_Agregar.TabIndex = 7;
            bttn_Agregar.Text = "Agregar";
            bttn_Agregar.UseVisualStyleBackColor = true;
            bttn_Agregar.Click += bttn_Agregar_Click;
            // 
            // label_Tipo
            // 
            label_Tipo.AutoSize = true;
            label_Tipo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Tipo.Location = new Point(206, 41);
            label_Tipo.Name = "label_Tipo";
            label_Tipo.Size = new Size(52, 25);
            label_Tipo.TabIndex = 4;
            label_Tipo.Text = "Tipo";
            // 
            // txtBox_Nombre
            // 
            txtBox_Nombre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBox_Nombre.Location = new Point(91, 41);
            txtBox_Nombre.Name = "txtBox_Nombre";
            txtBox_Nombre.Size = new Size(109, 25);
            txtBox_Nombre.TabIndex = 5;
            // 
            // txtBox_ID
            // 
            txtBox_ID.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBox_ID.Location = new Point(254, 41);
            txtBox_ID.Name = "txtBox_ID";
            txtBox_ID.Size = new Size(90, 25);
            txtBox_ID.TabIndex = 3;
            // 
            // Adm_Jugadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 401);
            Controls.Add(groupBox_ListaJ);
            Controls.Add(label_Titulo);
            Controls.Add(groupBox1);
            Name = "Adm_Jugadores";
            Text = "Adm_Jugadores";
            Load += Adm_Jugadores_Load;
            groupBox_ListaJ.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgridview1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox_ListaJ;
        private DataGridView dtgridview1;
        private Button btton_Actualizar;
        private Button btton_Borrar;
        private Label label_Titulo;
        private GroupBox groupBox1;
        private Button btton_Cancelar;
        private Label label_Nombre;
        private Button bttn_Agregar;
        private TextBox txtBox_Nombre;
        private Label label_Tipo;
        private TextBox txtBox_ID;
        private TextBox txtBox_Cotizacion;
        private Label label1;
        private Button btton_Puntuaciones;
        private Label label2;
        private TextBox txtBox_Apodo;
    }
}