using Cmd.Common;
using MediatR;
using PQuery_App.Request;

namespace PQuery_App.Handler
{
    public class GetPostsQueryHandler : IRequestHandler<GetPostsQuery, Result>
    {
        public Task<Result> Handle(GetPostsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}