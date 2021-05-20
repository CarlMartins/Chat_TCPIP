using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cliente
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            Validacao validacao = new Validacao(txbIP.Text, txbNomeUsuario.Text);
            string respostaValidacao = validacao.ValidarDadosConexao();

            if (respostaValidacao != "")
            {
                MessageBox.Show(respostaValidacao);
            }
            else
            {
                Cliente cliente = new Cliente(
                    txbIP.Text,
                    int.Parse(upDownPorta.Text),
                    txbNomeUsuario.Text);

                cliente.Conectar();
                MessageBox.Show(cliente.RespostaLogin.Substring(2));

                if (cliente.RespostaLogin[0] == '1')
                {
                    Hide();
                    frmChat chat = new frmChat();
                    chat.ShowDialog();
                    Close();
                }
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

        private void txbNomeUsuario_Leave(object sender, EventArgs e)
        {
            if (txbNomeUsuario.Text.Trim() == "")
            {
                txbNomeUsuario.Text = "Nome de usuario";
            }
        }

        private void txbNomeUsuario_Click(object sender, EventArgs e)
        {
            if (txbNomeUsuario.Text.Trim() == "Nome de usuario")
            {
                txbNomeUsuario.Text = "";
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

        string path = Environment.CurrentDirectory;
        private void btnConectar_MouseHover(object sender, EventArgs e)
        {
            btnConectar.BackgroundImage = Image.FromFile(path + "\\..\\..\\..\\" +
                "Properties\\Resources\\botao_conectar2.png");
        }

        private void btnConectar_MouseLeave(object sender, EventArgs e)
        {
            btnConectar.BackgroundImage = Image.FromFile(path + "\\..\\..\\..\\" +
                "Properties\\Resources\\botao_conectar1.png");
        }
    }
}
