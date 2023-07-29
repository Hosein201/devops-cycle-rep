using FluentValidation;
using PCommand_App.Request;

namespace PCommand_App.Validation
{
    public class AddPostCommandValidator : AbstractValidator<AddPostCommand>
    {
        public AddPostCommandValidator()
        {
            RuleFor(command => command.PostText)
              .NotNull()
              .WithMessage("CommentTextCanNotBeNull")
              .NotEmpty()
              .WithMessage("CommentTextCanNotBeEmpty");
        }
    }
}