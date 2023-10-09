namespace Sysacad
{
    partial class CambiarContraseña
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
            txtRepetirPassword = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtRepetirPassword
            // 
            txtRepetirPassword.Location = new Point(67, 165);
            txtRepetirPassword.Name = "txtRepetirPassword";
            txtRepetirPassword.PlaceholderText = "Reescribe la contraseña nueva";
            txtRepetirPassword.Size = new Size(235, 23);
            txtRepetirPassword.TabIndex = 0;
            txtRepetirPassword.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(67, 118);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Contraseña nueva (6-60 caracteres)";
            txtPassword.Size = new Size(235, 23);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(67, 38);
            label1.Name = "label1";
            label1.Size = new Size(212, 24);
            label1.TabIndex = 2;
            label1.Text = "Cambia tu contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(67, 76);
            label2.Name = "label2";
            label2.Size = new Size(343, 15);
            label2.TabIndex = 3;
            label2.Text = "Protege tu cuenta con una contraseña de al menos 6 caracteres.";
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderColor = Color.DodgerBlue;
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(219, 213);
            button1.Name = "button1";
            button1.Size = new Size(83, 39);
            button1.TabIndex = 4;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CambiarContraseña
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 284);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtRepetirPassword);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "CambiarContraseña";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CambiarContraseña";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRepetirPassword;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}