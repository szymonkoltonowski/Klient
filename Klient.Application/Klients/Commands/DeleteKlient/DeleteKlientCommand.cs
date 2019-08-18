using MediatR;
using System;

namespace Klient.Application.Klients.Commands.DeleteKlient
{
    public class DeleteKlientCommand : IRequest
    {
        public Guid Id { get; }

        public DeleteKlientCommand(Guid Id)
        {
            this.Id = Id;
        }
    }
}
