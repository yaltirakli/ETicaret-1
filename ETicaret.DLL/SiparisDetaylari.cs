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
    
    public partial class SiparisDetaylari
    {
        public int SiparisDetaylariID { get; set; }
        public Nullable<int> SiparisID { get; set; }
        public Nullable<int> UrunID { get; set; }
        public Nullable<decimal> SiparisFiyati { get; set; }
        public Nullable<int> Miktar { get; set; }
        public Nullable<int> KampanyaID { get; set; }
    
        public virtual Kampanyalar Kampanyalar { get; set; }
        public virtual Siparisler Siparisler { get; set; }
        public virtual Urunler Urunler { get; set; }
    }
}
