//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FACEBAND.WEB.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Genero
    {
        public Genero()
        {
            this.GeneroBanda = new HashSet<GeneroBanda>();
        }
    
        public int GeneroId { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
    
        public virtual ICollection<GeneroBanda> GeneroBanda { get; set; }
    }
}
