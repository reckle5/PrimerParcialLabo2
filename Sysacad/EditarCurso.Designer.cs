namespace Sysacad
{
    partial class EditarCurso
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtBoxNombre = new TextBox();
            txtBoxCodigo = new TextBox();
            txtBoxDescripcion = new TextBox();
            txtBoxCupo = new TextBox();
            button1 = new Button();
            btnAtras = new Button();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.LightSteelBlue;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.95139F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.0486145F));
            tableLayoutPanel1.Location = new Point(112, 105);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.64935F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.35065F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.Size = new Size(576, 146);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSteelBlue;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(142, 151);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo unico";
            label1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSteelBlue;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(142, 114);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre Curso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSteelBlue;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(151, 189);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 2;
            label3.Text = "Descripcion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightSteelBlue;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(161, 226);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Cupo";
            // 
            // txtBoxNombre
            // 
            txtBoxNombre.Location = new Point(307, 114);
            txtBoxNombre.Name = "txtBoxNombre";
            txtBoxNombre.Size = new Size(358, 23);
            txtBoxNombre.TabIndex = 0;
            // 
            // txtBoxCodigo
            // 
            txtBoxCodigo.Location = new Point(307, 148);
            txtBoxCodigo.Name = "txtBoxCodigo";
            txtBoxCodigo.Size = new Size(358, 23);
            txtBoxCodigo.TabIndex = 4;
            // 
            // txtBoxDescripcion
            // 
            txtBoxDescripcion.Location = new Point(307, 181);
            txtBoxDescripcion.Name = "txtBoxDescripcion";
            txtBoxDescripcion.Size = new Size(358, 23);
            txtBoxDescripcion.TabIndex = 5;
            // 
            // txtBoxCupo
            // 
            txtBoxCupo.Location = new Point(307, 218);
            txtBoxCupo.Name = "txtBoxCupo";
            txtBoxCupo.Size = new Size(358, 23);
            txtBoxCupo.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(595, 280);
            button1.Name = "button1";
            button1.Size = new Size(93, 43);
            button1.TabIndex = 7;
            button1.Text = "Confirmar Cambios";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.DarkSlateGray;
            btnAtras.Location = new Point(496, 280);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(93, 43);
            btnAtras.TabIndex = 9;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // EditarCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 347);
            Controls.Add(btnAtras);
            Controls.Add(button1);
            Controls.Add(txtBoxNombre);
            Controls.Add(txtBoxCupo);
            Controls.Add(txtBoxDescripcion);
            Controls.Add(txtBoxCodigo);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Name = "EditarCurso";
            Text = "EditarCurso";
            Load += EditarCurso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBoxNombre;
        private TextBox txtBoxCodigo;
        private TextBox txtBoxDescripcion;
        private TextBox txtBoxCupo;
        private Button button1;
        private Button btnAtras;
    }
}