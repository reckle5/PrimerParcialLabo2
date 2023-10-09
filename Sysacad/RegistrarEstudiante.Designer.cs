namespace Sysacad
{
    partial class RegistrarEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarEstudiante));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            btnRegistrar = new Button();
            txtBoxNombreCompleto = new TextBox();
            txtBoxDni = new TextBox();
            txtBoxMail = new TextBox();
            txtBoxdireccion = new TextBox();
            txtBoxTelefono = new TextBox();
            txtBoxUsuario = new TextBox();
            txtBoxContraseña = new TextBox();
            btnAtras = new Button();
            checkBoxSi = new CheckBox();
            checkBoxNo = new CheckBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 85);
            label2.Name = "label2";
            label2.Size = new Size(37, 17);
            label2.TabIndex = 3;
            label2.Text = "UTN";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(271, 85);
            label1.Name = "label1";
            label1.Size = new Size(273, 25);
            label1.TabIndex = 4;
            label1.Text = "Registro de Estudiantes";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.DodgerBlue;
            btnRegistrar.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.ForeColor = SystemColors.ControlLightLight;
            btnRegistrar.Location = new Point(732, 410);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(81, 46);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "Confirmar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtBoxNombreCompleto
            // 
            txtBoxNombreCompleto.BackColor = Color.WhiteSmoke;
            txtBoxNombreCompleto.Location = new Point(445, 146);
            txtBoxNombreCompleto.Name = "txtBoxNombreCompleto";
            txtBoxNombreCompleto.PlaceholderText = "NOMBRE COMPLETO";
            txtBoxNombreCompleto.Size = new Size(320, 23);
            txtBoxNombreCompleto.TabIndex = 13;
            // 
            // txtBoxDni
            // 
            txtBoxDni.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxDni.BackColor = Color.WhiteSmoke;
            txtBoxDni.ForeColor = SystemColors.WindowText;
            txtBoxDni.Location = new Point(445, 184);
            txtBoxDni.Name = "txtBoxDni";
            txtBoxDni.PlaceholderText = "INGRESE DNI SIN PUNTOS";
            txtBoxDni.Size = new Size(320, 23);
            txtBoxDni.TabIndex = 14;
            // 
            // txtBoxMail
            // 
            txtBoxMail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxMail.BackColor = Color.WhiteSmoke;
            txtBoxMail.ForeColor = SystemColors.WindowText;
            txtBoxMail.Location = new Point(74, 225);
            txtBoxMail.Name = "txtBoxMail";
            txtBoxMail.PlaceholderText = "INGRESE DIRECCIÓN DE MAIL";
            txtBoxMail.Size = new Size(320, 23);
            txtBoxMail.TabIndex = 15;
            // 
            // txtBoxdireccion
            // 
            txtBoxdireccion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxdireccion.BackColor = Color.WhiteSmoke;
            txtBoxdireccion.ForeColor = SystemColors.WindowText;
            txtBoxdireccion.Location = new Point(445, 225);
            txtBoxdireccion.Name = "txtBoxdireccion";
            txtBoxdireccion.PlaceholderText = "INGRESE DIRECCIÓN";
            txtBoxdireccion.Size = new Size(320, 23);
            txtBoxdireccion.TabIndex = 16;
            // 
            // txtBoxTelefono
            // 
            txtBoxTelefono.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxTelefono.BackColor = Color.WhiteSmoke;
            txtBoxTelefono.ForeColor = SystemColors.WindowText;
            txtBoxTelefono.Location = new Point(445, 269);
            txtBoxTelefono.Name = "txtBoxTelefono";
            txtBoxTelefono.PlaceholderText = "INGRESE  TELEFONO";
            txtBoxTelefono.Size = new Size(320, 23);
            txtBoxTelefono.TabIndex = 17;
            // 
            // txtBoxUsuario
            // 
            txtBoxUsuario.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxUsuario.BackColor = Color.WhiteSmoke;
            txtBoxUsuario.ForeColor = SystemColors.WindowText;
            txtBoxUsuario.Location = new Point(74, 146);
            txtBoxUsuario.Name = "txtBoxUsuario";
            txtBoxUsuario.PlaceholderText = "INGRESE USUARIO";
            txtBoxUsuario.Size = new Size(320, 23);
            txtBoxUsuario.TabIndex = 18;
            // 
            // txtBoxContraseña
            // 
            txtBoxContraseña.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBoxContraseña.BackColor = Color.WhiteSmoke;
            txtBoxContraseña.ForeColor = SystemColors.WindowText;
            txtBoxContraseña.Location = new Point(74, 184);
            txtBoxContraseña.Name = "txtBoxContraseña";
            txtBoxContraseña.PlaceholderText = "INGRESE CONTRASEÑA TEMPORAL";
            txtBoxContraseña.Size = new Size(320, 23);
            txtBoxContraseña.TabIndex = 19;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.DimGray;
            btnAtras.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtras.ForeColor = SystemColors.ControlLightLight;
            btnAtras.Location = new Point(631, 410);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(82, 47);
            btnAtras.TabIndex = 20;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // checkBoxSi
            // 
            checkBoxSi.AutoSize = true;
            checkBoxSi.Location = new Point(455, 344);
            checkBoxSi.Name = "checkBoxSi";
            checkBoxSi.Size = new Size(35, 19);
            checkBoxSi.TabIndex = 21;
            checkBoxSi.Text = "Si";
            checkBoxSi.UseVisualStyleBackColor = true;
            checkBoxSi.CheckedChanged += checkBoxSi_CheckedChanged;
            // 
            // checkBoxNo
            // 
            checkBoxNo.AutoSize = true;
            checkBoxNo.Location = new Point(496, 344);
            checkBoxNo.Name = "checkBoxNo";
            checkBoxNo.Size = new Size(42, 19);
            checkBoxNo.TabIndex = 22;
            checkBoxNo.Text = "No";
            checkBoxNo.UseVisualStyleBackColor = true;
            checkBoxNo.CheckedChanged += checkBoxNo_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(74, 344);
            label3.Name = "label3";
            label3.Size = new Size(348, 14);
            label3.TabIndex = 23;
            label3.Text = "Dar permiso para que el estudiante cambie su contraseña provicional";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(273, 269);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(74, 277);
            label4.Name = "label4";
            label4.Size = new Size(176, 14);
            label4.TabIndex = 25;
            label4.Text = "Seleccione Horario de cursada";
            // 
            // RegistrarEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 468);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(checkBoxNo);
            Controls.Add(checkBoxSi);
            Controls.Add(btnAtras);
            Controls.Add(txtBoxContraseña);
            Controls.Add(txtBoxUsuario);
            Controls.Add(txtBoxTelefono);
            Controls.Add(txtBoxdireccion);
            Controls.Add(txtBoxMail);
            Controls.Add(txtBoxDni);
            Controls.Add(txtBoxNombreCompleto);
            Controls.Add(btnRegistrar);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Cursor = Cursors.Hand;
            Name = "RegistrarEstudiante";
            Text = "RegistrarEstudiante";
            Load += RegistrarEstudiante_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Button btnRegistrar;
        private TextBox txtBoxNombreCompleto;
        private TextBox txtBoxDni;
        private TextBox txtBoxMail;
        private TextBox txtBoxdireccion;
        private TextBox txtBoxTelefono;
        private TextBox txtBoxUsuario;
        private TextBox txtBoxContraseña;
        private Button btnAtras;
        private CheckBox checkBoxSi;
        private CheckBox checkBoxNo;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
    }
}