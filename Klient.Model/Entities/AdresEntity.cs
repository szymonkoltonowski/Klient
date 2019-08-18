using System;
using System.Collections.Generic;

namespace Klient.Model.Entities
{
    public class AdresEntity
    {
        public Guid Id { get; set; }
        public string Ulica { get; set; }
        public string Miasto { get; set; }
        public string NrDomu { get; set; }
        public string NrMieszkania { get; set; }
        public ICollection<KlientEntity> Klient { get; set; }
        public void Clean()
        {

        }
    }
}
