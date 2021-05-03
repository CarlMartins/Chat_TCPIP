
namespace ChatAPS
{
    partial class FrmPrincipal
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
            this.txbIp = new System.Windows.Forms.TextBox();
            this.btnCriarServidor = new System.Windows.Forms.Button();
            this.txbLog = new System.Windows.Forms.TextBox();
            this.upDownPort = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.upDownPort)).BeginInit();
            this.SuspendLayout();
            // 
            // txbIp
            // 
            this.txbIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbIp.Location = new System.Drawing.Point(12, 12);
            this.txbIp.Name = "txbIp";
            this.txbIp.PlaceholderText = "127.0.0.1";
            this.txbIp.Size = new System.Drawing.Size(302, 29);
            this.txbIp.TabIndex = 0;
            this.txbIp.Text = "127.0.0.1";
            // 
            // btnCriarServidor
            // 
            this.btnCriarServidor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCriarServidor.Location = new System.Drawing.Point(463, 12);
            this.btnCriarServidor.Name = "btnCriarServidor";
            this.btnCriarServidor.Size = new System.Drawing.Size(157, 30);
            this.btnCriarServidor.TabIndex = 1;
            this.btnCriarServidor.Text = "Criar servidor";
            this.btnCriarServidor.UseVisualStyleBackColor = true;
            this.btnCriarServidor.Click += new System.EventHandler(this.btnCriarServidor_Click);
            // 
            // txbLog
            // 
            this.txbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbLog.Location = new System.Drawing.Point(12, 60);
            this.txbLog.Multiline = true;
            this.txbLog.Name = "txbLog";
            this.txbLog.ReadOnly = true;
            this.txbLog.Size = new System.Drawing.Size(608, 391);
            this.txbLog.TabIndex = 2;
            // 
            // upDownPort
            // 
            this.upDownPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.upDownPort.Location = new System.Drawing.Point(320, 12);
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
            this.upDownPort.Size = new System.Drawing.Size(137, 29);
            this.upDownPort.TabIndex = 3;
            this.upDownPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.upDownPort.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 463);
            this.Controls.Add(this.upDownPort);
            this.Controls.Add(this.txbLog);
            this.Controls.Add(this.btnCriarServidor);
            this.Controls.Add(this.txbIp);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.upDownPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbIp;
        private System.Windows.Forms.Button btnCriarServidor;
        private System.Windows.Forms.TextBox txbLog;
        private System.Windows.Forms.NumericUpDown upDownPort;
    }
}

