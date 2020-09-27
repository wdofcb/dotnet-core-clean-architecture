using Application.Common.Interfaces;
using Application.Orders.Queries;
using Application.Orders.ViewModels;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Orders.Handlers
{
    public class GetCustomerOrdersQueryHandler : IRequestHandler<GetCustomerOrdersQuery, IList<OrderViewModel>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetCustomerOrdersQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IList<OrderViewModel>> Handle(GetCustomerOrdersQuery request, CancellationToken cancellationToken)
        {
            var response = await _context.Orders.Where(x => x.CustomerId == request.CustomerId).ToListAsync();

            return _mapper.Map<List<OrderViewModel>>(response);
        }
    }
}
