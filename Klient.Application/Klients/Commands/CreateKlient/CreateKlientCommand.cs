using MediatR;
using System;

namespace Klient.Application.Klients.Commands.CreateKlient
{
    public class CreateKlientCommand : IRequest
    {
        public string Pesel { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public Guid? AdresId { get; set; }
    }
}
