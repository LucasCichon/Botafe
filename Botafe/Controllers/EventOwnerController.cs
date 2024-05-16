using Botafe.Domain.Entities;
using Botafe.Shared.VM;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Botafe.Api.Controllers
{
    [Route("api/eventOwner")]
    [ApiController]
    [EnableCors("MyAllowSpecificOrigins")]
    public class EventOwnerController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public EventOwnerDetailVm eventOwner()
        {
            return new EventOwnerDetailVm()
                { FirstName = "Łukasz", LastName = "Cichon", Email = "lucas.cichon93@mgila.com" };
        }
    }
}
