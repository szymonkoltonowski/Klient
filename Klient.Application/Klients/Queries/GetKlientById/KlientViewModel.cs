using AutoMapper;
using Klient.Model.Entities;
using System;

namespace Klient.Application.Klients.Queries.GetKlientById
{
    public class KlientViewModel
    {
        public Guid Id { get; set; }
        public Guid? AdresId { get; set; }
        public string Pesel { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Miasto { get; set; }

    }
}
