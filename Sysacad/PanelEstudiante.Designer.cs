namespace Sysacad
{
    partial class PanelEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelEstudiante));
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            lblInscripcion = new LinkLabel();
            pictureBox3 = new PictureBox();
            linkLabel1 = new LinkLabel();
            pictureBox4 = new PictureBox();
            linkLabel2 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 85);
            label2.Name = "label2";
            label2.Size = new Size(37, 17);
            label2.TabIndex = 4;
            label2.Text = "UTN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(548, 23);
            label1.Name = "label1";
            label1.Size = new Size(155, 17);
            label1.TabIndex = 5;
            label1.Text = "Bienvenido al SYSACAD";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(163, 120);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // lblInscripcion
            // 
            lblInscripcion.AutoSize = true;
            lblInscripcion.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblInscripcion.LinkColor = Color.Teal;
            lblInscripcion.Location = new Point(238, 136);
            lblInscripcion.Name = "lblInscripcion";
            lblInscripcion.Size = new Size(166, 18);
            lblInscripcion.TabIndex = 7;
            lblInscripcion.TabStop = true;
            lblInscripcion.Text = "Inscripción de Cursos";
            lblInscripcion.LinkClicked += lblInscripcion_LinkClicked;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(163, 198);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 44);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Teal;
            linkLabel1.Location = new Point(238, 215);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(246, 18);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Consultar Horario de Inscripción";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(163, 274);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(46, 44);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.LinkColor = Color.Teal;
            linkLabel2.Location = new Point(238, 290);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(114, 18);
            linkLabel2.TabIndex = 11;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Realizar Pagos";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // PanelEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 450);
            Controls.Add(linkLabel2);
            Controls.Add(pictureBox4);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox3);
            Controls.Add(lblInscripcion);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "PanelEstudiante";
            Text = "PanelEstudiante";
            Load += PanelEstudiante_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private LinkLabel lblInscripcion;
        private PictureBox pictureBox3;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox4;
        private LinkLabel linkLabel2;
    }
}