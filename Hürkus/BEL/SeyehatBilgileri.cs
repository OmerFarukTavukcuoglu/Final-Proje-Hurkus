//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BEL
{
    using System;
    using System.Collections.Generic;
    
    public partial class SeyehatBilgileri
    {
        public int SeyehatID { get; set; }
        public Nullable<int> MusteriID { get; set; }
        public string MüşteriSoyad { get; set; }
        public Nullable<int> UçakNo { get; set; }
        public string BiletKodu { get; set; }
        public string KalkışYeri { get; set; }
        public string VarışYeri { get; set; }
        public Nullable<System.TimeSpan> KalkışSaati { get; set; }
        public Nullable<System.TimeSpan> VarışSaati { get; set; }
        public Nullable<int> KişiSayısı { get; set; }
        public Nullable<System.DateTime> GidişTarihi { get; set; }
        public Nullable<System.DateTime> DönüşTarihi { get; set; }
        public string Sınıf { get; set; }
        public Nullable<int> KoltukNo { get; set; }
        public Nullable<double> Fiyat { get; set; }
    }
}
