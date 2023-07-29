using FluentValidation;
using PCommand_App.Request;

namespace PCommand_App.Validation
{
    public class UpdateCommentCommandValidator : AbstractValidator<UpdateCommentCommand>
    {
        public UpdateCommentCommandValidator()
        {
            RuleFor(command => command.CommentText)
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

            RuleFor(command => command.CommentId)
                .NotNull()
                .WithMessage("CommentIdCanNotBeNull")
                .NotEmpty()
                .WithMessage("CommentIdCanNotBeEmpty")
                .NotEqual(0)
                .WithMessage("CommentIdCanNotBeEmpty");
        }
    }
}