using FluentValidation;

namespace Klient.Application.Adresses.Commands.UpdateAdres
{
    public class UpdateAdresCommandValidator : AbstractValidator<UpdateAdresCommand>
    {
        public UpdateAdresCommandValidator()
        {
            RuleFor(address => address.Id).NotNull();
            RuleFor(address => address.Miasto).NotNull();
            RuleFor(address => address.NrDomu).NotNull();
            RuleFor(address => address.NrMieszkania).NotNull();
            RuleFor(address => address.Ulica).NotNull();
        }
    }
}
