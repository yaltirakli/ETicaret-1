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
    
    public partial class Siparisler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Siparisler()
        {
            this.Faturalar = new HashSet<Faturalar>();
            this.SiparisDetaylari = new HashSet<SiparisDetaylari>();
        }
    
        public int SiparislerID { get; set; }
        public Nullable<int> UyeID { get; set; }
        public Nullable<int> PersonelID { get; set; }
        public Nullable<System.DateTime> Tarihi { get; set; }
        public Nullable<int> KargoID { get; set; }
        public Nullable<decimal> ToplamFiyat { get; set; }
        public Nullable<int> SiparisAdet { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Faturalar> Faturalar { get; set; }
        public virtual Kargolar Kargolar { get; set; }
        public virtual Personeller Personeller { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SiparisDetaylari> SiparisDetaylari { get; set; }
        public virtual Uyeler Uyeler { get; set; }
    }
}
