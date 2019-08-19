using FluentValidation;

namespace Klient.Application.Adresses.Commands.UpdateAdres
{
    public class UpdateAdresCommandValidator : AbstractValidator<UpdateAdresCommand>
    {
        public UpdateAdresCommandValidator()
        {
            RuleFor(address => address.Id).NotNull().WithMessage("Pole musi być uzupełnione");
            RuleFor(address => address.Miasto).NotNull().WithMessage("Pole musi być uzupełnione");
            RuleFor(address => address.NrDomu).NotNull().WithMessage("Pole musi być uzupełnione");
            RuleFor(address => address.NrMieszkania).NotNull().WithMessage("Pole musi być uzupełnione");
            RuleFor(address => address.Ulica).NotNull().WithMessage("Pole musi być uzupełnione");
        }
    }
}
