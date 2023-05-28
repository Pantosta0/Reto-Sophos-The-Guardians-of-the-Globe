using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Heroes.Commands.UpdateHeroeCommand
{
    public class UpdateHeroeCommandValidator : AbstractValidator<UpdateHeroeCommand>
    {
        public UpdateHeroeCommandValidator()
        {
            RuleFor(p => p.NombreSuper)
              .NotEmpty().WithMessage("{PropertyName} es requerido.")
              .NotNull()
              .MaximumLength(80).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres.");

            RuleFor(p => p.Nombre)
                .NotEmpty().WithMessage("{PropertyName} es requerido.")
                .NotNull()
                .MaximumLength(80).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres.");

            RuleFor(p => p.Edad)
                .NotEmpty().WithMessage("{PropertyName} es requerido.")
                .NotNull()
                .GreaterThan(0).WithMessage("{PropertyName} debe ser mayor a 0.");

            RuleFor(p => p.Sexo)
                .NotEmpty().WithMessage("{PropertyName} es requerido.")
                .NotNull()
                .MaximumLength(80).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres.");

            RuleFor(p => p.Habilidades)
                .NotEmpty().WithMessage("{PropertyName} es requerido.")
                .NotNull()
                .MaximumLength(255).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres.");

            RuleFor(p => p.Debilidades)
                .NotEmpty().WithMessage("{PropertyName} es requerido.")
                .NotNull()
                .MaximumLength(255).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres.");

            RuleFor(p => p.RelacionesPersonales)
                .NotEmpty().WithMessage("{PropertyName} es requerido.")
                .NotNull()
                .MaximumLength(255).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres.");

            RuleFor(p => p.PatrocinadorId)
                .NotEmpty().WithMessage("{PropertyName} es requerido.")
                .NotNull()
                .GreaterThan(0).WithMessage("{PropertyName} debe ser mayor a 0.");
        }
    }
}
