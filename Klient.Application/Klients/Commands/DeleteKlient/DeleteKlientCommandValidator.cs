using FluentValidation;

namespace Klient.Application.Klients.Commands.DeleteKlient
{
    public class DeleteKlientValidatorCommand : AbstractValidator<DeleteKlientCommand>
    {
        public DeleteKlientValidatorCommand()
        {
            RuleFor(v => v.Id).NotEmpty().WithMessage("Pole musi być uzupełnione");
        }
    }
}
