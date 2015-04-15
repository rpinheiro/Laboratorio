using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using LabVet.Models;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace LabVet.Models.DBContext
{
    public class ClinicaDB : DbContext
    {
        public ClinicaDB()
            : base("name=LabVet")
        {
        }

        public DbSet<Clinica> Clinicas { get; set; }
        public DbSet<Veterinario> Veterinarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Clinica>()
                       .HasMany(l => l.Veterinarios)
                       .WithMany(a => a.Clinicas)
                       .Map(x =>
                       {
                           x.MapLeftKey("ClinicaID");
                           x.MapRightKey("VeterinarioID");
                           x.ToTable("VeterinarioClinica");
                       });

            

        }

    }
}