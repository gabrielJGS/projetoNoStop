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
    
    public partial class FilaCliente
    {
        public int ID { get; set; }
        public int IDCliente { get; set; }
        public int IDFila { get; set; }
        public System.DateTime Data { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Fila Fila { get; set; }
    }
}
