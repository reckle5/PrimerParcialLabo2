namespace Sysacad
{
    partial class PagosPendientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagosPendientes));
            label2 = new Label();
            pictureBox1 = new PictureBox();
            dvgPagos = new DataGridView();
            Concepto = new DataGridViewTextBoxColumn();
            monto = new DataGridViewTextBoxColumn();
            Pago = new DataGridViewTextBoxColumn();
            label1 = new Label();
            lblPagototal = new Label();
            btnPagar = new Button();
            btnAtras = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgPagos).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 94);
            label2.Name = "label2";
            label2.Size = new Size(37, 17);
            label2.TabIndex = 6;
            label2.Text = "UTN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // dvgPagos
            // 
            dvgPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgPagos.BackgroundColor = Color.RosyBrown;
            dvgPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgPagos.Columns.AddRange(new DataGridViewColumn[] { Concepto, monto, Pago });
            dvgPagos.GridColor = SystemColors.ActiveCaption;
            dvgPagos.Location = new Point(174, 148);
            dvgPagos.Name = "dvgPagos";
            dvgPagos.RowTemplate.Height = 25;
            dvgPagos.Size = new Size(474, 123);
            dvgPagos.TabIndex = 7;
            // 
            // Concepto
            // 
            Concepto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Concepto.HeaderText = "Pagos Pendientes";
            Concepto.Name = "Concepto";
            Concepto.ReadOnly = true;
            // 
            // monto
            // 
            monto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            monto.HeaderText = "$ Monto a Pagar";
            monto.Name = "monto";
            monto.ReadOnly = true;
            // 
            // Pago
            // 
            Pago.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Pago.HeaderText = "$ Pago a realizar";
            Pago.Name = "Pago";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 376);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 8;
            label1.Text = "Pago Total: ";
            // 
            // lblPagototal
            // 
            lblPagototal.AutoSize = true;
            lblPagototal.Location = new Point(248, 376);
            lblPagototal.Name = "lblPagototal";
            lblPagototal.Size = new Size(71, 15);
            lblPagototal.TabIndex = 9;
            lblPagototal.Text = "lblPagototal";
            lblPagototal.Visible = false;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.MediumSeaGreen;
            btnPagar.Location = new Point(679, 376);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(80, 45);
            btnPagar.TabIndex = 10;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.DarkGray;
            btnAtras.Location = new Point(593, 376);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(80, 45);
            btnAtras.TabIndex = 11;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = false;
            // 
            // PagosPendientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAtras);
            Controls.Add(btnPagar);
            Controls.Add(lblPagototal);
            Controls.Add(label1);
            Controls.Add(dvgPagos);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "PagosPendientes";
            Text = "PagosPendientes";
            Load += PagosPendientes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgPagos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox1;
        private DataGridView dvgPagos;
        private DataGridViewTextBoxColumn Concepto;
        private DataGridViewTextBoxColumn monto;
        private DataGridViewTextBoxColumn Pago;
        private Label label1;
        private Label lblPagototal;
        private Button btnPagar;
        private Button btnAtras;
    }
}