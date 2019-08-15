  using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Klient.Model.Entities
{
    public class AdresEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Ulica { get; set; }
        [Required]
        public string Miasto { get; set; }
        [Required]
        public string NrDomu { get; set; }
        public string NrMieszkania { get; set; }

        public ICollection<KlientEntity> Klient { get; set; }

        public void Clean()
        {

        }
    }
}
