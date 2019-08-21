using MediatR;
using System;

namespace Klient.Application.Adresses.Commands.CreateAdres
{
    public class CreateAdresCommand : IRequest
    {
        public string Miasto { get; set; }
        public string NrMieszkania { get; set; }
        public string NrDomu { get; set; }
        public string Ulica { get; set; }
    }
}
