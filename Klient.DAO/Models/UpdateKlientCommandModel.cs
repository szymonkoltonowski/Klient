using System;
using System.Collections.Generic;
using System.Text;

namespace Klient.DAO.Models
{
    public class UpdateKlientCommandModel
    {
        public Guid Id { get; set; }

        public string Pesel { get; set; }

        public string Imie { get; set; }

        public string Nazwisko { get; set; }
        public Guid? AdresId { get; set; }

    }
}
