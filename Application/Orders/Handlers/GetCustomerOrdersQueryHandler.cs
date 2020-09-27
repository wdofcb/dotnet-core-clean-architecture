using Application.Common.Interfaces;
using Application.Orders.Queries;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Orders.Handlers
{
    public class GetCustomerOrdersQueryHandler : IRequestHandler<GetCustomerOrdersQuery, IList<Order>>
    {
        private readonly IApplicationDbContext _context;

        public GetCustomerOrdersQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IList<Order>> Handle(GetCustomerOrdersQuery request, CancellationToken cancellationToken)
        {
            return await _context.Orders.Where(x => x.CustomerId == request.CustomerId).ToListAsync();
        }
    }
}
