using Cmd.Common;
using MediatR;
using PCommand_App.Request;

namespace PCommand_App.Handler
{
    public class AddPostCommandHandler : IRequestHandler<AddPostCommand, Result>
    {
        public Task<Result> Handle(AddPostCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}