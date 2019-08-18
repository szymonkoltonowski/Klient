using MediatR;
using System;

namespace Klient.Application.Adresses.Commands.DeleteAdres

{
    public class DeleteAdresCommand : IRequest
    {
        public Guid Id { get; }

        public DeleteAdresCommand(Guid Id)
        {
            this.Id = Id;
        }
    }
}
