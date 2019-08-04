using MediatR;
using System;

namespace Klient.DAO.Commands
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
