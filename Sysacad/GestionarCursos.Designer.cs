namespace Sysacad
{
    partial class GestionarCursos
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
            comboBoxCursos = new ComboBox();
            groupBox1 = new GroupBox();
            btnCrearCurso = new Button();
            label1 = new Label();
            radioButtonInfo = new RadioButton();
            radioButtonEliminar = new RadioButton();
            radioButtonEditar = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxCursos
            // 
            comboBoxCursos.BackColor = Color.Silver;
            comboBoxCursos.FormattingEnabled = true;
            comboBoxCursos.Location = new Point(27, 82);
            comboBoxCursos.Name = "comboBoxCursos";
            comboBoxCursos.Size = new Size(170, 24);
            comboBoxCursos.TabIndex = 0;
            comboBoxCursos.SelectedIndexChanged += comboBoxCursos_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightSteelBlue;
            groupBox1.Controls.Add(btnCrearCurso);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(radioButtonInfo);
            groupBox1.Controls.Add(radioButtonEliminar);
            groupBox1.Controls.Add(radioButtonEditar);
            groupBox1.Controls.Add(comboBoxCursos);
            groupBox1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(148, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(499, 276);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cursos";
            // 
            // btnCrearCurso
            // 
            btnCrearCurso.BackColor = Color.DeepSkyBlue;
            btnCrearCurso.Location = new Point(27, 207);
            btnCrearCurso.Name = "btnCrearCurso";
            btnCrearCurso.Size = new Size(149, 49);
            btnCrearCurso.TabIndex = 6;
            btnCrearCurso.Text = "Crear nuevo Curso";
            btnCrearCurso.UseVisualStyleBackColor = false;
            btnCrearCurso.Click += btnCrearCurso_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(27, 51);
            label1.Name = "label1";
            label1.Size = new Size(135, 16);
            label1.TabIndex = 5;
            label1.Text = "Seleccione un Curso";
            // 
            // radioButtonInfo
            // 
            radioButtonInfo.AutoSize = true;
            radioButtonInfo.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            radioButtonInfo.Location = new Point(239, 51);
            radioButtonInfo.Name = "radioButtonInfo";
            radioButtonInfo.Size = new Size(151, 20);
            radioButtonInfo.TabIndex = 4;
            radioButtonInfo.TabStop = true;
            radioButtonInfo.Text = "Mostrar Info del curso";
            radioButtonInfo.UseVisualStyleBackColor = true;
            radioButtonInfo.CheckedChanged += RadioButtonInfo_CheckedChanged;
            // 
            // radioButtonEliminar
            // 
            radioButtonEliminar.AutoSize = true;
            radioButtonEliminar.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            radioButtonEliminar.Location = new Point(239, 146);
            radioButtonEliminar.Name = "radioButtonEliminar";
            radioButtonEliminar.Size = new Size(126, 20);
            radioButtonEliminar.TabIndex = 3;
            radioButtonEliminar.TabStop = true;
            radioButtonEliminar.Text = "Eliminar un curso";
            radioButtonEliminar.UseVisualStyleBackColor = true;
            radioButtonEliminar.CheckedChanged += RadioButtonEliminar_CheckedChanged;
            // 
            // radioButtonEditar
            // 
            radioButtonEditar.AutoSize = true;
            radioButtonEditar.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            radioButtonEditar.Location = new Point(239, 98);
            radioButtonEditar.Name = "radioButtonEditar";
            radioButtonEditar.Size = new Size(151, 20);
            radioButtonEditar.TabIndex = 2;
            radioButtonEditar.TabStop = true;
            radioButtonEditar.Text = "Editar curso existente";
            radioButtonEditar.UseVisualStyleBackColor = true;
            radioButtonEditar.CheckedChanged += RadioButtonEditar_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.Location = new Point(605, 392);
            button1.Name = "button1";
            button1.Size = new Size(84, 46);
            button1.TabIndex = 2;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumSeaGreen;
            button2.Location = new Point(704, 392);
            button2.Name = "button2";
            button2.Size = new Size(84, 46);
            button2.TabIndex = 3;
            button2.Text = "Confirmar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // GestionarCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "GestionarCursos";
            Text = "GestionarCursos";
            Load += GestionarCursos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxCursos;
        private GroupBox groupBox1;
        private RadioButton radioButtonEliminar;
        private RadioButton radioButtonEditar;
        private Button button1;
        private Label label1;
        private RadioButton radioButtonInfo;
        private Button button2;
        private Button btnCrearCurso;
    }
}