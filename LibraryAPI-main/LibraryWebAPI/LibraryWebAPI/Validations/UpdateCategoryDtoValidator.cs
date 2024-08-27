using FluentValidation;
using LibraryWebAPI.Dtos.Categories;

namespace LibraryWebAPI.Validations
{
    public class UpdateCategoryDtoValidator : AbstractValidator<CategoryDto>
    {
        public UpdateCategoryDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Name is required")
                .MaximumLength(50)
                .WithMessage("Name maximum length is 50");

            
        }
    }
}
