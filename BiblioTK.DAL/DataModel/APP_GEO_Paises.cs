//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BiblioTK.DAL.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class APP_GEO_Paises
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public APP_GEO_Paises()
        {
            this.tbl_Usuarios = new HashSet<tbl_Usuarios>();
        }
        [Key]
        public string pais_iso { get; set; }
        public string pais_iso2 { get; set; }
        public string pais_code { get; set; }
        public string pais_nombre { get; set; }
        public string pais_ingles { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Usuarios> tbl_Usuarios { get; set; }
    }
}
