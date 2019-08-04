using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klient.WebAPI.Models
{
    public class UpdateAdresModel
    {
        public string Ulica { get; set; }
        public string Miasto { get; set; }
        public string NrDomu { get; set; }
        public string NrMieszkania { get; set; }
    }
}
