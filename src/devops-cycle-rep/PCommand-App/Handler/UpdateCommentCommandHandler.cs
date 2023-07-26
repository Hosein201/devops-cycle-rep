using Cmd.Common;
using MediatR;
using PCommand_App.Request;

namespace PCommand_App.Handler
{
    public class UpdateCommentCommandHandler : IRequestHandler<UpdateCommentCommand, Result>
    {
        public Task<Result> Handle(UpdateCommentCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}