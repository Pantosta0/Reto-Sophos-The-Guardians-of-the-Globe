using FluentValidation;
namespace Application.Features.Heroes.Commands.DeleteHeroeCommand
{
    public class DeleteHeroeCommandValidator : AbstractValidator<DeleteHeroeCommand>
    {
     public DeleteHeroeCommandValidator()
        {
         RuleFor(p => p.Id)
             .NotEmpty().WithMessage("{PropertyName} no puede estar vacío.")
             .NotNull()
             .GreaterThan(0).WithMessage("{PropertyName} debe ser mayor que cero.");
     }
    }
}
