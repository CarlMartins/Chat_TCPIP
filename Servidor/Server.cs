using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Servidor
{
    class Server
    {
        private IPAddress _enderecoIp;
        private int _porta;

        public static Hashtable Usuarios = new Hashtable(10);

        private TcpClient _tcpServer = new TcpClient();

        public static EventHandler<StatusChangedEventArgs> StatusChanged;

        private Thread ThreadListener;

        private bool _servidorRodando = false;

        public Server(IPAddress enderecoIp, int porta)
        {
            _enderecoIp = enderecoIp;
            _porta = porta;
        }

        private TcpListener ListenerServidor;
        public void IniciarServidor()
        {
            ListenerServidor = new TcpListener(_enderecoIp, _porta);
            ListenerServidor.Start();

            _servidorRodando = true;

            ThreadListener = new Thread(ManterServidor);
            ThreadListener.IsBackground = true;
            ThreadListener.Start();
        }  

        private void ManterServidor()
        {
            while (_servidorRodando)
            {
                try
                {
                    _tcpServer = ListenerServidor.AcceptTcpClient();
                    ConexaoUsuario novaConexao = new ConexaoUsuario(_tcpServer);
                }
                catch (Exception)
                {
                    _enderecoIp = null;
                    _porta = 0;
                }
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

            OnStatusChanged($"{usuario}: {mensagem}");

            foreach (TcpClient cliente in Usuarios.Values)
            {
                mensagemUsuario = new StreamWriter(cliente.GetStream());
                mensagemUsuario.WriteLine($"{usuario}: {mensagem}");
                mensagemUsuario.Flush();
            }
        }

        public static void EnviarMensagemAdmin(string mensagem)
        {
            StreamWriter mensagemAdmin;

            OnStatusChanged($"Administrador: {mensagem}");

            foreach (TcpClient cliente in Usuarios.Values)
            {
                if (mensagem.Trim() == "" || cliente == null)
                    continue;
                mensagemAdmin = new StreamWriter(cliente.GetStream());
                mensagemAdmin.WriteLine($"Administrador: {mensagem}");
                mensagemAdmin.Flush();
            }
        }

        public static void OnStatusChanged(string eventMessage)
        {
            if (StatusChanged != null)
            {
                StatusChanged(null, new StatusChangedEventArgs() { EventMessage = eventMessage });
            }
        }

        public void FecharServidor()    
        {
            _servidorRodando = false;
            try
            {
                foreach (TcpClient usuario in Usuarios.Values)
                {
                    usuario.Close();
                }
            }
            catch {}

            ListenerServidor.Stop();
        }

        public static void CriarBackup(string texto)
        {
            try
            {
                string path = @$"C:\Users\{Environment.UserName}" +
                @$"\Desktop\Backup";

                if (Directory.Exists(path) == false)
                {
                    DirectoryInfo di = Directory.CreateDirectory(path);
                }

                using (StreamWriter writer = File.CreateText($"{path}\\" +
                    $"{DateTime.Now:dd-MM-yyyy HHmmss}.txt"))
                {
                    writer.WriteLine(texto);
                }
            }
            catch { };
        }
    }
}
