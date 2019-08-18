using FluentValidation;

namespace Klient.Application.Adresses.Commands.DeleteAdres
{
    public class DeleteAdresCommandValidator : AbstractValidator<DeleteAdresCommand>
    {
        public DeleteAdresCommandValidator()
        {
            RuleFor(address => address.Id).NotNull();
        }
    }
}
