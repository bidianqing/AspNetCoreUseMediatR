using Domain.Events;
using MediatR;

namespace AspNetCoreUseMediatR.Application.DomainEventHandlers
{
    public class OrderCancelledDomainEventHandler : INotificationHandler<OrderCancelledDomainEvent>
    {
        public async Task Handle(OrderCancelledDomainEvent notification, CancellationToken cancellationToken)
        {
            await Console.Out.WriteLineAsync(notification.OrderId.ToString());
        }
    }
}
