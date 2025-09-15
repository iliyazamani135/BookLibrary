using Domain.Borrowings;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BookingsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IMediator Get_mediator()
        {
            return _mediator;
        }

        [HttpPost("reserve")]
        public async Task<IActionResult> Reserve([FromBody] ReserveBookCommand command, IMediator _mediator)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
