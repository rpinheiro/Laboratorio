using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using LabVet.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace LabVet.Models.DBContext
{
    public class PessoaDB : BaseContexto
    {
        public PessoaDB()
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Proprietario> Proprietarios { get; set; }
        public DbSet<Veterinario> Veterinarios { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove< PluralizingTableNameConvention>();

            modelBuilder.Entity<Proprietario>().ToTable("Proprietario");
            modelBuilder.Entity<Veterinario>().ToTable("Veterinario");

        }

    }
}