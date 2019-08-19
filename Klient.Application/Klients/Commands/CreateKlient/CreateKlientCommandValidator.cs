using FluentValidation;

namespace Klient.Application.Klients.Commands.CreateKlient
{
    public class CreateKlientCommandValidator : AbstractValidator<CreateKlientCommand>
    {
        public CreateKlientCommandValidator()
        {
            RuleFor(x => x.Imie).MaximumLength(50).NotEmpty().WithMessage("Imie musi być mniejszy lub równy 50 znaki(ów)");
            RuleFor(x => x.Nazwisko).MaximumLength(50).NotEmpty().WithMessage("Nazwisko musi być mniejszy lub równy 50 znaki(ów)"); 
            RuleFor(x => x.Pesel).MaximumLength(11).NotEmpty().WithMessage("Pesel musi być mniejszy lub równy 11 znaki(ów)"); 

        }
    }
}
