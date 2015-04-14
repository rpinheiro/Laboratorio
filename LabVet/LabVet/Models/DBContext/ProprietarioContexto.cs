using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using LabVet.Models;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace LabVet.Models.DBContext
{
    public class ProprietarioDB : DbContext
    {
        public ProprietarioDB()
            : base("name=LabVet")
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}