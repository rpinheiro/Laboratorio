//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LabVet.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TelefoneProprietario
    {
        public int ID { get; set; }
        public int Proprietario { get; set; }
        public int Telefone { get; set; }
    
        public virtual Proprietario Proprietario1 { get; set; }
        public virtual Telefone Telefone1 { get; set; }
    }
}
