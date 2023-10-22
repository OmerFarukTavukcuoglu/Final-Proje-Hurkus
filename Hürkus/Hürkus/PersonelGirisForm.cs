using BEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hürkus
{
    public partial class PersonelGirisForm : Form
    {
        public PersonelGirisForm()
        {
            InitializeComponent();
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {
            YetkiliPersonelForm YPF = new YetkiliPersonelForm();
            using (havayoluEntities havayolu = new havayoluEntities())
            {
                {

                    Personeller veri = (from nesne in havayolu.Personellers select nesne).FirstOrDefault();
                    string PersonelAd;
                    string Sifre;
                    /* if(YolcuSoyadTxtBox.Text =="" || BiletKodTextBox.Text =="")
                     {
                         MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz!");
                     }
                     else
                     {*/
                    try
                    {
                        PersonelAd = veri.PersonelAd.ToString();
                        Sifre = veri.PersonelSifre.ToString();
                        if (PersonelAd == PerAdTextBox.Text && Sifre == PerSifreTextBox.Text)
                        {
                            MessageBox.Show("Giriş İşlemi Başarılı!","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.None);
                            YPF.Show();
                            this.Hide();
                        }
                        else { MessageBox.Show("Hatalı Giriş","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning); }
                    }
                    catch (Exception)
                    {


                    }
                }
            }
        }



        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bilet_Al_Form BAF = new Bilet_Al_Form();
            BAF.Show();
        }
    }
}