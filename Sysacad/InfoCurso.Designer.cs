namespace Sysacad
{
    partial class InfoCurso
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
            lblNombreCurso = new Label();
            label1 = new Label();
            label2 = new Label();
            lblCodigoCurso = new Label();
            label3 = new Label();
            lblDescripcionCurso = new Label();
            label4 = new Label();
            lblCupoCurso = new Label();
            btnAtras = new Button();
            SuspendLayout();
            // 
            // lblNombreCurso
            // 
            lblNombreCurso.AutoSize = true;
            lblNombreCurso.Location = new Point(204, 52);
            lblNombreCurso.Name = "lblNombreCurso";
            lblNombreCurso.Size = new Size(38, 15);
            lblNombreCurso.TabIndex = 0;
            lblNombreCurso.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(49, 52);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre del Curso:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(74, 85);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 2;
            label2.Text = "Codigo unico:";
            // 
            // lblCodigoCurso
            // 
            lblCodigoCurso.AutoSize = true;
            lblCodigoCurso.Location = new Point(204, 85);
            lblCodigoCurso.Name = "lblCodigoCurso";
            lblCodigoCurso.Size = new Size(38, 15);
            lblCodigoCurso.TabIndex = 3;
            lblCodigoCurso.Text = "label3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(83, 121);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 4;
            label3.Text = "Descripcion:";
            // 
            // lblDescripcionCurso
            // 
            lblDescripcionCurso.AutoSize = true;
            lblDescripcionCurso.Location = new Point(202, 125);
            lblDescripcionCurso.Name = "lblDescripcionCurso";
            lblDescripcionCurso.Size = new Size(38, 15);
            lblDescripcionCurso.TabIndex = 5;
            lblDescripcionCurso.Text = "label4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(33, 159);
            label4.Name = "label4";
            label4.Size = new Size(123, 15);
            label4.TabIndex = 6;
            label4.Text = "Cupo dee estudiantes:";
            // 
            // lblCupoCurso
            // 
            lblCupoCurso.AutoSize = true;
            lblCupoCurso.Location = new Point(205, 158);
            lblCupoCurso.Name = "lblCupoCurso";
            lblCupoCurso.Size = new Size(38, 15);
            lblCupoCurso.TabIndex = 7;
            lblCupoCurso.Text = "label5";
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.DarkSlateGray;
            btnAtras.Location = new Point(454, 149);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(70, 37);
            btnAtras.TabIndex = 8;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // InfoCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 198);
            Controls.Add(btnAtras);
            Controls.Add(lblCupoCurso);
            Controls.Add(label4);
            Controls.Add(lblDescripcionCurso);
            Controls.Add(label3);
            Controls.Add(lblCodigoCurso);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblNombreCurso);
            Name = "InfoCurso";
            Text = "InfoCurso";
            Load += InfoCurso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreCurso;
        private Label label1;
        private Label label2;
        private Label lblCodigoCurso;
        private Label label3;
        private Label lblDescripcionCurso;
        private Label label4;
        private Label lblCupoCurso;
        private Button btnAtras;
    }
}