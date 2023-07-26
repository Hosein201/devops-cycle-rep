using Cmd.Common;
using MediatR;
using PCommand_App.Request;

namespace PCommand_App.Handler
{
    public class AddCommentCommandHandler : IRequestHandler<AddCommentCommand, Result>
    {
        public Task<Result> Handle(AddCommentCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}