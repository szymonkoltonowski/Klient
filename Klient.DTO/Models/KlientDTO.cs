using System;

namespace Klient.DTO.Models
{
    public class KlientDTO
    {
        public Guid Id { get; set; }
        public string Pesel { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public Guid? AdresId { get; set; }
        public string Miasto { get; set; }
    }
}
