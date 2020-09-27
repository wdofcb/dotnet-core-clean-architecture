using Application.Orders.ViewModels;
using MediatR;
using System.Collections.Generic;

namespace Application.Orders.Queries
{
    public class GetCustomerOrdersQuery : IRequest<IList<OrderViewModel>>
    {
        public int CustomerId { get; set; }
    }
}
