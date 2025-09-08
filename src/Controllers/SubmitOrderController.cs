using Microsoft.AspNetCore.Mvc;

namespace CooperaSharp_DependencyExplosion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubmitOrderController(OrderSubmissionTransactor processor) : ControllerBase
    {
        [HttpPost]
        public IActionResult SubmitOrder([FromBody] OrderSubmissionRequest request)
        {
            var result = processor.Process(new OrderSubmissionBag { Request = request, Customer = null, Order = null });
            
            return result 
                    ? Ok()
                    : StatusCode(500, "It was not possible to submit your order. Try again later.");
        }
    }
}
