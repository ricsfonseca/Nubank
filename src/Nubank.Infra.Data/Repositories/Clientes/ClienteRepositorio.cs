using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nubank.Domain.Models.Clientes;
using Nubank.Infra.Data.Mocks;

namespace Nubank.Infra.Data.Repositories.Clientes
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly DataStore _dataStore;

        public ClienteRepositorio(DataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public async Task<Cliente> ConsultarPorId(Guid id)
        {
            var cliente = _dataStore.Clientes.Find(x => x.Id == id);
            return await Task.FromResult(cliente).ConfigureAwait(false);
        }

        public async Task<IEnumerable<Cliente>> ConsultarTodosClientes()
            => await Task.FromResult(_dataStore.Clientes).ConfigureAwait(false);
    }
}