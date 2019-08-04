using Klient.DAO.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Klient.DAO.Commands
{
    public class CreateKlientCommand : IRequest
    {
        public CreateKlientCommandModel Model { get; }

        public CreateKlientCommand(CreateKlientCommandModel model)
        {
            Model = model;
        }
    }
}
