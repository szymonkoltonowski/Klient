using MediatR;
using System;

namespace Klient.DAO.Commands
{
    public class CreateKlientCommand : IRequest
    {
        public Guid Id { get; set; }

        public string Pesel { get; set; }

        public string Imie { get; set; }

        public string Nazwisko { get; set; }
        public Guid? AdresId { get; set; }
    }
}
