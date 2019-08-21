
using System;

namespace Klient.DTO.Models
{
    public class AdresDTO
    {
        public Guid Id { get; set; }
        public string Miasto { get; set; }
        public string NrMieszkania { get; set; }
        public string NrDomu { get; set; }
        public string Ulica { get; set; }
    }
}

