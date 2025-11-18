namespace The_Game___Gran_ET12
{
    partial class F_Game1
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
            dataGridView1 = new DataGridView();
            Jugador = new DataGridViewTextBoxColumn();
            TipoJugador = new DataGridViewTextBoxColumn();
            Cotizacion = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            button1 = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Jugador, TipoJugador, Cotizacion });
            dataGridView1.Location = new Point(279, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(344, 150);
            dataGridView1.TabIndex = 4;
            // 
            // Jugador
            // 
            Jugador.HeaderText = "Jugador";
            Jugador.Name = "Jugador";
            Jugador.ReadOnly = true;
            // 
            // TipoJugador
            // 
            TipoJugador.HeaderText = "TipoJugador";
            TipoJugador.Name = "TipoJugador";
            TipoJugador.ReadOnly = true;
            // 
            // Cotizacion
            // 
            Cotizacion.HeaderText = "Cotizacion";
            Cotizacion.Name = "Cotizacion";
            Cotizacion.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(40, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(647, 207);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(103, 168);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(141, 51);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 12;
            comboBox2.Text = "Tipo";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(16, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(119, 23);
            comboBox1.TabIndex = 11;
            comboBox1.Text = "Jugador";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(182, -3);
            label1.Name = "label1";
            label1.Size = new Size(301, 37);
            label1.TabIndex = 8;
            label1.Text = "Plantilla de Jugadores";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Location = new Point(53, 225);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(616, 227);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.fondoPartido;
            pictureBox1.Location = new Point(3, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(610, 205);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // F_Game1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(727, 466);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "F_Game1";
            Text = "F_Game1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Jugador;
        private DataGridViewTextBoxColumn TipoJugador;
        private DataGridViewTextBoxColumn Cotizacion;
        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Button button1;
        private ComboBox comboBox2;
    }
}