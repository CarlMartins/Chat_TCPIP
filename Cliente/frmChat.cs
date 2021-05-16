using System;
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
        }

        public void OnStatusChanged(object sender, StatusChangedEventArgs args)
        {
            txbLog.AppendText($"{args.MensagemServidor}\r\n");
        }

        private void frmChat_Shown(object sender, EventArgs e)
        {
            txbMensagem.Focus();
        }
    }
}
