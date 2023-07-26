using Cmd.Common;
using MediatR;

namespace PQuery_App.Request
{
    public class GetPostQuery : IRequest<Result>
    {
        public int PostId { get; set; }
    }
}