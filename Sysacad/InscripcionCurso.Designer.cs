namespace Sysacad
{
    partial class InscripcionCurso
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
            ListViewGroup listViewGroup1 = new ListViewGroup("Materias ", HorizontalAlignment.Left);
            ListViewGroup listViewGroup2 = new ListViewGroup("Detalles", HorizontalAlignment.Left);
            listView1 = new ListView();
            btnIncribirse = new Button();
            lblCursoSeleccionado = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = Color.Honeydew;
            listViewGroup1.Header = "Materias ";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "Detalles";
            listViewGroup2.Name = "listViewGroup2";
            listView1.Groups.AddRange(new ListViewGroup[] { listViewGroup1, listViewGroup2 });
            listView1.Location = new Point(65, 54);
            listView1.Name = "listView1";
            listView1.Size = new Size(493, 320);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.SmallIcon;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // btnIncribirse
            // 
            btnIncribirse.BackColor = Color.MediumSeaGreen;
            btnIncribirse.Location = new Point(583, 100);
            btnIncribirse.Name = "btnIncribirse";
            btnIncribirse.Size = new Size(93, 39);
            btnIncribirse.TabIndex = 1;
            btnIncribirse.Text = "Inscribirme";
            btnIncribirse.UseVisualStyleBackColor = false;
            btnIncribirse.Click += btnIncribirse_Click;
            // 
            // lblCursoSeleccionado
            // 
            lblCursoSeleccionado.AutoSize = true;
            lblCursoSeleccionado.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCursoSeleccionado.ForeColor = SystemColors.ControlLight;
            lblCursoSeleccionado.Location = new Point(584, 65);
            lblCursoSeleccionado.Name = "lblCursoSeleccionado";
            lblCursoSeleccionado.Size = new Size(155, 20);
            lblCursoSeleccionado.TabIndex = 2;
            lblCursoSeleccionado.Text = "lblCursoSeleccionado";
            lblCursoSeleccionado.Visible = false;
            // 
            // InscripcionCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(778, 445);
            Controls.Add(lblCursoSeleccionado);
            Controls.Add(btnIncribirse);
            Controls.Add(listView1);
            Name = "InscripcionCurso";
            Text = "InscripcionCurso";
            Load += InscripcionCurso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Button btnIncribirse;
        private Label lblCursoSeleccionado;
    }
}