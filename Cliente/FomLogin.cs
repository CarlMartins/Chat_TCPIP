using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Cliente
{
    public partial class FomLogin : Form
    {
        public FomLogin()
        {
            InitializeComponent();
        }

        private void Conectar()
        {
            Validacao validacao = new Validacao(txbIP.Text, txbNomeUsuario.Text);
            string respostaValidacao = validacao.ValidarDadosConexao();

            if (respostaValidacao != "")
            {
                MessageBox.Show(respostaValidacao);
            }
            else
            {
                Client cliente = new Client(
                    txbIP.Text,
                    int.Parse(upDownPorta.Text),
                    txbNomeUsuario.Text);

                cliente.Conectar();
                MessageBox.Show(cliente.RespostaLogin.Substring(2));

                if (cliente.RespostaLogin[0] == '1')
                {
                    Hide();
                    FormChat chat = new FormChat();
                    chat.ShowDialog();
                    Close();
                }
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            Conectar();
        }

        private void txbNomeUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                Conectar();
                e.Handled = true;
            }
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void txbNomeUsuario_Click(object sender, EventArgs e)
        {
            if (txbNomeUsuario.Text.Trim() == "Nome de usuario")
            {
                txbNomeUsuario.Text = "";
            }
        }

        private void txbNomeUsuario_Leave(object sender, EventArgs e)
        {
            if (txbNomeUsuario.Text.Trim() == "")
            {
                txbNomeUsuario.Text = "Nome de usuario";
            }
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
    }
}
