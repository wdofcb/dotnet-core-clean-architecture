using Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Application.Orders.Queries
{
    public class GetCustomerOrdersQuery : IRequest<IList<Order>>
    {
        public int CustomerId { get; set; }
    }
}
