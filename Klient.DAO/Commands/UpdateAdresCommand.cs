using MediatR;
using System;

namespace Klient.DAO.Commands
{
    public class UpdateAdresCommand : IRequest
    {
        public Guid Id { get; set; }

        public string Miasto { get; set; }

        public string NrMieszkania { get; set; }

        public string NrDomu { get; set; }
        public string Ulica { get; set; }
    }
}
