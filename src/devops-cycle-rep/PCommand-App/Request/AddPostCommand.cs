using Cmd.Common;
using MediatR;

namespace PCommand_App.Request
{
    public class AddPostCommand : IRequest<Result>
    {
        public string PostText { get; set; }
    }
}