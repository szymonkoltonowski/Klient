using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Klient.Model.Entities
{
    public class KlientEntity
    {
        public Guid Id { get; set; }
        public string Pesel { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public Guid? AdresId { get; set; }
        public AdresEntity Adres { get; set; }
    }
}
