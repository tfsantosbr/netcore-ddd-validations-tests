using System;
using System.Collections.Generic;
using System.Text;

namespace Comercio.Domain.Clientes.Commands
{
    public class CriarCliente
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
    }
}
