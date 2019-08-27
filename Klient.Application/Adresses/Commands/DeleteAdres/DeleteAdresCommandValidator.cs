using FluentValidation;
using System;

namespace Klient.Application.Adresses.Commands.DeleteAdres
{
    public class DeleteAdresCommandValidator : AbstractValidator<DeleteAdresCommand>
    {
        public DeleteAdresCommandValidator()
        {
            RuleFor(address => address.Id).NotEqual(Guid.Empty);
        }
    }
}
