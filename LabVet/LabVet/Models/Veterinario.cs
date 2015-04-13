using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LabVet.Models
{
    [Table("Veterinario")]
    public class Veterinario
    {
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Crmv { get; set; }
        public string Email { get; set; }
        
    }
}