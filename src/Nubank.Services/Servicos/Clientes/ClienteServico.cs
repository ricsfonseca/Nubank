using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Nubank.Application.ViewModels.Clientes;
using Nubank.Domain.Models.Clientes;

namespace Nubank.Application.Servicos.Clientes
{
    public class ClienteServico : IClienteServico
    {
        private readonly IMapper _mapper;
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteServico(IMapper mapper, IClienteRepositorio clienteRepositorio)
        {
            _mapper = mapper;
            _clienteRepositorio = clienteRepositorio;
        }

        public async Task<ClienteViewModel> ConsultarPorId(Guid id)
        {
            return _mapper.Map<ClienteViewModel>(await _clienteRepositorio.ConsultarPorId(id).ConfigureAwait(false));
        }

        public async Task<IEnumerable<ClienteViewModel>> ConsultarTodosClientes()
        {
            return _mapper.Map<IEnumerable<ClienteViewModel>>(await _clienteRepositorio.ConsultarTodosClientes().ConfigureAwait(false));
        }
    }
}
