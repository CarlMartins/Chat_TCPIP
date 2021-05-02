using Servidor.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidor.Entidades
{
    class Usuario
    {
        public string Nome { get; set; }
        public UsuarioEnum Cargo { get; set; }

        public Usuario(string nome, UsuarioEnum cargo = UsuarioEnum.Usuario)
        {
            Nome = nome;
            Cargo = cargo;
        }
    }
}
