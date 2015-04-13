using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using LabVet.Models;

namespace LabVet.Models.DBContext
{
    public class TelefoneDB : BaseContexto
    {
        public TelefoneDB()
        {
        }

        public DbSet<Telefone> Telefones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }

    }
}