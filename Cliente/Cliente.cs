using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace Cliente
{
    class Cliente
    {
        private string _nomeUsuario;
        private int _porta;

        private string _enderecoIp;
        public static TcpClient _tcpServidor;
        public static StreamWriter _escritorConexao;
        public static StreamReader _leitorConexao;

        public static EventHandler<StatusChangedEventArgs> StatusChanged;
        private Thread _threadCliente;

        public string RespostaLogin;

        private bool _conectado = false;


        public Cliente(string enderecoIp, int porta, string nomeUsuario)
        {
            _enderecoIp = enderecoIp;
            _porta = porta;
            _nomeUsuario = nomeUsuario;
        }

        public Cliente()
        {

        }

        public void Conectar()
        {
            _tcpServidor = new TcpClient();
            try
            {
                _tcpServidor.Connect(_enderecoIp, _porta);
                _conectado = true;

                _escritorConexao = new StreamWriter(_tcpServidor.GetStream());
                _leitorConexao = new StreamReader(_tcpServidor.GetStream());

                _escritorConexao.WriteLine(_nomeUsuario);
                _escritorConexao.Flush();

                if ((RespostaLogin = _leitorConexao.ReadLine())[0] == '1')
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

        public static void EnviarMensagem(string mensagem)
        {
            _escritorConexao.WriteLine(mensagem.Trim());
            _escritorConexao.Flush();
        }

        public void EscutarMensagens()
        {
            while (true)
            {
                OnStatusChanged(_leitorConexao.ReadLine());
            }
        }

        public void OnStatusChanged(string mensagem)
        {
            if (StatusChanged != null)
                StatusChanged(this, new StatusChangedEventArgs(mensagem));
        }
    }
}
