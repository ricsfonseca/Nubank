using MediatR;
using Nubank.Domain.Core.Bus;
using Nubank.Domain.Core.Commands;
using Nubank.Domain.Core.Notifications;

namespace Nubank.Domain.CommandHandlers
{
    public class CommandHandler
    {
        private readonly IMediatorHandler _bus;
        private readonly DomainNotificationHandler _notifications;

        public CommandHandler(IMediatorHandler bus, INotificationHandler<DomainNotification> notifications)
        {
            _notifications = (DomainNotificationHandler)notifications;
            _bus = bus;
        }

        protected void NotifyValidationErrors(Command message)
        {
            foreach (var error in message.ValidationResult.Errors)
            {
                _bus.RaiseEvent(new DomainNotification(message.MessageType, error.ErrorMessage));
            }
        }
    }
}