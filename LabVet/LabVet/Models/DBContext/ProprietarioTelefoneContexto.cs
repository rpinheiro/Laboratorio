using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using LabVet.Models;

namespace LabVet.Models.DBContext
{
    public class ProprietarioTelefoneDB : BaseContexto
    {
        public ProprietarioTelefoneDB()
        {
        }

        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<Proprietario> Proprietarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }

    }
}