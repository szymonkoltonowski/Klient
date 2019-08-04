using Klient.DAO.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Klient.DAO.Commands
{
    public class UpdateKlientCommand : IRequest
    {
        public UpdateKlientCommandModel Model { get; }

        public UpdateKlientCommand(UpdateKlientCommandModel model)
        {
            Model = model;
        }
    }
}
