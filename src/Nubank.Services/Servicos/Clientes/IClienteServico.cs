using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClienteViewModel = Nubank.Application.ViewModels.Clientes.ClienteViewModel;

namespace Nubank.Application.Servicos.Clientes
{
    public interface IClienteServico
    {
        Task<ClienteViewModel> ConsultarPorId(Guid id);
        Task<IEnumerable<ClienteViewModel>> ConsultarTodosClientes();
    }
}