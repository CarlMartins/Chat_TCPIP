
namespace ChatAPS
{
    partial class FormServidor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServidor));
            this.txbIp = new System.Windows.Forms.TextBox();
            this.btnCriarServidor = new System.Windows.Forms.Button();
            this.txbLog = new System.Windows.Forms.TextBox();
            this.upDownPort = new System.Windows.Forms.NumericUpDown();
            this.pnlMoverJanela = new System.Windows.Forms.Panel();
            this.lblServidor = new System.Windows.Forms.Label();
            this.lblMinimizar = new System.Windows.Forms.Label();
            this.lblSair = new System.Windows.Forms.Label();
            this.pictureBoxIP = new System.Windows.Forms.PictureBox();
            this.lblPontos = new System.Windows.Forms.Label();
            this.pnlLog = new System.Windows.Forms.Panel();
            this.txbMensagem = new System.Windows.Forms.TextBox();
            this.btnEnviarMensagem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.upDownPort)).BeginInit();
            this.pnlMoverJanela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIP)).BeginInit();
            this.pnlLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbIp
            // 
            this.txbIp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.txbIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbIp.Location = new System.Drawing.Point(53, 41);
            this.txbIp.Name = "txbIp";
            this.txbIp.PlaceholderText = "127.0.0.1";
            this.txbIp.Size = new System.Drawing.Size(248, 29);
            this.txbIp.TabIndex = 0;
            this.txbIp.Text = "127.0.0.1";
            // 
            // btnCriarServidor
            // 
            this.btnCriarServidor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCriarServidor.Location = new System.Drawing.Point(463, 41);
            this.btnCriarServidor.Name = "btnCriarServidor";
            this.btnCriarServidor.Size = new System.Drawing.Size(157, 30);
            this.btnCriarServidor.TabIndex = 1;
            this.btnCriarServidor.Text = "Criar servidor";
            this.btnCriarServidor.UseVisualStyleBackColor = true;
            this.btnCriarServidor.Click += new System.EventHandler(this.btnCriarServidor_Click);
            // 
            // txbLog
            // 
            this.txbLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.txbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbLog.Location = new System.Drawing.Point(5, 5);
            this.txbLog.Multiline = true;
            this.txbLog.Name = "txbLog";
            this.txbLog.ReadOnly = true;
            this.txbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbLog.Size = new System.Drawing.Size(601, 398);
            this.txbLog.TabIndex = 2;
            // 
            // upDownPort
            // 
            this.upDownPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.upDownPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.upDownPort.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.upDownPort.Location = new System.Drawing.Point(340, 41);
            this.upDownPort.Maximum = new decimal(new int[] {
            8080,
            0,
            0,
            0});
            this.upDownPort.Minimum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.upDownPort.Name = "upDownPort";
            this.upDownPort.Size = new System.Drawing.Size(63, 29);
            this.upDownPort.TabIndex = 3;
            this.upDownPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.upDownPort.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // pnlMoverJanela
            // 
            this.pnlMoverJanela.Controls.Add(this.lblServidor);
            this.pnlMoverJanela.Controls.Add(this.lblMinimizar);
            this.pnlMoverJanela.Controls.Add(this.lblSair);
            this.pnlMoverJanela.Location = new System.Drawing.Point(12, 2);
            this.pnlMoverJanela.Name = "pnlMoverJanela";
            this.pnlMoverJanela.Size = new System.Drawing.Size(608, 32);
            this.pnlMoverJanela.TabIndex = 13;
            this.pnlMoverJanela.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMoverJanela_MouseDown);
            this.pnlMoverJanela.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMoverJanela_MouseMove);
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServidor.ForeColor = System.Drawing.Color.White;
            this.lblServidor.Location = new System.Drawing.Point(1, 4);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(80, 24);
            this.lblServidor.TabIndex = 11;
            this.lblServidor.Text = "Servidor";
            this.lblServidor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMoverJanela_MouseDown);
            this.lblServidor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMoverJanela_MouseMove);
            // 
            // lblMinimizar
            // 
            this.lblMinimizar.AutoSize = true;
            this.lblMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMinimizar.ForeColor = System.Drawing.Color.White;
            this.lblMinimizar.Location = new System.Drawing.Point(559, 3);
            this.lblMinimizar.Name = "lblMinimizar";
            this.lblMinimizar.Size = new System.Drawing.Size(23, 24);
            this.lblMinimizar.TabIndex = 10;
            this.lblMinimizar.Text = "─";
            this.lblMinimizar.Click += new System.EventHandler(this.lblMinimizar_Click);
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSair.ForeColor = System.Drawing.Color.White;
            this.lblSair.Location = new System.Drawing.Point(588, 3);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(24, 24);
            this.lblSair.TabIndex = 9;
            this.lblSair.Text = "X";
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // pictureBoxIP
            // 
            this.pictureBoxIP.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxIP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxIP.BackgroundImage")));
            this.pictureBoxIP.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIP.Image")));
            this.pictureBoxIP.Location = new System.Drawing.Point(13, 39);
            this.pictureBoxIP.Name = "pictureBoxIP";
            this.pictureBoxIP.Size = new System.Drawing.Size(34, 30);
            this.pictureBoxIP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIP.TabIndex = 14;
            this.pictureBoxIP.TabStop = false;
            // 
            // lblPontos
            // 
            this.lblPontos.AutoSize = true;
            this.lblPontos.BackColor = System.Drawing.Color.Transparent;
            this.lblPontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPontos.ForeColor = System.Drawing.Color.White;
            this.lblPontos.Location = new System.Drawing.Point(313, 43);
            this.lblPontos.Name = "lblPontos";
            this.lblPontos.Size = new System.Drawing.Size(15, 24);
            this.lblPontos.TabIndex = 15;
            this.lblPontos.Text = ":";
            // 
            // pnlLog
            // 
            this.pnlLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.pnlLog.Controls.Add(this.txbLog);
            this.pnlLog.Location = new System.Drawing.Point(12, 77);
            this.pnlLog.Name = "pnlLog";
            this.pnlLog.Size = new System.Drawing.Size(608, 391);
            this.pnlLog.TabIndex = 16;
            // 
            // txbMensagem
            // 
            this.txbMensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.txbMensagem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMensagem.Enabled = false;
            this.txbMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbMensagem.Location = new System.Drawing.Point(12, 475);
            this.txbMensagem.Multiline = true;
            this.txbMensagem.Name = "txbMensagem";
            this.txbMensagem.PlaceholderText = "Digite sua mensagem...";
            this.txbMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbMensagem.Size = new System.Drawing.Size(529, 53);
            this.txbMensagem.TabIndex = 17;
            this.txbMensagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMensagem_KeyPress);
            // 
            // btnEnviarMensagem
            // 
            this.btnEnviarMensagem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnviarMensagem.BackgroundImage")));
            this.btnEnviarMensagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEnviarMensagem.FlatAppearance.BorderSize = 0;
            this.btnEnviarMensagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnviarMensagem.ForeColor = System.Drawing.Color.Transparent;
            this.btnEnviarMensagem.Location = new System.Drawing.Point(547, 475);
            this.btnEnviarMensagem.Name = "btnEnviarMensagem";
            this.btnEnviarMensagem.Size = new System.Drawing.Size(77, 54);
            this.btnEnviarMensagem.TabIndex = 18;
            this.btnEnviarMensagem.UseVisualStyleBackColor = true;
            this.btnEnviarMensagem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnEnviarMensagem_MouseClick);
            // 
            // frmServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(132)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(632, 540);
            this.Controls.Add(this.btnEnviarMensagem);
            this.Controls.Add(this.txbMensagem);
            this.Controls.Add(this.pnlLog);
            this.Controls.Add(this.lblPontos);
            this.Controls.Add(this.pictureBoxIP);
            this.Controls.Add(this.pnlMoverJanela);
            this.Controls.Add(this.upDownPort);
            this.Controls.Add(this.btnCriarServidor);
            this.Controls.Add(this.txbIp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MaximizeBox = false;
            this.Name = "frmServidor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.upDownPort)).EndInit();
            this.pnlMoverJanela.ResumeLayout(false);
            this.pnlMoverJanela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIP)).EndInit();
            this.pnlLog.ResumeLayout(false);
            this.pnlLog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbIp;
        private System.Windows.Forms.Button btnCriarServidor;
        private System.Windows.Forms.TextBox txbLog;
        private System.Windows.Forms.NumericUpDown upDownPort;
        private System.Windows.Forms.Panel pnlMoverJanela;
        private System.Windows.Forms.Label lblMinimizar;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.PictureBox pictureBoxIP;
        private System.Windows.Forms.Label lblPontos;
        private System.Windows.Forms.Panel pnlLog;
        private System.Windows.Forms.TextBox txbMensagem;
        private System.Windows.Forms.Button btnEnviarMensagem;
    }
}

