//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ETicaret.DLL
{
    using System;
    using System.Collections.Generic;
    
    public partial class KargoFirmalari
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KargoFirmalari()
        {
            this.Kargolar = new HashSet<Kargolar>();
        }
    
        public int KargoFirmalariID { get; set; }
        public string KargoAdi { get; set; }
        public Nullable<System.DateTime> AnlasmaTarihi { get; set; }
        public Nullable<System.DateTime> AnlasmaBitisTarihi { get; set; }
        public string Aciklama { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kargolar> Kargolar { get; set; }
    }
}
