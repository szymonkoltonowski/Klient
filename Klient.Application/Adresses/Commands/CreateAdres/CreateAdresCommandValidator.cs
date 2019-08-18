using FluentValidation;

namespace Klient.Application.Adresses.Commands.CreateAdres
{
    public class CreateAdresCommandValidator : AbstractValidator<CreateAdresCommand>
    {
        public CreateAdresCommandValidator()
        {
            RuleFor(address => address.Miasto).NotNull();
            RuleFor(address => address.NrDomu).NotNull();
            RuleFor(address => address.NrMieszkania).NotNull();
            RuleFor(address => address.Ulica).NotNull();
        }

    }
}
