using Application.Common.Interfaces;
using Application.Orders.Commands;
using Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Orders.Handlers
{
    class CreateOrdersCommadHandler : IRequestHandler<CreateOrderCommand, int>
    {
        public IApplicationDbContext _context { get; }

        public CreateOrdersCommadHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = new Order()
            {
                NumberOfItems = request.NumberOfItems,
                CustomerId = request.CustomerId
            };

            _context.Orders.Add(order);
            await _context.SaveChangesAsync(cancellationToken);

            return order.Id;
        }
    }
}
