using Botafe.Application.EventOwners.Commands.CreateEventOwner;
using Botafe.Application.EventOwners.Queries.GetEventOwnerDetail;
using Botafe.Domain.Entities;
using Botafe.Shared.VM;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Botafe.Api.Controllers
{
    [Route("api/eventOwners")]
    [EnableCors("MyAllowSpecificOrigins")]
    public class EventOwnersController : BaseController
    {
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<Application.EventOwners.Queries.GetEventOwnerDetail.EventOwnerDetailVm> GetDetails(int id)
        {
            var vm = await Mediator.Send(new GetEventOwnerDetailQuery() { EventOwnerId = id });
            return vm;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> CreateEventOwner(CreateEventOwnerCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
    }
}
