using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Informations
    {
        //Müsteri Bilgi     
        public int MusteriID { get; set; }
        public int MüsteriAd { get; set; }
        public string MüsterSoyad { get; set; }
        public int MüsteriTC { get; set; }
        public string MüsteriTel { get; set; }
        public string MüsteriAdres { get; set; }
        public string MüsteriMail { get; set; }



        //Seyahat Bilgi
        public int SMüsteriID { get; set; }
        public string SMüsteri_Soyad { get; set; }
        public int Ucak_No { get; set; }
        public string BiletKodu { get; set; }
        public string KalkısYeri { get; set; }
        public string VarısYeri { get; set; }
        public int KalkısSaat { get; set; }
        public int VarisSaat { get; set; }
        public int KisiSayisi { get; set; }
        public DateTime GidisTarihi { get; set; }
        public int DönüsTarihi { get; set; }
        public string Ucus_Sınıf { get; set; }
        public int KoltukNo { get; set; }
        public double Fiyat { get; set; }
    }
}
