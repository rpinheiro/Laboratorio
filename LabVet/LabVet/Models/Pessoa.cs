//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabVet.Models
{
    using System;
    using System.Collections.Generic;
    [Table("Pessoas")]
    public abstract class Pessoa
    {
        public Pessoa()
        {
        }
    
        [Key]
        public int PessoaID { get; set; }
        public string nome { get; set; }
        public string Logradouro { get; set; }
        public int? numero { get; set; }
        public string cep { get; set; }
        public string bairro { get; set; }
        public string municipio { get; set; }
        public string estado { get; set; }
        public string email { get; set; }
    
        public virtual ICollection<Proprietario> Proprietarios { get; set; }        
        public virtual ICollection<Veterinario> Veterinarios { get; set; }
        public virtual ICollection<Telefone> Telefones { get; set; }
    }
}
