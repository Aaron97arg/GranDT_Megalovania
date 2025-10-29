namespace The_Game___Gran_ET12
{
    partial class Adm_Puntuaciones
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
            dtgridview1 = new DataGridView();
            btton_Actualizar = new Button();
            btton_Borrar = new Button();
            label_Titulo = new Label();
            groupBox1 = new GroupBox();
            txtBox_Puntuacion = new TextBox();
            label1 = new Label();
            btton_Cancelar = new Button();
            label_Nombre = new Label();
            btton_Agregar = new Button();
            txtBox_Nombre = new TextBox();
            label_Tipo = new Label();
            txtBox_Tipo = new TextBox();
            groupBox_ListaJ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgridview1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_ListaJ
            // 
            groupBox_ListaJ.BackColor = SystemColors.ActiveCaption;
            groupBox_ListaJ.Controls.Add(dtgridview1);
            groupBox_ListaJ.Controls.Add(btton_Actualizar);
            groupBox_ListaJ.Controls.Add(btton_Borrar);
            groupBox_ListaJ.Location = new Point(129, 212);
            groupBox_ListaJ.Name = "groupBox_ListaJ";
            groupBox_ListaJ.Size = new Size(576, 188);
            groupBox_ListaJ.TabIndex = 16;
            groupBox_ListaJ.TabStop = false;
            groupBox_ListaJ.Text = "Filtro Jugadores";
            // 
            // dtgridview1
            // 
            dtgridview1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgridview1.Location = new Point(25, 22);
            dtgridview1.Name = "dtgridview1";
            dtgridview1.Size = new Size(420, 150);
            dtgridview1.TabIndex = 10;
            // 
            // btton_Actualizar
            // 
            btton_Actualizar.Location = new Point(463, 133);
            btton_Actualizar.Name = "btton_Actualizar";
            btton_Actualizar.Size = new Size(101, 40);
            btton_Actualizar.TabIndex = 9;
            btton_Actualizar.Text = "Actualizar";
            btton_Actualizar.UseVisualStyleBackColor = true;
            // 
            // btton_Borrar
            // 
            btton_Borrar.Location = new Point(463, 87);
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
            label_Titulo.Location = new Point(268, 9);
            label_Titulo.Name = "label_Titulo";
            label_Titulo.Size = new Size(271, 37);
            label_Titulo.TabIndex = 15;
            label_Titulo.Text = "Cargar Puntuaciones";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(txtBox_Puntuacion);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btton_Cancelar);
            groupBox1.Controls.Add(label_Tipo);
            groupBox1.Controls.Add(txtBox_Tipo);
            groupBox1.Controls.Add(label_Nombre);
            groupBox1.Controls.Add(btton_Agregar);
            groupBox1.Controls.Add(txtBox_Nombre);
            groupBox1.Location = new Point(103, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(630, 141);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // txtBox_Puntuacion
            // 
            txtBox_Puntuacion.Location = new Point(517, 49);
            txtBox_Puntuacion.Name = "txtBox_Puntuacion";
            txtBox_Puntuacion.Size = new Size(94, 23);
            txtBox_Puntuacion.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(400, 47);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 9;
            label1.Text = "Puntuacion";
            // 
            // btton_Cancelar
            // 
            btton_Cancelar.Location = new Point(322, 91);
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
            label_Nombre.Location = new Point(17, 47);
            label_Nombre.Name = "label_Nombre";
            label_Nombre.Size = new Size(86, 25);
            label_Nombre.TabIndex = 6;
            label_Nombre.Text = "Nombre";
            // 
            // btton_Agregar
            // 
            btton_Agregar.Location = new Point(160, 91);
            btton_Agregar.Name = "btton_Agregar";
            btton_Agregar.Size = new Size(144, 35);
            btton_Agregar.TabIndex = 7;
            btton_Agregar.Text = "Agregar";
            btton_Agregar.UseVisualStyleBackColor = true;
            btton_Agregar.Click += btton_Agregar_Click_1;
            // 
            // txtBox_Nombre
            // 
            txtBox_Nombre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBox_Nombre.Location = new Point(102, 47);
            txtBox_Nombre.Name = "txtBox_Nombre";
            txtBox_Nombre.Size = new Size(90, 25);
            txtBox_Nombre.TabIndex = 5;
            // 
            // label_Tipo
            // 
            label_Tipo.AutoSize = true;
            label_Tipo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Tipo.Location = new Point(231, 47);
            label_Tipo.Name = "label_Tipo";
            label_Tipo.Size = new Size(52, 25);
            label_Tipo.TabIndex = 4;
            label_Tipo.Text = "Tipo";
            // 
            // txtBox_Tipo
            // 
            txtBox_Tipo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBox_Tipo.Location = new Point(290, 47);
            txtBox_Tipo.Name = "txtBox_Tipo";
            txtBox_Tipo.Size = new Size(75, 25);
            txtBox_Tipo.TabIndex = 3;
            // 
            // Adm_Puntuaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox_ListaJ);
            Controls.Add(label_Titulo);
            Controls.Add(groupBox1);
            Name = "Adm_Puntuaciones";
            Text = "AdmPuntuaciones";
            Load += Adm_Puntuaciones_Load;
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
        private Button btton_Agregar;
        private TextBox txtBox_Nombre;
        private Label label_Tipo;
        private TextBox txtBox_Tipo;
        private Label label1;
        private TextBox txtBox_Puntuacion;
    }
}