using Klient.DAO.Models;
using MediatR;

namespace Klient.DAO.Commands
{
    public class UpdateAdresCommand : IRequest
    {
        public UpdateAdresCommandModel Model { get; }

        public UpdateAdresCommand(UpdateAdresCommandModel model)
        {
            Model = model;
        }
    }
}
