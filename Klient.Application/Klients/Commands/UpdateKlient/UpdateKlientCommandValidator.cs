using FluentValidation;

namespace Klient.Application.Klients.Commands.UpdateKlient
{
    public class UpdateKlientCommandValidator : AbstractValidator<UpdateKlientCommand>
    {
        public UpdateKlientCommandValidator()
        {
            RuleFor(v => v.Id).NotEmpty().WithMessage("Pole musi być uzupełnione");
            RuleFor(x => x.Imie).MaximumLength(60).NotEmpty().WithMessage("Imie musi być mniejszy lub równy 60 znaki(ów)");
            RuleFor(x => x.Nazwisko).MaximumLength(15).NotEmpty().WithMessage("Nazwisko musi być mniejszy lub równy 15 znaki(ów)");
            RuleFor(x => x.Pesel).MaximumLength(11).NotEmpty().WithMessage("Pesel musi być mniejszy lub równy 11 znaki(ów)"); 
        }
    }
}
