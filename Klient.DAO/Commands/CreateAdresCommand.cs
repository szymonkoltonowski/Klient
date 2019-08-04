using Klient.DAO.Models;
using MediatR;

namespace Klient.DAO.Commands
{
    public class CreateAdresCommand : IRequest
    {
        public CreateAdresCommandModel Model { get; }

        public CreateAdresCommand(CreateAdresCommandModel model)
        {
            Model = model;
        }
    }
}
