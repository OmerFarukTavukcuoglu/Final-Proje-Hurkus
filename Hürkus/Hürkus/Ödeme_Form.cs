using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using BEL;
using System.Data.Entity;

namespace Hürkus
{
    public partial class Ödeme_Form : Form
    {
        public Ödeme_Form()
        {
            InitializeComponent();
        }
        Bilet_Al_Form BAF = new Bilet_Al_Form();


        public Informations info = new Informations();
        public Operations opr = new Operations();

        int fiyat = 0;

        public void Ödeme_Form_Load(object sender, EventArgs e)
        {
            KalkısSaatiLabel.Visible = false;
            İnisSaatiLabel.Visible = false;
            YolculukSürelabel.Visible = false;
            KalkısYerLabel.Text = "İstanbul";
        }
        int kisi_sayisi = 0;
        string sinif = "";

        private void BiletAlBtn_Click(object sender, EventArgs e)
        {
            havayoluEntities data = new havayoluEntities();
            int intIdt = data.musterilers.Max(u => u.MüşteriID);
            int musteriId = intIdt + 1;

            havayoluEntities seyahat = new havayoluEntities();
            int Sid = seyahat.SeyehatBilgileris.Max(u => u.SeyehatID);
            int seyahatid = Sid + 1;
            Ödeme_AnaForm öaf = new Ödeme_AnaForm();

            if (MüsteriAdTextBox.Text == "" || MüsteriSoyadTextBox.Text == "" || BayRadioBtn.Checked == false && BayanRadioBtn.Checked == false || MüsteriTCtextBox.Text == "" || MüsteriTelTextBox.Text == "" || MüsteriEpostaTextBox.Text == "")
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (sinif == "") { MessageBox.Show("Lütfen Uçmak İstediğiniz Sınıfı Belirtin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else if (BiletAlBtn.Text == "İşlemi Tamamla")
            {

                int koltuk_no = 0;
                Random koltuk = new Random();
                koltuk_no = koltuk.Next(1, 100);
                Random personel = new Random();
                int personel_no = personel.Next(1, 5);
                Random ucak_rnd = new Random();
                int ucak_no = ucak_rnd.Next(1, 9);

                Operations Facade = new Operations();

                musteriler MüsteriBilgi = new musteriler
                {
                    MüşteriAd = MüsteriAdTextBox.Text,
                    MüşteriSoyad = MüsteriSoyadTextBox.Text,
                    MüşteriTC = Convert.ToInt64(MüsteriTCtextBox.Text),
                    MüşteriTel = Convert.ToInt64(MüsteriTelTextBox.Text),
                    MüşteriAdres = AdresRichText.Text,
                    MüşteriMail = MüsteriEpostaTextBox.Text,
                    PersonelID = personel_no

                };
                string sinif = sınıflabel.Text;
                int fiyatlbl = Convert.ToInt32(FiyatLabel.Text);
              
                SeyehatBilgileri SeyahatBilgi = new SeyehatBilgileri
                {
                     MusteriID = musteriId,
                     MüşteriSoyad = MüsteriSoyadTextBox.Text,
                     UçakNo = ucak_no,
                     BiletKodu = "QR3RE3e",
                     KalkışYeri = "İstanbul",
                     VarışYeri = GidisYerLabel.Text,
                     KalkışSaati = TimeSpan.Parse(KalkısSaatiLabel.Text),
                     VarışSaati = TimeSpan.Parse(İnisSaatiLabel.Text),
                     KişiSayısı = Convert.ToInt32(KisiSayısıLabel.Text),
                     GidişTarihi = DateTime.Parse(GidisTarihLabel.Text),
                     DönüşTarihi = DateTime.Parse(DönüsTarihLabel.Text),
                     Sınıf = sinif,
                     KoltukNo = koltuk_no,
                     Fiyat = fiyatlbl
                };

                MusteriUcakSeyehatBilgileri UcakSeyahatBilgi = new MusteriUcakSeyehatBilgileri
                {
                    MusteriID = intIdt,
                    UcakID = ucak_no,
                    SeyahatID = seyahatid,
                    GidişTarih = SeyahatBilgi.GidişTarihi,
                    DönüşTarih = SeyahatBilgi.DönüşTarihi
                };


                //FACADE PATTERN
                Facade.MüsteriBiletAl(MüsteriBilgi);
                Facade.MüsteriSeyahatBilgi(SeyahatBilgi);
                Facade.MusteriSeyahatDetayBilgi(UcakSeyahatBilgi);

                MessageBox.Show(" Bizi Tercih Ettiğiniz için teşekkür Ederiz! \n Bilet Kodunuz: "+ BiletKodu.Text + " " +"\n" + " Koltuk Numaranız: " + koltuk_no , "İyi Uçuşlar Dileriz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BAF.MdiParent = this.MdiParent;
                BAF.Dock = DockStyle.Fill;
                this.Hide();
                BAF.Show();
                //PROXY PATTERN
                Proxy proxy = new Proxy();
                proxy.Request();


               

            }
            else
            {
                öaf.ToplamTutarLabel.Text = FiyatLabel.Text;
                öaf.Show();
            }


         
        }

        //PROXY DESİGN

        abstract class Nesne

        {
            public abstract void Request();
        }



        // The 'RealSubject' class

        class GercekNesne : Nesne

        {
            public override void Request()
            {
                musteriler müsteri = new musteriler();
            }
        }


        // The 'Proxy' class


        class Proxy : Nesne

        {
            private GercekNesne _gercekNesne;

            public override void Request()
            {


                if (_gercekNesne == null)
                {
                    _gercekNesne = new GercekNesne();
                }

                _gercekNesne.Request();
            }
        }



        

        private void EkonomikSnfBtn_Click(object sender, EventArgs e)
        {
            KalkısSaatiLabel.Visible = true;
            İnisSaatiLabel.Visible = true;
            YolculukSürelabel.Visible = true;
            FiyatLabel.Visible = true;
            sinif = "ekonomik";
            sınıflabel.Text = "ekonomik";
            EkonomikSnfBtn.BackColor = Color.Maroon;
            if (ÖzelSnfBtn.BackColor == Color.Maroon)
                ÖzelSnfBtn.BackColor = Color.Gray;

            KalkısSaatiLabel.Visible = true;
            İnisSaatiLabel.Visible = true;
            YolculukSürelabel.Visible = true;

            kisi_sayisi = Convert.ToInt32(KisiSayısıLabel.Text);
            if (GidisYerLabel.Text == "Adana")
            {
                fiyat = 81;
                if (DönüsTarihLabel.Text == "0" +
                    "") { fiyat = fiyat * kisi_sayisi; FiyatLabel.Text = fiyat.ToString(); }
                else if (DönüsTarihLabel.Text != "0") { fiyat = (fiyat * kisi_sayisi) * 2; FiyatLabel.Text = fiyat.ToString(); }

                KalkısSaatiLabel.Text = "21:05:00";
                İnisSaatiLabel.Text = "00:20:00";
                YolculukSürelabel.Text = "3s 15d";

            }
            else if (GidisYerLabel.Text == "Adıyaman")
            {
                fiyat = 95;
                if (DönüsTarihLabel.Text == "0") { fiyat = fiyat * kisi_sayisi; FiyatLabel.Text = fiyat.ToString(); }
                else if (DönüsTarihLabel.Text != "0") { fiyat = (fiyat * kisi_sayisi) * 2; FiyatLabel.Text = fiyat.ToString(); }

                KalkısSaatiLabel.Text = "06:05:00";
                İnisSaatiLabel.Text = "09:35:55";
                YolculukSürelabel.Text = "3s 30d";
            }
            else if (GidisYerLabel.Text == "Antalya")
            {
                fiyat = 115;
                if (DönüsTarihLabel.Text == "0") { fiyat = fiyat * kisi_sayisi; FiyatLabel.Text = fiyat.ToString(); }
                else if (DönüsTarihLabel.Text != "0") { fiyat = (fiyat * kisi_sayisi) * 2; FiyatLabel.Text = fiyat.ToString(); }

                KalkısSaatiLabel.Text = "12:0:00";
                İnisSaatiLabel.Text = "15:10:00";
                YolculukSürelabel.Text = "3s 10d";
            }
            else if (GidisYerLabel.Text == "Ankara")
            {
                fiyat = 136;
                if (DönüsTarihLabel.Text == "0") { fiyat = fiyat * kisi_sayisi; FiyatLabel.Text = fiyat.ToString(); }
                else if (DönüsTarihLabel.Text != "0") { fiyat = (fiyat * kisi_sayisi) * 3; FiyatLabel.Text = fiyat.ToString(); }

                KalkısSaatiLabel.Text = "17:45:00";
                İnisSaatiLabel.Text = "19:00:00";
                YolculukSürelabel.Text = "1s 15d";
            }
            else if (GidisYerLabel.Text == "Batman")
            {
                fiyat = 114;
                if (DönüsTarihLabel.Text == "0") { fiyat = fiyat * kisi_sayisi; FiyatLabel.Text = fiyat.ToString(); }
                else if (DönüsTarihLabel.Text != "0") { fiyat = (fiyat * kisi_sayisi) * 2; FiyatLabel.Text = fiyat.ToString(); }

                KalkısSaatiLabel.Text = "10:00:00";
                İnisSaatiLabel.Text = "13:25:00";
                YolculukSürelabel.Text = "3s 25d";
            }
            else if (GidisYerLabel.Text == "Bingöl")
            {
                fiyat = 105;
                if (DönüsTarihLabel.Text == "0") { fiyat = fiyat * kisi_sayisi; FiyatLabel.Text = fiyat.ToString(); }
                else if (DönüsTarihLabel.Text != "0") { fiyat = (fiyat * kisi_sayisi) * 2; FiyatLabel.Text = fiyat.ToString(); }

                KalkısSaatiLabel.Text = "10:00:00";
                İnisSaatiLabel.Text = "13:20:00";
                YolculukSürelabel.Text = "3s 20d";
            }
            else if (GidisYerLabel.Text == "Bursa")
            {
                fiyat = 97;
                if (DönüsTarihLabel.Text == "0") { fiyat = fiyat * kisi_sayisi; FiyatLabel.Text = fiyat.ToString(); }
                else if (DönüsTarihLabel.Text != "0") { fiyat = (fiyat * kisi_sayisi) * 3; FiyatLabel.Text = fiyat.ToString(); }

                KalkısSaatiLabel.Text = "11:00:00";
                İnisSaatiLabel.Text = "13:55:00";
                YolculukSürelabel.Text = "2s 55d";

            }
            else if (GidisYerLabel.Text == "Çanakkale")
            {
                fiyat = 120;
                if (DönüsTarihLabel.Text == "0") { fiyat = fiyat * kisi_sayisi; FiyatLabel.Text = fiyat.ToString(); }
                else if (DönüsTarihLabel.Text != "0") { fiyat = (fiyat * kisi_sayisi) * 2; FiyatLabel.Text = fiyat.ToString(); }

                KalkısSaatiLabel.Text = "21:35:00";
                İnisSaatiLabel.Text = "01:00:00";
                YolculukSürelabel.Text = "3s 25d";
            }
            else if (GidisYerLabel.Text == "Denizli")
            {
                fiyat = 107;
                if (DönüsTarihLabel.Text == "0") { fiyat = fiyat * kisi_sayisi; FiyatLabel.Text = fiyat.ToString(); }
                else if (DönüsTarihLabel.Text != "0") { fiyat = (fiyat * kisi_sayisi) * 2; FiyatLabel.Text = fiyat.ToString(); }

                KalkısSaatiLabel.Text = "10:00:00";
                İnisSaatiLabel.Text = "12:45:00";
                YolculukSürelabel.Text = "2s 45d";
            }
            else if (GidisYerLabel.Text == "Erzurum")
            {
                fiyat = 110;
                if (DönüsTarihLabel.Text == "0") { fiyat = fiyat * kisi_sayisi; FiyatLabel.Text = fiyat.ToString(); }
                else if (DönüsTarihLabel.Text != "0") { fiyat = (fiyat * kisi_sayisi) * 2; FiyatLabel.Text = fiyat.ToString(); }

                KalkısSaatiLabel.Text = "16:20:00";
                İnisSaatiLabel.Text = "17:50:00";
                YolculukSürelabel.Text = "1s 30d";
            }
            else if (GidisYerLabel.Text == "Muğla")
            {
                fiyat = 113;
                if (DönüsTarihLabel.Text == "0") { fiyat = fiyat * kisi_sayisi; FiyatLabel.Text = fiyat.ToString(); }
                else if (DönüsTarihLabel.Text != "0") { fiyat = (fiyat * kisi_sayisi) * 2; FiyatLabel.Text = fiyat.ToString(); }

                KalkısSaatiLabel.Text = "09:25:00";
                İnisSaatiLabel.Text = "11:35:00";
                YolculukSürelabel.Text = "2s 10d";
            }
            else if (GidisYerLabel.Text == "Trabzon")
            {
                fiyat = 108;
                if (DönüsTarihLabel.Text == "0") { fiyat = fiyat * kisi_sayisi; FiyatLabel.Text = fiyat.ToString(); }
                else if (DönüsTarihLabel.Text != "0") { fiyat = (fiyat * kisi_sayisi) * 2; FiyatLabel.Text = fiyat.ToString(); }

                KalkısSaatiLabel.Text = "14:00:00";
                İnisSaatiLabel.Text = "15:45:00";
                YolculukSürelabel.Text = "1s 45d";
            }
            TLabel.Visible = true;

        }

        private void ÖzelSnfBtn_Click(object sender, EventArgs e)
        {
            KalkısSaatiLabel.Visible = true;
            İnisSaatiLabel.Visible = true;
            YolculukSürelabel.Visible = true;
            FiyatLabel.Visible = true;

            sinif = "Özel";
            sınıflabel.Text = "Özel";
            ÖzelSnfBtn.BackColor = Color.Maroon;
            if (EkonomikSnfBtn.BackColor == Color.Maroon)
                EkonomikSnfBtn.BackColor = Color.Gray;

            KalkısSaatiLabel.Visible = true;
            İnisSaatiLabel.Visible = true;
            YolculukSürelabel.Visible = true;


            kisi_sayisi = Convert.ToInt32(KisiSayısıLabel.Text);
            if (GidisYerLabel.Text == "Adana")
            {
                fiyat = 181;
                if (DönüsTarihLabel.Text == "0" +
                    "") { fiyat = fiyat * kisi_sayisi; FiyatLabel.Text = fiyat.ToString(); }
                else if (DönüsTarihLabel.Text != "0") { fiyat = (fiyat * kisi_sayisi) * 4; FiyatLabel.Text = fiyat.ToString(); }

                KalkısSaatiLabel.Text = "21:05:00";
                İnisSaatiLabel.Text = "00:20:00";
                YolculukSürelabel.Text = "3s 15d";

            }
            else if (GidisYerLabel.Text == "Adıyaman")
            {
                fiyat = 142;
                if (DönüsTarihLabel.Text == "0") { fiyat = fiyat * kisi_sayisi; FiyatLabel.Text = fiyat.ToString(); }
                else if (DönüsTarihLabel.Text != "0") { fiyat = (fiyat * kisi_sayisi) * 4; FiyatLabel.Text = fiyat.ToString(); }

                KalkısSaatiLabel.Text = "06:05:00";
                İnisSaatiLabel.Text = "09:35:55";
                YolculukSürelabel.Text = "3s 30d";
            }
            else if (GidisYerLabel.Text == "Antalya")
            {
                fiyat = 237;
                if (DönüsTarihLabel.Text == "0") { fiyat = fiyat * kisi_sayisi; FiyatLabel.Text = fiyat.ToString(); }
                else if (DönüsTarihLabel.Text != "0") { fiyat = (fiyat * kisi_sayisi) * 2; FiyatLabel.Text = fiyat.ToString(); }

                KalkısSaatiLabel.Text = "12:0:00";
                İnisSaatiLabel.Text = "15:10:00";
                YolculukSürelabel.Text = "3s 10d";
            }
            else if (GidisYerLabel.Text == "Ankara")
            {
                fiyat = 136;
                if (DönüsTarihLabel.Text == "0") { fiyat = fiyat * kisi_sayisi; FiyatLabel.Text = fiyat.ToString(); }
                else if (DönüsTarihLabel.Text != "0") { fiyat = (fiyat * kisi_sayisi) * 4; FiyatLabel.Text = fiyat.ToString(); }

                KalkısSaatiLabel.Text = "17:45:00";
                İnisSaatiLabel.Text = "19:00:00";
                YolculukSürelabel.Text = "1s 15d";
            }
            else if (GidisYerLabel.Text == "Batman")
            {
                fiyat = 227;
                if (DönüsTarihLabel.Text == "0") { fiyat = fiyat * kisi_sayisi; FiyatLabel.Text = fiyat.ToString(); }
                else if (DönüsTarihLabel.Text != "0") { fiyat = (fiyat * kisi_sayisi) * 2; FiyatLabel.Text = fiyat.ToString(); }

                KalkısSaatiLabel.Text = "10:00:00";
                İnisSaatiLabel.Text = "13:25:00";
                YolculukSürelabel.Text = "3s 25d";
            }
            else if (GidisYerLabel.Text == "Bingöl")
            {
                fiyat = 183;
                if (DönüsTarihLabel.Text == "0") { fiyat = fiyat * kisi_sayisi; FiyatLabel.Text = fiyat.ToString(); }
                else if (DönüsTarihLabel.Text != "0") { fiyat = (fiyat * kisi_sayisi) * 2; FiyatLabel.Text = fiyat.ToString(); }

                KalkısSaatiLabel.Text = "10:00:00";
                İnisSaatiLabel.Text = "13:20:00";
                YolculukSürelabel.Text = "3s 20d";
            }
            else if (GidisYerLabel.Text == "Bursa")
            {
                fiyat = 237;
                if (DönüsTarihLabel.Text == "0") { fiyat = fiyat * kisi_sayisi; FiyatLabel.Text = fiyat.ToString(); }
                else if (DönüsTarihLabel.Text != "0") { fiyat = (fiyat * kisi_sayisi) * 2; FiyatLabel.Text = fiyat.ToString(); }

                KalkısSaatiLabel.Text = "11:00:00";
                İnisSaatiLabel.Text = "13:55:00";
                YolculukSürelabel.Text = "2s 55d";

            }
            else if (GidisYerLabel.Text == "Çanakkale")
            {
                fiyat = 186;
                if (DönüsTarihLabel.Text == "0") { fiyat = fiyat * kisi_sayisi; FiyatLabel.Text = fiyat.ToString(); }
                else if (DönüsTarihLabel.Text != "0") { fiyat = (fiyat * kisi_sayisi) * 2; FiyatLabel.Text = fiyat.ToString(); }

                KalkısSaatiLabel.Text = "21:35:00";
                İnisSaatiLabel.Text = "01:00:00";
                YolculukSürelabel.Text = "3s 25d";
            }
            else if (GidisYerLabel.Text == "Denizli")
            {
                fiyat = 167;
                if (DönüsTarihLabel.Text == "0") { fiyat = fiyat * kisi_sayisi; FiyatLabel.Text = fiyat.ToString(); }
                else if (DönüsTarihLabel.Text != "0") { fiyat = (fiyat * kisi_sayisi) * 2; FiyatLabel.Text = fiyat.ToString(); }

                KalkısSaatiLabel.Text = "10:00:00";
                İnisSaatiLabel.Text = "12:45:00";
                YolculukSürelabel.Text = "2s 45d";
            }
            else if (GidisYerLabel.Text == "Erzurum")
            {
                fiyat = 180;
                if (DönüsTarihLabel.Text == "0") { fiyat = fiyat * kisi_sayisi; FiyatLabel.Text = fiyat.ToString(); }
                else if (DönüsTarihLabel.Text != "0") { fiyat = (fiyat * kisi_sayisi) * 2; FiyatLabel.Text = fiyat.ToString(); }

                KalkısSaatiLabel.Text = "16:20:00";
                İnisSaatiLabel.Text = "17:50:00";
                YolculukSürelabel.Text = "1s 30d";
            }
            else if (GidisYerLabel.Text == "Muğla")
            {
                fiyat = 156;
                if (DönüsTarihLabel.Text == "0") { fiyat = fiyat * kisi_sayisi; FiyatLabel.Text = fiyat.ToString(); }
                else if (DönüsTarihLabel.Text != "0") { fiyat = (fiyat * kisi_sayisi) * 2; FiyatLabel.Text = fiyat.ToString(); }

                KalkısSaatiLabel.Text = "09:25:00";
                İnisSaatiLabel.Text = "11:35:00";
                YolculukSürelabel.Text = "2s 10d";
            }
            else if (GidisYerLabel.Text == "Trabzon")
            {
                fiyat = 193;
                if (DönüsTarihLabel.Text == "0") { fiyat = fiyat * kisi_sayisi; FiyatLabel.Text = fiyat.ToString(); }
                else if (DönüsTarihLabel.Text != "0") { fiyat = (fiyat * kisi_sayisi) * 2; FiyatLabel.Text = fiyat.ToString(); }

                KalkısSaatiLabel.Text = "14:00:00";
                İnisSaatiLabel.Text = "15:45:00";
                YolculukSürelabel.Text = "1s 45d";
            }
            TLabel.Visible = true;
        }
         

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void GeriDönLbl_Click(object sender, EventArgs e)
        {
            BAF.MdiParent = this.MdiParent;
            BAF.Dock = DockStyle.Fill;
            this.Hide();
            BAF.Show();
        }

        private void MüsteriTCtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void MüsteriTelTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void MüsteriAdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void MüsteriSoyadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void MüsteriEpostaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
