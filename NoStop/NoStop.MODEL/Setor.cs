//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NoStop.MODEL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Setor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Setor()
        {
            this.Fila = new HashSet<Fila>();
        }
    
        public int ID { get; set; }
        public string Nome { get; set; }
        public int IDEstabelecimento { get; set; }
    
        public virtual Estabelecimento Estabelecimento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fila> Fila { get; set; }
    }
}
