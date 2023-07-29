using FluentValidation;
using PCommand_App.Request;

namespace PCommand_App.Validation
{
    public class UpdatePostCommandValidator : AbstractValidator<UpdatePostCommand>
    {
        public UpdatePostCommandValidator()
        {
            RuleFor(command => command.PostText)
                .NotNull()
                .WithMessage("CommentTextCanNotBeNull")
                .NotEmpty()
                .WithMessage("CommentTextCanNotBeEmpty");

            RuleFor(command => command.PostId)
                .NotNull()
                .WithMessage("PostIdCanNotBeNull")
                .NotEmpty()
                .WithMessage("PostIdCanNotBeEmpty")
                .NotEqual(0)
                .WithMessage("PostIdCanNotBeEmpty");
        }
    }
}