
namespace Cliente
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txbIP = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.upDownPorta = new System.Windows.Forms.NumericUpDown();
            this.txbNomeUsuario = new System.Windows.Forms.TextBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.upDownPorta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txbIP
            // 
            this.txbIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbIP.Location = new System.Drawing.Point(7, 169);
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(183, 29);
            this.txbIP.TabIndex = 0;
            this.txbIP.Text = "127.0.0.1";
            // 
            // btnConectar
            // 
            this.btnConectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConectar.Location = new System.Drawing.Point(41, 352);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(211, 34);
            this.btnConectar.TabIndex = 1;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // upDownPorta
            // 
            this.upDownPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.upDownPorta.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.upDownPorta.Location = new System.Drawing.Point(198, 169);
            this.upDownPorta.Maximum = new decimal(new int[] {
            8080,
            0,
            0,
            0});
            this.upDownPorta.Minimum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.upDownPorta.Name = "upDownPorta";
            this.upDownPorta.Size = new System.Drawing.Size(87, 29);
            this.upDownPorta.TabIndex = 2;
            this.upDownPorta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.upDownPorta.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // txbNomeUsuario
            // 
            this.txbNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNomeUsuario.Location = new System.Drawing.Point(7, 230);
            this.txbNomeUsuario.Name = "txbNomeUsuario";
            this.txbNomeUsuario.PlaceholderText = "Nome de usuario";
            this.txbNomeUsuario.Size = new System.Drawing.Size(278, 29);
            this.txbNomeUsuario.TabIndex = 3;
            this.txbNomeUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.ErrorImage")));
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.InitialImage")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(7, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(278, 151);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 4;
            this.pictureBoxLogo.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 450);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.txbNomeUsuario);
            this.Controls.Add(this.upDownPorta);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txbIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrar";
            ((System.ComponentModel.ISupportInitialize)(this.upDownPorta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.NumericUpDown upDownPorta;
        private System.Windows.Forms.TextBox txbNomeUsuario;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}

