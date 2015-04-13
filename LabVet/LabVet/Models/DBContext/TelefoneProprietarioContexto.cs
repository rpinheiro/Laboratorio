using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using LabVet.Models;

namespace LabVet.Models.DBContext
{
    public class TelefoneProprietarioDB : DbContext
    {
        public TelefoneProprietarioDB()
        {
        }

        public DbSet<TelefoneProprietario> TelefoneProprietarios { get; set; }

    }
}