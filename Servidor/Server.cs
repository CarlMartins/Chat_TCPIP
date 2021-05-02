using Servidor.Entidades;
using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Servidor
{
    
    class Server
    {
        public IPAddress EnderecoIp;
        public int Porta;

        public static Hashtable Usuarios = new Hashtable(10);
        public static Hashtable Conexoes = new Hashtable(10);

        public Mensagem Mensagem = new Mensagem();
        public TcpClient TcpServer = new TcpClient();

        public static EventHandler<StatusChangedEventArgs> StatusChanged;

        public Thread ThreadListener;

        bool ServidorRodando = false;

        public Server(IPAddress enderecoIp, int porta)
        {
            EnderecoIp = enderecoIp;
            Porta = porta;
        }

        public static void OnStatusChanged(string eventMessage)
        {
            if (StatusChanged != null)
            {
                StatusChanged(null, new StatusChangedEventArgs() { EventMessage = eventMessage });
            }
        }

        public static void ValidarMensagem(string usuario, string mensagem)
        {
            string tempMensagem = mensagem.Trim();
            if (tempMensagem != "")
            {
                EnviarMensagem(usuario, tempMensagem);
            }
        }

        private static void EnviarMensagem(string usuario, string mensagem)
        {
            StreamWriter mensagemUsuario;

            OnStatusChanged($"{usuario} disse: {mensagem}");

            foreach (TcpClient cliente in Usuarios.Values)
            {
                mensagemUsuario = new StreamWriter(cliente.GetStream());
                mensagemUsuario.WriteLine($"{usuario} disse: {mensagem}");
                mensagemUsuario.Flush();
            }
        }

        public static void EnviarMensagemAdmin(string mensagem)
        {
            StreamWriter mensagemAdmin;

            OnStatusChanged($"Adminstrador: {mensagem}");

            TcpClient[] tcpClients = new TcpClient[Usuarios.Count];
            Usuarios.Values.CopyTo(tcpClients, 0);

            foreach (TcpClient cliente in tcpClients)
            {
                if (mensagem.Trim() == "" || cliente == null) 
                    continue;
                mensagemAdmin = new StreamWriter(cliente.GetStream());
                mensagemAdmin.WriteLine($"Administrador: {mensagem}");
                mensagemAdmin.Flush();
            }
        }

        public TcpListener ListenerServidor;
        public void IniciarServidor()
        {
            ListenerServidor = new TcpListener(EnderecoIp, Porta);
            ListenerServidor.Start();

            ServidorRodando = true;

            ThreadListener = new Thread(ManterServidor);
            ThreadListener.IsBackground = true;
            ThreadListener.Start();
        }

        public void FecharServidor()
        {
            TcpServer.Close();
        }

        public void ManterServidor()
        {
            while (ServidorRodando)
            {
                TcpServer = ListenerServidor.AcceptTcpClient();
                ConexaoUsuario novaConexao = new ConexaoUsuario(TcpServer);
            }
        }
    }
}
