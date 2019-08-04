using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Klient.DAO.Commands
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
