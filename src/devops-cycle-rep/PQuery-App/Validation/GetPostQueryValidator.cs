using FluentValidation;
using PQuery_App.Request;

namespace PQuery_App.Validation
{
    public class GetPostQueryValidator : AbstractValidator<GetPostQuery>
    {
        public GetPostQueryValidator()
        {
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