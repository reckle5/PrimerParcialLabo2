namespace Sysacad
{
    partial class PanelAdministracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelAdministracion));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblResgistrarEstudiante = new LinkLabel();
            lblCursos = new LinkLabel();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(654, 12);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido al SYSACAD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 85);
            label2.Name = "label2";
            label2.Size = new Size(37, 17);
            label2.TabIndex = 2;
            label2.Text = "UTN";
            // 
            // label3
            // 
            label3.AllowDrop = true;
            label3.BackColor = Color.LightSteelBlue;
            label3.Location = new Point(289, 70);
            label3.Name = "label3";
            label3.Size = new Size(186, 32);
            label3.TabIndex = 3;
            label3.Text = "PANEL DE ADMINISTRACION";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResgistrarEstudiante
            // 
            lblResgistrarEstudiante.AutoSize = true;
            lblResgistrarEstudiante.LinkColor = Color.Teal;
            lblResgistrarEstudiante.Location = new Point(319, 125);
            lblResgistrarEstudiante.Name = "lblResgistrarEstudiante";
            lblResgistrarEstudiante.Size = new Size(111, 15);
            lblResgistrarEstudiante.TabIndex = 4;
            lblResgistrarEstudiante.TabStop = true;
            lblResgistrarEstudiante.Text = "Registrar Estudiante";
            lblResgistrarEstudiante.LinkClicked += lblResgistrarEstudiante_LinkClicked;
            // 
            // lblCursos
            // 
            lblCursos.AutoSize = true;
            lblCursos.Location = new Point(319, 161);
            lblCursos.Name = "lblCursos";
            lblCursos.Size = new Size(96, 15);
            lblCursos.TabIndex = 5;
            lblCursos.TabStop = true;
            lblCursos.Text = "Gestionar Cursos";
            lblCursos.LinkClicked += lblCursos_LinkClicked;
            // 
            // PanelAdministracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCursos);
            Controls.Add(lblResgistrarEstudiante);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "PanelAdministracion";
            Text = "PanelAdministracion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel lblResgistrarEstudiante;
        private LinkLabel lblCursos;
    }
}