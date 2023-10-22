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
    public partial class PersonelGüncellemeForm : Form
    {
        public PersonelGüncellemeForm()
        {
            InitializeComponent();
        }
        public int satirid=0;

  
        private void GüncelleBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(satirid.ToString());
            havayoluEntities entity = new havayoluEntities();
            musteriler musteri = (from nesne in entity.musterilers where nesne.MüşteriID == satirid select nesne).FirstOrDefault();
            int mid;
            mid = musteri.MüşteriID;
            if(MüsteriAdTextBox.Text ==""|| MüsteriSoyadTextBox.Text =="" || MüsteriTCtextBox.Text==""|| MüsteriTelTextBox.Text==""|| MüsteriEpostaTextBox.Text==""|| AdresRichText.Text=="")
            {
                MessageBox.Show("Lütfen Bütün Bilgileri Doğru Şekilde Giriniz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (satirid == mid)
                {
                    musteri.MüşteriAd = MüsteriAdTextBox.Text;
                    musteri.MüşteriSoyad = MüsteriSoyadTextBox.Text;
                    musteri.MüşteriTC = Convert.ToInt64(MüsteriTCtextBox.Text);
                    musteri.MüşteriTel = Convert.ToInt64(MüsteriTelTextBox.Text);
                    musteri.MüşteriMail = MüsteriEpostaTextBox.Text;
                    musteri.MüşteriAdres = AdresRichText.Text;
                    entity.SaveChanges();
                    MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleştirildi!", "Güncelleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DegerTemizle();
                }
            }
           
        }

        private void DegerTemizle()
        {
            MüsteriAdTextBox.Clear();
            MüsteriSoyadTextBox.Clear();
            MüsteriTCtextBox.Clear();
            MüsteriTelTextBox.Clear();
            MüsteriEpostaTextBox.Clear();
            AdresRichText.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MüsteriTelTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void MüsteriTCtextBox_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
