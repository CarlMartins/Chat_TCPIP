﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cliente
{
    public partial class frmChat : Form
    {
        public frmChat()
        {
            InitializeComponent();
            txbMensagem.Focus();
            Cliente.StatusChanged += OnStatusChanged;
            lblNomeUsuario.Text += Cliente._nomeUsuario;
        }

        private void Enviar()
        {
            Cliente.EnviarMensagem(txbMensagem.Text);
            txbMensagem.Text = "";
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Enviar();
        }

        private void txbMensagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                Enviar();
                e.Handled = true;
            }

            cbEmoticons.DroppedDown = false;
        }

        public void OnStatusChanged(object sender, StatusChangedEventArgs args)
        {
            if(args.MensagemServidor[0] == '0')
            {
                MessageBox.Show($"{args.MensagemServidor.Substring(2)}\r\n");
                Close();
            } else
            {
                txbLog.AppendText($"{args.MensagemServidor}\r\n");
            }
            
        }

        private void frmChat_Shown(object sender, EventArgs e)
        {
            btnEnviar.Focus();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private Point _mouse;
        private void pnlMoverJanela_MouseDown(object sender, MouseEventArgs e)
        {
            _mouse = new Point(e.X, e.Y);
        }

        private void pnlMoverJanela_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - _mouse.X;
                Top += e.Y - _mouse.Y;
            }
        }

        private void pictureBoxEmoticons_MouseClick(object sender, MouseEventArgs e)
        {
            cbEmoticons.DroppedDown = true;
        }

        private void cbEmoticons_SelectedIndexChanged(object sender, EventArgs e)
        {
            Emoticons emoticons = new Emoticons();
            txbMensagem.AppendText($" {emoticons.getEmoticon(cbEmoticons.SelectedIndex)}");
            txbMensagem.Focus();
            cbEmoticons.DroppedDown = true;
        }
    }
}
