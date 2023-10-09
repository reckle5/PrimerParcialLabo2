namespace Sysacad
{
    partial class InicioDeSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioDeSesion));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBoxUsuario = new TextBox();
            textBoxPassword = new TextBox();
            btnLogIn = new Button();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(405, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 94);
            label1.Name = "label1";
            label1.Size = new Size(275, 18);
            label1.TabIndex = 1;
            label1.Text = "- Facultad Regional Avellaneda -";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(252, 220);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.PlaceholderText = "USUARIO";
            textBoxUsuario.Size = new Size(224, 23);
            textBoxUsuario.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            textBoxPassword.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxPassword.Location = new Point(252, 268);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "CONTRASEÑA";
            textBoxPassword.Size = new Size(224, 23);
            textBoxPassword.TabIndex = 6;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.DodgerBlue;
            btnLogIn.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogIn.ForeColor = SystemColors.ControlLight;
            btnLogIn.Location = new Point(399, 316);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(77, 45);
            btnLogIn.TabIndex = 7;
            btnLogIn.Text = "Ingresar";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(243, 164);
            label2.Name = "label2";
            label2.Size = new Size(233, 20);
            label2.TabIndex = 8;
            label2.Text = "INICIA SESION En Sysacad";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.Location = new Point(595, 41);
            button1.Name = "button1";
            button1.Size = new Size(152, 39);
            button1.TabIndex = 9;
            button1.Text = "ADMIN HARDCODE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkKhaki;
            button2.Location = new Point(595, 94);
            button2.Name = "button2";
            button2.Size = new Size(152, 39);
            button2.TabIndex = 10;
            button2.Text = "ESTUDIANTE HARDCODE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // InicioDeSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(778, 434);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(btnLogIn);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsuario);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "InicioDeSesion";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBoxUsuario;
        private Button btnLogIn;
        public TextBox textBoxPassword;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}