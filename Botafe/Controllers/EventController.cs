using Microsoft.AspNetCore.Mvc;

namespace Botafe.Api.Controllers
{
    [Route("api/event")]
    [ApiController]
    public class EventController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
