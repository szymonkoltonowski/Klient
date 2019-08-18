using MediatR;
using System;

namespace Klient.Application.Klients.Commands.UpdateKlient
{
    public class UpdateKlientCommand : IRequest
    {

        public Guid Id { get; set; }

        public string Pesel { get; set; }

        public string Imie { get; set; }

        public string Nazwisko { get; set; }
        public Guid? AdresId { get; set; }
        
    }
}
