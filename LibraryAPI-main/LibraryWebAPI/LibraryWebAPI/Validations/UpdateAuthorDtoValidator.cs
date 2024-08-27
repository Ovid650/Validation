using FluentValidation;
using LibraryWebAPI.Dtos.Author;

namespace LibraryWebAPI.Validations
{
    public class UpdateAuthorDtoValidator : AbstractValidator<AuthorDto>
    {
        public UpdateAuthorDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Name is required")
                .NotNull()
                .WithMessage("Name is required")
                .MaximumLength(50)
                .WithMessage("Name maximum length is 50");

            
        }
    }
}
