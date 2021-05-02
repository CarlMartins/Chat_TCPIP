using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidor.Entidades
{
    class Mensagem
    {
        public string Texto { get; set; }
        public DateTime HoraEnviado { get; set; } = DateTime.Now;
    }
}
