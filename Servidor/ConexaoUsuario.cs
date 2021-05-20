using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace Servidor
{
    class ConexaoUsuario
    {
        private TcpClient _tcpClient;
        private Thread _threadValidacao;
        private StreamReader _receptor;
        private StreamWriter _enviador;
        private string _usuarioAtual;
        private string _resposta;

        public ConexaoUsuario(TcpClient cliente)
        {
            _tcpClient = cliente;
            _threadValidacao = new Thread(ValidarUsuario);
            _threadValidacao.Start();
        }

        private void AceitarUsuario(TcpClient cliente, string usuarioAtual)
        {
            Server.Usuarios.Add(usuarioAtual, cliente);
            Server.EnviarMensagemAdmin($"{usuarioAtual} se conectou.");
            AguardarMensagem();
        }

        private void ValidarUsuario()
        {
            _receptor = new StreamReader(_tcpClient.GetStream());
            _enviador = new StreamWriter(_tcpClient.GetStream());
            _usuarioAtual = _receptor.ReadLine();

            if(Server.Usuarios.Count >= 10)
            {
                _enviador.WriteLine("0|Limite de usuários atingido.");
                _enviador.Flush();
                FechaConexao();
                return;
            }

            if (_usuarioAtual != "")
            {
                if (Server.Usuarios.Contains(_usuarioAtual))
                {
                    _enviador.WriteLine("0|Este nome de usuário já existe.");
                    _enviador.Flush();
                    FechaConexao();
                    return;
                }
                else if (_usuarioAtual.ToLower() == "administrador")
                {
                    _enviador.WriteLine("0|Este nome de usuário é reservado.");
                    _enviador.Flush();
                    FechaConexao();
                    return;
                }
                else
                {
                    _enviador.WriteLine("1");
                    _enviador.Flush();

                    AceitarUsuario(_tcpClient, _usuarioAtual);
                }
            }
            else
            {
                FechaConexao();
                return;
            }          
        }

        private void RemoverUsuario(string usuarioAtual)
        {
            if (Server.Usuarios[usuarioAtual] != null)
            {
                Server.Usuarios.Remove(usuarioAtual);
                Server.EnviarMensagemAdmin($"{usuarioAtual} se desconectou (" +
                    $"{DateTime.Now:HH:mm}).");
            }
        }

        private void AguardarMensagem()
        {
            try
            {
                while ((_resposta = _receptor.ReadLine()) != null)
                {
                    Server.ValidarMensagem(_usuarioAtual, _resposta);
                }
            }
            catch (Exception)
            { 
                RemoverUsuario(_usuarioAtual);
            }
        }

        private void FechaConexao()
        {
            _tcpClient.Close();
            _receptor.Close();
            _enviador.Close();
        }
    }
}
