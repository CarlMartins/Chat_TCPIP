using System;
using System.Net;

namespace Cliente
{
    class Validacao
    {
        private string _enderecoIp;
        private string _nomeUsuario;
        private string _resultado;


        public Validacao(string enderecoIp, string nomeUsuario)
        {
            _enderecoIp = enderecoIp;
            _nomeUsuario = nomeUsuario;
        }

        public string ValidarDadosConexao()
        {
            _resultado = "";
            try
            {
                IPAddress.Parse(_enderecoIp);
            }
            catch (Exception)
            {
                _resultado += "Endereço IP inválido\r\n";
            }

            if (_nomeUsuario.Trim() == "" || _nomeUsuario.Trim() == "Nome de usuario")
            {
                _resultado += "Nome de usuario inválido";
            } 
            else
            {
                try
                {
                    int.Parse(_nomeUsuario[0].ToString());
                    _resultado += "Nome de usuario não deve iniciar com números";
                }
                catch { };
            }

            return _resultado;
        }
    }
}
