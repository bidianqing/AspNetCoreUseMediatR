using MediatR;

namespace Domain.Events
{
    public class OrderCancelledDomainEvent : INotification
    {
        public int OrderId { get; set; }

        public OrderCancelledDomainEvent(int orderId)
        {
            OrderId = orderId;
        }
    }
}
