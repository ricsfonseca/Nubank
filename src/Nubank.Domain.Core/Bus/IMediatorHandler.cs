using System.Threading.Tasks;
using Nubank.Domain.Core.Commands;
using Nubank.Domain.Core.Events;

namespace Nubank.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
        Task RaiseEvent<T>(T @event) where T : Event;
    }
}
