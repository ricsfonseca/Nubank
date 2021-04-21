using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nubank.Application.Servicos.Clientes;
using Nubank.Application.ViewModels.Clientes;
using Nubank.Domain.Core.Bus;
using Nubank.Domain.Core.Notifications;

namespace Nubank.Api.Controllers
{
    [ApiController]
    [ApiVersion("1", Deprecated = false)]
    [Route("api/v{version:apiVersion}/clientes")]
    [Produces("application/json")]
    public class ClienteController : ApiController
    {
        private readonly IClienteServico _clienteServico;

        public ClienteController(IClienteServico clienteServico, INotificationHandler<DomainNotification> notifications,
            IMediatorHandler mediator) : base(notifications, mediator)
        {
            _clienteServico = clienteServico;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ClienteViewModel>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Get()
        {
            return Response(await _clienteServico.ConsultarTodosClientes().ConfigureAwait(false));
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(ClienteViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            return Response(await _clienteServico.ConsultarPorId(id).ConfigureAwait(false));
        }
    }
}
