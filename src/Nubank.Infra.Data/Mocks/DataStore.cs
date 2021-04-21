using System;
using System.Collections.Generic;
using System.Linq;
using Bogus;
using Nubank.Domain.Models.Clientes;
using Nubank.Infra.Data.Extensions;

namespace Nubank.Infra.Data.Mocks
{
    public class DataStore
    {
        public List<Cliente> Clientes { get; set; }

        public DataStore()
        {
            LoadFakeData();
        }

        private void LoadFakeData()
        {
            Clientes = new Faker<Cliente>()
                .UsePrivateConstructor()
                .RuleFor(s => s.Id, f => Guid.NewGuid())
                .RuleFor(s => s.Nome, f => f.Name.FullName())
                .RuleFor(s => s.Idade, f => f.Random.Number(18, 99))
                .RuleFor(s => s.Email, f => f.Person.Email)
                .RuleFor(s => s.Saldo, f => f.Finance.Amount(100, 1000))
                .Generate(10).ToList();

        }
    }
}