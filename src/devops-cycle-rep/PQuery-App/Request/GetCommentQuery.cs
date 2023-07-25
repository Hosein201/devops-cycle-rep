using Cmd.Common;
using MediatR;

namespace PQuery_App.Request
{
    public class GetCommentQuery : IRequest<Result>
    {
        public int PostId { get; set; }
    }
}