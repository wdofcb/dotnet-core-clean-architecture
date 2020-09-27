using Application.Orders.Commands;
using Application.Orders.Queries;
using Application.Orders.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LaundryApi.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    public class OrdersController : ApiController
    {
        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateOrderCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpGet]
        public async Task<IList<OrderViewModel>> Get()
        {
            return await Mediator.Send(new GetCustomerOrdersQuery() { CustomerId = 3 });
        }
    }
}