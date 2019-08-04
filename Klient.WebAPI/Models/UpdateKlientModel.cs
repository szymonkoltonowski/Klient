using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klient.WebAPI.Models
{
    public class UpdateKlientModel
    {
        public string Pesel { get; set; }

        public string Imie { get; set; }

        public string Nazwisko { get; set; }
    }
}
