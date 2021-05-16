﻿using Servidor;
using System;
using System.Net;
using System.Windows.Forms;

namespace ChatAPS
{
    public partial class FrmPrincipal : Form
    {
        private delegate void AtualizaStatusCallBack(string mensagem);

        private bool _servidorRodando = false;
        private Servidor.Servidor _servidor;

        public FrmPrincipal()
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
    }
}
