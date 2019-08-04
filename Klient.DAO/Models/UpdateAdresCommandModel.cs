using System;
using System.Collections.Generic;
using System.Text;

namespace Klient.DAO.Models
{
    public class UpdateAdresCommandModel
    {
        public Guid Id { get; set; }

        public string Miasto { get; set; }

        public string NrMieszkania { get; set; }

        public string NrDomu { get; set; }
        public string Ulica { get; set; }
    }
}
