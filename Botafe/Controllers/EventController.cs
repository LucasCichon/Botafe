using Microsoft.AspNetCore.Mvc;

namespace Botafe.Api.Controllers
{
    [Route("api/event")]
    [ApiController]
    public class EventController : ControllerBase
    {
        public string Index()
        {
            return "Hello from event controller";
        }
    }
}
