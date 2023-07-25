using MediatR;
using Microsoft.AspNetCore.Mvc;
using PQuery_App.Request;

namespace PQuery.Controllers
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

        [HttpGet("")]
        public async Task<IActionResult> GetComments([FromQuery] GetCommentsQuery query, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(query, cancellationToken);
            return Ok(result);
        }

        [HttpGet("")]
        public async Task<IActionResult> GetComment([FromQuery] GetCommentQuery query, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(query, cancellationToken);
            return Ok(result);
        }
    }
}