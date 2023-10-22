using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BAL
{

    public class Operations
    {
        public DbConnection db = new DbConnection();
        public Informations info = new Informations();


        public void MüsteriBiletAl(musteriler müsteri)
        {
            using (havayoluEntities db = new havayoluEntities())
            {
                db.musterilers.Add(müsteri);
                db.SaveChanges();
            }
        }

        public void MüsteriSeyahatBilgi(SeyehatBilgileri seyahatBilgi)
        {
            using (havayoluEntities db = new havayoluEntities())
            {
                db.SeyehatBilgileris.Add(seyahatBilgi);
                db.SaveChanges();
            }
        }

        public void MusteriSeyahatDetayBilgi(MusteriUcakSeyehatBilgileri UcusSeyahatDetay)
        {
            using (havayoluEntities db = new havayoluEntities())
            {
                db.MusteriUcakSeyehatBilgileris.Add(UcusSeyahatDetay);
                db.SaveChanges();
            }
        }


        public void MüsteriSil(int id)
        {
            using (havayoluEntities db = new havayoluEntities())
            {
                musteriler MüsteriB = db.musterilers.Find(id);
                db.musterilers.Remove(MüsteriB);
                db.SaveChanges();
            }
        }

        public DataTable BilgiGöster(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from musteriler";
            return db.ExeReader(cmd);
        }


    }
}
