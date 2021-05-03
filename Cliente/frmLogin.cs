using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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

            if(respostaValidacao != "")
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
    }
}
