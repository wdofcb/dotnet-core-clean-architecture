using MediatR;

namespace Application.Orders.Commands
{
    public class CreateOrderCommand : IRequest<int>
    {
        public int NumberOfItems { get; set; }
        public int CustomerId { get; set; }
    }
}
