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
    
    public partial class UrunResimleri
    {
        public int UrunResimleriID { get; set; }
        public Nullable<int> UrunID { get; set; }
        public string Resim { get; set; }
        public Nullable<int> PersonelID { get; set; }
    
        public virtual Personeller Personeller { get; set; }
        public virtual Urunler Urunler { get; set; }
    }
}
