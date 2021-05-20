using System;
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

        private delegate void AtualizaLog(string mensagem);
        public void OnStatusChanged(object sender, StatusChangedEventArgs args)
        {
            Invoke(new AtualizaLog(AtualizaLogMensagem),
                new object[] { args.MensagemServidor });
        }

        public void AtualizaLogMensagem(string mensagem)
        {
            if (mensagem[0] == '0')
            {
                MessageBox.Show($"{mensagem.Substring(2)}\r\n");
                Application.Exit();
            }
            else
            {
                txbLog.AppendText($"{mensagem}\r\n");
            }
        }

        private void frmChat_Shown(object sender, EventArgs e)
        {
            btnEnviar.Focus();

            cbEmoticons.Items.Clear();
            var emotes = new Emoticons();

            foreach (var emote in emotes.Emotes)
            {
                cbEmoticons.Items.Add(emote.ToString());
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
            txbMensagem.AppendText($" {cbEmoticons.SelectedItem} ");
            txbMensagem.Focus();
            cbEmoticons.DroppedDown = true;
        }
    }
}
