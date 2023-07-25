using MediatR;
using Microsoft.AspNetCore.Mvc;
using PCommand_App.Request;

namespace PCommand.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommentController : ControllerBase
    {
        private readonly ILogger<CommentController> _logger;
        private readonly IMediator _mediator;

        public CommentController(ILogger<CommentController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpPost("")]
        public async Task<IActionResult> PostComment([FromBody] AddCommentCommand command, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(command, cancellationToken);
            return Ok(result);
        }

        [HttpPut("")]
        public async Task<IActionResult> PutComment([FromBody] UpdateCommentCommand command, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(command, cancellationToken);
            return Ok(result);
        }
    }
}