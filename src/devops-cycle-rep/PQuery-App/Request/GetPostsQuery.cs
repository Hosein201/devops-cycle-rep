using Cmd.Common;
using MediatR;

namespace PQuery_App.Request
{
    public class GetPostsQuery : IRequest<Result>
    {
        public int Take { get; set; }
        public int Skip { get; set; }
    }
}