namespace Sysacad
{
    partial class ConsultarHorario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarHorario));
            label2 = new Label();
            pictureBox1 = new PictureBox();
            listView1 = new ListView();
            label1 = new Label();
            btnAtras = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(36, 99);
            label2.Name = "label2";
            label2.Size = new Size(37, 17);
            label2.TabIndex = 6;
            label2.Text = "UTN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            listView1.Location = new Point(166, 124);
            listView1.Name = "listView1";
            listView1.Size = new Size(475, 244);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.SmallIcon;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(166, 76);
            label1.Name = "label1";
            label1.Size = new Size(174, 20);
            label1.TabIndex = 8;
            label1.Text = "Horarios de Cursada";
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.DarkGray;
            btnAtras.Location = new Point(692, 398);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(77, 40);
            btnAtras.TabIndex = 9;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // ConsultarHorario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAtras);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "ConsultarHorario";
            Text = "ConsultarHorario";
            Load += ConsultarHorario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox1;
        private ListView listView1;
        private Label label1;
        private Button btnAtras;
    }
}