using FluentValidation;

namespace Klient.Application.Klients.Commands.CreateKlient
{
    public class CreateKlientCommandValidator : AbstractValidator<CreateKlientCommand>
    {
        public CreateKlientCommandValidator()
        {
            RuleFor(x => x.Imie).MaximumLength(60).NotEmpty().WithMessage("Imie musi być mniejszy lub równy 60 znaki(ów)");
            RuleFor(x => x.Nazwisko).MaximumLength(15).NotEmpty().WithMessage("Nazwisko musi być mniejszy lub równy 15 znaki(ów)"); 
            RuleFor(x => x.Pesel).MaximumLength(11).NotEmpty().WithMessage("Pesel musi być mniejszy lub równy 11 znaki(ów)"); 

        }
    }
}
