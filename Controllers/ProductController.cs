using Events.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Events.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet("{name}")]
        public string Get(string name)
        {
            var product = new Product(1, "Product 1");
            product.NameUpdated += product.WhenEventIsRaised;
            product.UpdateName(name);
            return "Hello World!";
        }
    }
}