using System;
using Nubank.Domain.Core.Models;

namespace Nubank.Domain.Models.Clientes
{
    public class Cliente : Entity
    {
        protected Cliente() { }

        public Cliente(Guid id, string nome, string email, int idade, decimal saldo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Idade = idade;
            Saldo = saldo;
        }

        public string Nome { get; private set; }
        public string Email { get; private set; }
        public int Idade { get; private set; }
        public decimal Saldo { get; private set; }
    }
}