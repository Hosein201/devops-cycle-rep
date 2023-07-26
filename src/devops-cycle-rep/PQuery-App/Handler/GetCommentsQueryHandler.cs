using Cmd.Common;
using MediatR;
using PQuery_App.Request;

namespace PQuery_App.Handler
{
    public class GetCommentsQueryHandler : IRequestHandler<GetCommentsQuery, Result>
    {
        public Task<Result> Handle(GetCommentsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}