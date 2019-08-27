using FluentValidation;

namespace Klient.Application.Adresses.Commands.CreateAdres
{
    public class CreateAdresCommandValidator : AbstractValidator<CreateAdresCommand>
    {
        public CreateAdresCommandValidator()
        {
            RuleFor(address => address.Miasto).NotNull().WithMessage("Pole musi być uzupełnione"); ;
            RuleFor(address => address.NrDomu).NotNull().WithMessage("Pole musi być uzupełnione");
            RuleFor(address => address.NrMieszkania);
            RuleFor(address => address.Ulica).NotNull().WithMessage("Pole musi być uzupełnione");
        }

    }
}
