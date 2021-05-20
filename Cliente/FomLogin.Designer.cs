
namespace Cliente
{
    partial class FomLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FomLogin));
            this.txbIP = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.upDownPorta = new System.Windows.Forms.NumericUpDown();
            this.txbNomeUsuario = new System.Windows.Forms.TextBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBoxIP = new System.Windows.Forms.PictureBox();
            this.lblSair = new System.Windows.Forms.Label();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.lblBarra = new System.Windows.Forms.Label();
            this.pnlMoverJanela = new System.Windows.Forms.Panel();
            this.lblMinimizar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.upDownPorta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.pnlMoverJanela.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbIP
            // 
            this.txbIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(132)))), ((int)(((byte)(105)))));
            this.txbIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbIP.ForeColor = System.Drawing.Color.White;
            this.txbIP.Location = new System.Drawing.Point(48, 266);
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(153, 22);
            this.txbIP.TabIndex = 0;
            this.txbIP.Text = "127.0.0.1";
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.Transparent;
            this.btnConectar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConectar.BackgroundImage")));
            this.btnConectar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConectar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(132)))), ((int)(((byte)(105)))));
            this.btnConectar.FlatAppearance.BorderSize = 0;
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConectar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(132)))), ((int)(((byte)(105)))));
            this.btnConectar.Location = new System.Drawing.Point(46, 371);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(211, 34);
            this.btnConectar.TabIndex = 1;
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // upDownPorta
            // 
            this.upDownPorta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(132)))), ((int)(((byte)(105)))));
            this.upDownPorta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.upDownPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.upDownPorta.ForeColor = System.Drawing.Color.White;
            this.upDownPorta.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.upDownPorta.Location = new System.Drawing.Point(227, 267);
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
            this.upDownPorta.Size = new System.Drawing.Size(54, 25);
            this.upDownPorta.TabIndex = 2;
            this.upDownPorta.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // txbNomeUsuario
            // 
            this.txbNomeUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(132)))), ((int)(((byte)(105)))));
            this.txbNomeUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNomeUsuario.ForeColor = System.Drawing.Color.White;
            this.txbNomeUsuario.Location = new System.Drawing.Point(7, 317);
            this.txbNomeUsuario.MaxLength = 15;
            this.txbNomeUsuario.Name = "txbNomeUsuario";
            this.txbNomeUsuario.Size = new System.Drawing.Size(274, 22);
            this.txbNomeUsuario.TabIndex = 3;
            this.txbNomeUsuario.Text = "Nome de usuario";
            this.txbNomeUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbNomeUsuario.Click += new System.EventHandler(this.txbNomeUsuario_Click);
            this.txbNomeUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNomeUsuario_KeyPress);
            this.txbNomeUsuario.Leave += new System.EventHandler(this.txbNomeUsuario_Leave);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.ErrorImage")));
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.InitialImage")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 36);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(278, 224);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 4;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 343);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 2);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(224, 294);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(57, 2);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(48, 294);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 2);
            this.panel3.TabIndex = 6;
            // 
            // pictureBoxIP
            // 
            this.pictureBoxIP.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxIP.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIP.Image")));
            this.pictureBoxIP.Location = new System.Drawing.Point(12, 266);
            this.pictureBoxIP.Name = "pictureBoxIP";
            this.pictureBoxIP.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxIP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIP.TabIndex = 7;
            this.pictureBoxIP.TabStop = false;
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSair.ForeColor = System.Drawing.Color.White;
            this.lblSair.Location = new System.Drawing.Point(260, 4);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(24, 24);
            this.lblSair.TabIndex = 9;
            this.lblSair.Text = "X";
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUser.Image")));
            this.pictureBoxUser.Location = new System.Drawing.Point(12, 312);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUser.TabIndex = 10;
            this.pictureBoxUser.TabStop = false;
            // 
            // lblBarra
            // 
            this.lblBarra.AutoSize = true;
            this.lblBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBarra.ForeColor = System.Drawing.Color.White;
            this.lblBarra.Location = new System.Drawing.Point(206, 268);
            this.lblBarra.Name = "lblBarra";
            this.lblBarra.Size = new System.Drawing.Size(15, 24);
            this.lblBarra.TabIndex = 11;
            this.lblBarra.Text = ":";
            // 
            // pnlMoverJanela
            // 
            this.pnlMoverJanela.Controls.Add(this.lblMinimizar);
            this.pnlMoverJanela.Controls.Add(this.lblSair);
            this.pnlMoverJanela.Location = new System.Drawing.Point(3, 1);
            this.pnlMoverJanela.Name = "pnlMoverJanela";
            this.pnlMoverJanela.Size = new System.Drawing.Size(288, 32);
            this.pnlMoverJanela.TabIndex = 12;
            this.pnlMoverJanela.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMoverJanela_MouseDown);
            this.pnlMoverJanela.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMoverJanela_MouseMove);
            // 
            // lblMinimizar
            // 
            this.lblMinimizar.AutoSize = true;
            this.lblMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMinimizar.ForeColor = System.Drawing.Color.White;
            this.lblMinimizar.Location = new System.Drawing.Point(231, 4);
            this.lblMinimizar.Name = "lblMinimizar";
            this.lblMinimizar.Size = new System.Drawing.Size(23, 24);
            this.lblMinimizar.TabIndex = 10;
            this.lblMinimizar.Text = "─";
            this.lblMinimizar.Click += new System.EventHandler(this.lblMinimizar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(132)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(293, 450);
            this.Controls.Add(this.pnlMoverJanela);
            this.Controls.Add(this.lblBarra);
            this.Controls.Add(this.pictureBoxUser);
            this.Controls.Add(this.pictureBoxIP);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.txbNomeUsuario);
            this.Controls.Add(this.upDownPorta);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txbIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrar";
            ((System.ComponentModel.ISupportInitialize)(this.upDownPorta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.pnlMoverJanela.ResumeLayout(false);
            this.pnlMoverJanela.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.NumericUpDown upDownPorta;
        private System.Windows.Forms.TextBox txbNomeUsuario;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBoxIP;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Label lblBarra;
        private System.Windows.Forms.Panel pnlMoverJanela;
        private System.Windows.Forms.Label lblMinimizar;
    }
}

