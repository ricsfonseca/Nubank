using System.Threading.Tasks;
using MediatR;
using Nubank.Domain.Core.Bus;
using Nubank.Domain.Core.Commands;
using Nubank.Domain.Core.Events;

namespace Nubank.Infra.CrossCutting.Bus
{
    public sealed class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);
        }

        public Task RaiseEvent<T>(T @event) where T : Event
        {
            return _mediator.Publish(@event);
        }
    }
}