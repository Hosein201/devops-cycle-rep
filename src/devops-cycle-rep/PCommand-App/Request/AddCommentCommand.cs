using Cmd.Common;
using MediatR;

namespace PCommand_App.Request
{
    public class AddCommentCommand : IRequest<Result>
    {
        public int PostId { get; set; }
        public string CommentText { get; set; }
    }
}