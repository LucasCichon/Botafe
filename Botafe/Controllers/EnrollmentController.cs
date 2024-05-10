using Microsoft.AspNetCore.Mvc;

namespace Botafe.Api.Controllers
{
    [Route("api/enrollment")]
    [ApiController]
    public class EnrollmentController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
