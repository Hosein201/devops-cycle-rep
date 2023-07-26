using Cmd.Common;
using MediatR;
using PQuery_App.Request;

namespace PQuery_App.Handler
{
    public class GetCommentQueryHandler : IRequestHandler<GetCommentQuery, Result>
    {
        public Task<Result> Handle(GetCommentQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}