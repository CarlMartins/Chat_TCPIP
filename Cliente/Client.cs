﻿using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace Cliente
{
    class Client
    {
        public static string s_nomeUsuario;
        private int _porta { get; }

        private string _enderecoIp { get; }
        public static TcpClient _tcpServidor;
        public static StreamWriter _escritorConexao;
        public static StreamReader _leitorConexao;

        public static EventHandler<StatusChangedEventArgs> StatusChanged;
        private Thread _threadCliente;

        public string RespostaLogin;


        public Client(string enderecoIp, int porta, string nomeUsuario)
        {
            _enderecoIp = enderecoIp;
            _porta = porta;
            s_nomeUsuario = nomeUsuario;
        }

        public void Conectar()
        {
            _tcpServidor = new TcpClient();
            try
            {
                _tcpServidor.Connect(_enderecoIp, _porta);

                _escritorConexao = new StreamWriter(_tcpServidor.GetStream());
                _leitorConexao = new StreamReader(_tcpServidor.GetStream());

                _escritorConexao.WriteLine(s_nomeUsuario);
                _escritorConexao.Flush();

                RespostaLogin = _leitorConexao.ReadLine();

                if (RespostaLogin[0] == '1')
                {
                    RespostaLogin = ("1|Conectado com sucesso");
                    _threadCliente = new Thread(EscutarMensagens);
                    _threadCliente.IsBackground = true;
                    _threadCliente.Start();
                }
            }
            catch
            {
                RespostaLogin = "0|Erro ao se conectar ao servidor\n" +
                    "O servidor pode estar offline.";
            }
        }

        private void EscutarMensagens()
        {
            try
            {
                while (true)
                {
                    string mensagem = "";
                    OnStatusChanged((mensagem = _leitorConexao.ReadLine()) != null
                        ? mensagem
                        : throw new Exception());
                }
            }
            catch (Exception)
            {
                OnStatusChanged("0|Problema com o servidor");
            }
        }

        public static void EnviarMensagem(string mensagem)
        {
            _escritorConexao.WriteLine(mensagem.Trim());
            _escritorConexao.Flush();
        }

        public void OnStatusChanged(string mensagem)
        {
            if (StatusChanged != null)
                StatusChanged(this, new StatusChangedEventArgs(mensagem));
        }
    }
}
