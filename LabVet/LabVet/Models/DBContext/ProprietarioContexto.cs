using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using LabVet.Models;

namespace LabVet.Models.DBContext
{
    public class ProprietarioDB : DbContext
    {
        public ProprietarioDB()
            : base("name=LabVet")
        {
        }

        public DbSet<Proprietario> Proprietarios { get; set; }

    }
}