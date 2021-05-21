using Servidor;
using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace ChatAPS
{
    public partial class FormServidor : Form
    {
        private delegate void AtualizaStatusCallBack(string mensagem);

        private bool _servidorRodando = false;
        private Server _servidor;

        public FormServidor()
        {
            InitializeComponent();
        }

        private void btnCriarServidor_Click(object sender, EventArgs e)
        {
            if (_servidorRodando == false)
            {
                if (txbIp.Text == "")
                {
                    MessageBox.Show("Informe o endereço de IP");
                    txbIp.Focus();
                    return;
                }
                try
                {
                    IPAddress enderecoIp = IPAddress.Parse(txbIp.Text);
                    int porta = (int)upDownPort.Value;

                    _servidor = new Servidor.Server(enderecoIp, porta);
                    Server.StatusChanged += OnServidorStatusChanged;
                    _servidor.IniciarServidor();

                    txbLog.Text = "";
                    txbLog.AppendText("Esperando conexões...\r\n");

                    btnCriarServidor.Text = "Fechar Servidor";
                    _servidorRodando = true;
                    txbMensagem.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                Server.StatusChanged -= OnServidorStatusChanged;
                LogFecharServidor();
                CriarBackup();
                _servidor.FecharServidor();
                _servidorRodando = false;
                txbMensagem.Enabled = false;
                btnCriarServidor.Text = "Criar servidor";
            }
        }

        private void EnviarMensagem()
        {
            string mensagem = txbMensagem.Text.Trim();
            if (mensagem.Trim() != "")
            {
                Server.EnviarMensagemAdmin(mensagem);
                txbMensagem.Focus();
            }
            txbMensagem.Text = "";
        }

        private void btnEnviarMensagem_MouseClick(object sender, MouseEventArgs e)
        {
            EnviarMensagem();
        }

        private void txbMensagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                EnviarMensagem();
                e.Handled = true;
            }
        }

        private void OnServidorStatusChanged(object sender, StatusChangedEventArgs args)
        {
            Invoke(new AtualizaStatusCallBack(AtualizaStatus),
                    new object[] { args.EventMessage });
        }

        private void AtualizaStatus(string mensagem)
        {
            txbLog.AppendText($"{mensagem}\r\n");
        }

        private void LogFecharServidor()
        {
            txbLog.AppendText($"==========================================\r\n" +
                $"Usuarios desconectados:\r\n");

            foreach (string nomeUsuario in Server.Usuarios.Keys)
            {
                txbLog.AppendText($"->    {nomeUsuario}\r\n");
            }
            txbLog.AppendText($"==========================================\r\n");
            txbLog.AppendText($"Horário desconexão: " +
                $"{DateTime.Now:dd/MM/yyyy - HH:mm}\r\n");
            txbLog.AppendText($"==========================================");
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            CriarBackup();
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

        private void CriarBackup()
        {
            if (_servidorRodando)
            {
                Server.CriarBackup(txbLog.Text);
            }
        }
    }
}
