using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Klient.Model.Entities
{
    public class KlientEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        [Required, RegularExpression(@"^\d{11}$")]
        public string Pesel { get; set; }
        [Required]
        public string Imie { get; set; }
        [Required]
        public string Nazwisko { get; set; }

        public Guid? AdresId { get; set; }
        public AdresEntity Adres { get; set; }
    }
}
