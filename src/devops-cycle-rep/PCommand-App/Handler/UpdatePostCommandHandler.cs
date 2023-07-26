using Cmd.Common;
using MediatR;
using PCommand_App.Request;

namespace PCommand_App.Handler
{
    public class UpdatePostCommandHandler : IRequestHandler<UpdatePostCommand, Result>
    {
        public Task<Result> Handle(UpdatePostCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}