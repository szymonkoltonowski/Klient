using Klient.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Klient.DAO
{
    public interface IDataContext
    {
        DbSet<KlientEntity> Klient { get; set; }
        DbSet<AdresEntity> Adres { get; set; }
    }
}
