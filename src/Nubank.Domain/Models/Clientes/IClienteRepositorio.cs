using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nubank.Domain.Models.Clientes
{
    public interface IClienteRepositorio
    {
        Task<Cliente> ConsultarPorId(Guid id);
        Task<IEnumerable<Cliente>> ConsultarTodosClientes();
    }
}