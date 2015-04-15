using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LabVet.Models
{
    [Table("Veterinario")]
    public class Veterinario: Pessoa
    {
        public Veterinario(){
            Clinicas = new HashSet<Clinica>();
        }
        
        public string Crmv { get; set; }

        public virtual ICollection<Clinica> Clinicas { get; set; }
    }
}