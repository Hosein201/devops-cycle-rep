using FluentValidation;
using PQuery_App.Request;

namespace PQuery_App.Validation
{
    public class GetCommentQueryValidator : AbstractValidator<GetCommentQuery>
    {
        public GetCommentQueryValidator()
        {
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