using FluentValidation;
using PCommand_App.Request;

namespace PCommand_App.Validation
{
    public class AddCommentCommandValidator : AbstractValidator<AddCommentCommand>
    {
        public AddCommentCommandValidator()
        {
            RuleFor(command => command.PostId)
                .NotNull()
                .WithMessage("PostIdCanNotBeNull")
                .NotEmpty()
                .WithMessage("PostIdCanNotBeEmpty")
                .NotEqual(0)
                .WithMessage("PostIdCanNotBeEmpty");

            RuleFor(command => command.CommentText)
              .NotNull()
              .WithMessage("CommentTextCanNotBeNull")
              .NotEmpty()
              .WithMessage("CommentTextCanNotBeEmpty");
        }
    }
}