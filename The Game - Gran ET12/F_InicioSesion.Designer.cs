namespace The_Game___Gran_ET12
{
    partial class F_InicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_InicioSesion));
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            label_Nombre = new Label();
            textBox1 = new TextBox();
            label_Contraseña = new Label();
            label3 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label_Nombre);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label_Contraseña);
            groupBox1.Location = new Point(38, 157);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(273, 139);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(126, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(120, 20);
            textBox2.TabIndex = 4;
            // 
            // label_Nombre
            // 
            label_Nombre.AutoSize = true;
            label_Nombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Nombre.ForeColor = Color.White;
            label_Nombre.Location = new Point(16, 36);
            label_Nombre.Name = "label_Nombre";
            label_Nombre.Size = new Size(86, 25);
            label_Nombre.TabIndex = 2;
            label_Nombre.Text = "Nombre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(126, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 20);
            textBox1.TabIndex = 3;
            // 
            // label_Contraseña
            // 
            label_Contraseña.AutoSize = true;
            label_Contraseña.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Contraseña.ForeColor = Color.White;
            label_Contraseña.Location = new Point(7, 81);
            label_Contraseña.Name = "label_Contraseña";
            label_Contraseña.Size = new Size(113, 25);
            label_Contraseña.TabIndex = 1;
            label_Contraseña.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(38, 52);
            label3.Name = "label3";
            label3.Size = new Size(282, 65);
            label3.TabIndex = 1;
            label3.Text = "Bienvenido";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(111, 302);
            button1.Name = "button1";
            button1.Size = new Size(122, 41);
            button1.TabIndex = 2;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // F_InicioSesion
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(346, 486);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "F_InicioSesion";
            Text = "Form2";
            Load += F_InicioSesion_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox2;
        private Label label_Nombre;
        private TextBox textBox1;
        private Label label_Contraseña;
        private Label label3;
        private Button button1;
    }
}