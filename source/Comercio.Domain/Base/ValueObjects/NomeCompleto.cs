using System;
using System.Collections.Generic;
using System.Text;

namespace Comercio.Domain.Base.ValueObjects
{
    public class NomeCompleto
    {
        public NomeCompleto(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
    }
}
