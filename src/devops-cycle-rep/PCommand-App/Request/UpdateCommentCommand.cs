using Cmd.Common;
using MediatR;

namespace PCommand_App.Request
{
    public class UpdateCommentCommand : IRequest<Result>
    {
        public int PostId { get; set; }
        public int CommentId { get; set; }
        public string CommentText { get; set; }
    }
}