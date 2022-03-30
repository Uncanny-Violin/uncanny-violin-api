using Microsoft.AspNetCore.Mvc; 
using Uncanny.Violin.Domain.Catalog; 

namespace Uncanny.Violin.Api.Controllers
{
	[ApiController]
	[Route("/catalog")]
	public class CatalogController : ControllerBase
	{ 
        [HttpGet]
        public IActionResult GetItems()
        {
            return Ok("hello world."); 
        } 
	}
}
