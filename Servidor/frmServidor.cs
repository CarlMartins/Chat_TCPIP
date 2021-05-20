using Servidor;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace ChatAPS
{
    public partial class frmServidor : Form
    {
        private delegate void AtualizaStatusCallBack(string mensagem);

        private bool _servidorRodando = false;
        private Servidor.Servidor _servidor;

        public frmServidor()
        {
            InitializeComponent();
        }

        private void btnCriarServidor_Click(object sender, EventArgs e)
        {
            if(_servidorRodando == false)
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

                    _servidor = new Servidor.Servidor(enderecoIp, porta);
                    Servidor.Servidor.StatusChanged += OnServidorStatusChanged;

                    _servidor.IniciarServidor();
                    txbLog.Text = "";
                    txbLog.AppendText("Esperando conexões...\r\n");

                    btnCriarServidor.Text = "Fechar Servidor";
                    _servidorRodando = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                CriarBackup();
                _servidorRodando = false;
                _servidor.FecharServidor();
                btnCriarServidor.Text = "Criar servidor";
                Servidor.Servidor.StatusChanged -= OnServidorStatusChanged;
            }
        }

        public void OnServidorStatusChanged(object sender, StatusChangedEventArgs args)
        {
            Invoke(new AtualizaStatusCallBack(AtualizaStatus),
                    new object[] { args.EventMessage });
        }

        private void AtualizaStatus(string mensagem)
        {
            txbLog.AppendText($"{mensagem}\r\n");
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
            if(_servidorRodando)
            {
                Servidor.Servidor.CriarBackup(txbLog.Text);
            }
        }
    }
}
