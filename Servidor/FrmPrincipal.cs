using Servidor;
using System;
using System.Net;
using System.Windows.Forms;

namespace ChatAPS
{
    public partial class FrmPrincipal : Form
    {
        private delegate void AtualizaStatusCallBack(string mensagem);
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCriarServidor_Click(object sender, EventArgs e)
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
                int porta = (int) upDownPort.Value;

                Server servidor = new Server(enderecoIp, porta);
                Server.StatusChanged += OnServidorStatusChanged;

                servidor.IniciarServidor();
                txbLog.AppendText("Esperando conexões...\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
    }
}
