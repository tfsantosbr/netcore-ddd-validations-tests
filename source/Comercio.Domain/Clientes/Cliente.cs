using Comercio.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Comercio.Domain.Clientes
{
    public class Cliente
    {
        private Cliente(string nome, string sobrenome, string email)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
        }

        private Cliente()
        {
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Email { get; private set; }

        public static Result<Cliente> Criar(string nome, string sobrenome, string email)
        {
            var result = new Result<Cliente>();

            if(string.IsNullOrEmpty(nome))
            {
                result.AddNotification("Nome", "Nome não pode ser vazio");
            }

            var client = new Cliente(
                nome: nome,
                sobrenome: sobrenome,
                email: email
                );
        }
    }
}
