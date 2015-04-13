using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using LabVet.Models;

namespace LabVet.Models.DBContext
{
    public class VeterinarioDB : DbContext
    {
        public VeterinarioDB()
            : base("name=LabVet")
        {
        }

        public DbSet<Veterinario> Veterinarios { get; set; }

    }
}