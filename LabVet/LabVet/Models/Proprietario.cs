using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LabVet.Models
{
    [Table("Proprietario")]
    public class Proprietario
    {
        public Proprietario()
        {
            Telefones = new HashSet<Telefone>();
            Telefones.Add(new Telefone() { TipoTelefone = TipoTelefone.Celular });
            Telefones.Add(new Telefone() { TipoTelefone = TipoTelefone.Residencial });
        }

        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Telefone> Telefones { get; set; }

    }
}