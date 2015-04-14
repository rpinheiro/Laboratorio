using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LabVet.Models
{
    [Table("Veterinarios")]
    public class Veterinario: Pessoa
    {
        
        public string Crmv { get; set; }
    }
}