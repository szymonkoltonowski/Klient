using System;
using System.Collections.Generic;
using System.Text;

namespace Klient.Model.Entities
{
    public class Klient
    {
        public string Pesel { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public int AdresId { get; set; }

        public Adres Adres { get; set; }
    }
}
