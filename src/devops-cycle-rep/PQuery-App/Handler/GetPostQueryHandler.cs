using Cmd.Common;
using MediatR;
using PQuery_App.Request;

namespace PQuery_App.Handler
{
    public class GetPostQueryHandler : IRequestHandler<GetPostQuery,Result>
    {
        public Task<Result> Handle(GetPostQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}