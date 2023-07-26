using Cmd.Common;
using MediatR;

namespace PCommand_App.Request
{
    public class UpdatePostCommand : IRequest<Result>
    {
        public int PostId { get; set; }
        public string PostText { get; set; }
    }
}