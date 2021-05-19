
namespace Cliente
{
    partial class frmChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChat));
            this.txbMensagem = new System.Windows.Forms.TextBox();
            this.txbLog = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblMinimizar = new System.Windows.Forms.Label();
            this.lblSair = new System.Windows.Forms.Label();
            this.pnlMoverJanela = new System.Windows.Forms.Panel();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.pblMensagem = new System.Windows.Forms.Panel();
            this.pblLog = new System.Windows.Forms.Panel();
            this.pnlMoverJanela.SuspendLayout();
            this.pblMensagem.SuspendLayout();
            this.pblLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbMensagem
            // 
            this.txbMensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.txbMensagem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbMensagem.Location = new System.Drawing.Point(3, 2);
            this.txbMensagem.Multiline = true;
            this.txbMensagem.Name = "txbMensagem";
            this.txbMensagem.PlaceholderText = "Digite sua mensagem...";
            this.txbMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbMensagem.Size = new System.Drawing.Size(295, 53);
            this.txbMensagem.TabIndex = 1;
            this.txbMensagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMensagem_KeyPress);
            // 
            // txbLog
            // 
            this.txbLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.txbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbLog.Cursor = System.Windows.Forms.Cursors.No;
            this.txbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbLog.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txbLog.Location = new System.Drawing.Point(7, 4);
            this.txbLog.Multiline = true;
            this.txbLog.Name = "txbLog";
            this.txbLog.ReadOnly = true;
            this.txbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbLog.Size = new System.Drawing.Size(370, 325);
            this.txbLog.TabIndex = 0;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Transparent;
            this.btnEnviar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnviar.BackgroundImage")));
            this.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnviar.Location = new System.Drawing.Point(316, 383);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(73, 55);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblMinimizar
            // 
            this.lblMinimizar.AutoSize = true;
            this.lblMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMinimizar.ForeColor = System.Drawing.Color.White;
            this.lblMinimizar.Location = new System.Drawing.Point(324, 4);
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
            this.lblSair.Location = new System.Drawing.Point(353, 4);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(24, 24);
            this.lblSair.TabIndex = 9;
            this.lblSair.Text = "X";
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // pnlMoverJanela
            // 
            this.pnlMoverJanela.Controls.Add(this.lblNomeUsuario);
            this.pnlMoverJanela.Controls.Add(this.lblMinimizar);
            this.pnlMoverJanela.Controls.Add(this.lblSair);
            this.pnlMoverJanela.Location = new System.Drawing.Point(12, 5);
            this.pnlMoverJanela.Name = "pnlMoverJanela";
            this.pnlMoverJanela.Size = new System.Drawing.Size(376, 32);
            this.pnlMoverJanela.TabIndex = 13;
            this.pnlMoverJanela.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMoverJanela_MouseDown);
            this.pnlMoverJanela.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMoverJanela_MouseMove);
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomeUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNomeUsuario.Location = new System.Drawing.Point(1, 5);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(160, 24);
            this.lblNomeUsuario.TabIndex = 11;
            this.lblNomeUsuario.Text = "Conectado como ";
            this.lblNomeUsuario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMoverJanela_MouseDown);
            this.lblNomeUsuario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMoverJanela_MouseMove);
            // 
            // pblMensagem
            // 
            this.pblMensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.pblMensagem.Controls.Add(this.txbMensagem);
            this.pblMensagem.Location = new System.Drawing.Point(13, 383);
            this.pblMensagem.Name = "pblMensagem";
            this.pblMensagem.Padding = new System.Windows.Forms.Padding(10);
            this.pblMensagem.Size = new System.Drawing.Size(298, 55);
            this.pblMensagem.TabIndex = 14;
            // 
            // pblLog
            // 
            this.pblLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(252)))), ((int)(((byte)(218)))));
            this.pblLog.Controls.Add(this.txbLog);
            this.pblLog.Location = new System.Drawing.Point(12, 37);
            this.pblLog.Name = "pblLog";
            this.pblLog.Size = new System.Drawing.Size(377, 333);
            this.pblLog.TabIndex = 15;
            // 
            // frmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(132)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.pnlMoverJanela);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.pblMensagem);
            this.Controls.Add(this.pblLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.frmChat_Shown);
            this.pnlMoverJanela.ResumeLayout(false);
            this.pnlMoverJanela.PerformLayout();
            this.pblMensagem.ResumeLayout(false);
            this.pblMensagem.PerformLayout();
            this.pblLog.ResumeLayout(false);
            this.pblLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbMensagem;
        private System.Windows.Forms.TextBox txbLog;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblMinimizar;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.Panel pnlMoverJanela;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.Panel pblMensagem;
        private System.Windows.Forms.Panel pblLog;
    }
}