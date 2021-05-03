﻿using System;
using System.Net;

namespace Cliente
{
    class Validacao
    {
        private string _enderecoIp;
        private string _mensagem;
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

            if (_nomeUsuario.Trim() == "")
            {
                _resultado += "Nome de usuario inválido";
            }

            return _resultado;
        }
    }
}
