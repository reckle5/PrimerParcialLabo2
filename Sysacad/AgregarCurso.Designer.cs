namespace Sysacad
{
    partial class AgregarCurso
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
            button1 = new Button();
            button2 = new Button();
            txtBoxNombre = new TextBox();
            txtBoxCupo = new TextBox();
            txtBoxDescripcion = new TextBox();
            txtBoxCodigo = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.Location = new Point(675, 377);
            button1.Name = "button1";
            button1.Size = new Size(102, 49);
            button1.TabIndex = 16;
            button1.Text = "Crear Curso";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateGray;
            button2.Location = new Point(563, 377);
            button2.Name = "button2";
            button2.Size = new Size(102, 49);
            button2.TabIndex = 17;
            button2.Text = "Atras";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtBoxNombre
            // 
            txtBoxNombre.Location = new Point(307, 161);
            txtBoxNombre.Name = "txtBoxNombre";
            txtBoxNombre.Size = new Size(358, 23);
            txtBoxNombre.TabIndex = 18;
            // 
            // txtBoxCupo
            // 
            txtBoxCupo.Location = new Point(307, 265);
            txtBoxCupo.Name = "txtBoxCupo";
            txtBoxCupo.Size = new Size(358, 23);
            txtBoxCupo.TabIndex = 26;
            // 
            // txtBoxDescripcion
            // 
            txtBoxDescripcion.Location = new Point(307, 228);
            txtBoxDescripcion.Name = "txtBoxDescripcion";
            txtBoxDescripcion.Size = new Size(358, 23);
            txtBoxDescripcion.TabIndex = 25;
            // 
            // txtBoxCodigo
            // 
            txtBoxCodigo.Location = new Point(307, 195);
            txtBoxCodigo.Name = "txtBoxCodigo";
            txtBoxCodigo.PlaceholderText = "Codgio generado automaticamente";
            txtBoxCodigo.ReadOnly = true;
            txtBoxCodigo.Size = new Size(358, 23);
            txtBoxCodigo.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSteelBlue;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(142, 161);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 21;
            label2.Text = "Nombre Curso";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightSteelBlue;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(161, 273);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 23;
            label4.Text = "Cupo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSteelBlue;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(151, 236);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 22;
            label3.Text = "Descripcion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSteelBlue;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(142, 198);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 19;
            label1.Text = "Codigo unico";
            label1.UseWaitCursor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.LightSteelBlue;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.95139F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.0486145F));
            tableLayoutPanel1.Location = new Point(112, 152);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.64935F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.35065F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.Size = new Size(576, 146);
            tableLayoutPanel1.TabIndex = 20;
            tableLayoutPanel1.UseWaitCursor = true;
            // 
            // AgregarCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBoxNombre);
            Controls.Add(txtBoxCupo);
            Controls.Add(txtBoxDescripcion);
            Controls.Add(txtBoxCodigo);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "AgregarCurso";
            Text = "AgregarCurso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private TextBox txtBoxNombre;
        private TextBox txtBoxCupo;
        private TextBox txtBoxDescripcion;
        private TextBox txtBoxCodigo;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}