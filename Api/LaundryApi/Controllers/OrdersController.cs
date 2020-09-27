using Application.Orders.Commands;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LaundryApi.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    public class OrdersController : ApiController
    {
        public async Task<ActionResult<int>> Create(CreateOrderCommand command)
        {
            return await Mediator.Send(command);
        }

    }
}