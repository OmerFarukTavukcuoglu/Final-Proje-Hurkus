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


namespace Hürkus
{
    public partial class Check_in_Form : Form
    {
        public Check_in_Form()
        {
            InitializeComponent();
        }
      

        private void BiletAlBtn_Click(object sender, EventArgs e)
        {
            Bilet_Al_Form bilet = new Bilet_Al_Form();

            bilet.MdiParent = this.MdiParent;
            this.Hide();
            bilet.Show();
        }


        private void UcusDurumBtn_Click(object sender, EventArgs e)
        {
            Ucus_Durum_Form UDF = new Ucus_Durum_Form();
            UDF.MdiParent = this.MdiParent;
            UDF.Dock = DockStyle.Fill;
            this.Hide();
            UDF.Show();
        }

        private void Check_in_Form_Load(object sender, EventArgs e)
        {
            Check_inBtn.BackColor = Color.SlateGray;
            MesajLabel.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
         

            using (havayoluEntities havayolu = new havayoluEntities())
            {
                {

                    SeyehatBilgileri veri = (from nesne in havayolu.SeyehatBilgileris where nesne.BiletKodu == BiletKodTextBox.Text select nesne).FirstOrDefault();
                    string biletkod;
                    string soyad;
                    if (YolcuSoyadTxtBox.Text == "" || BiletKodTextBox.Text == "")
                    {
                        MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz!","Eksik Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MesajLabel.Visible = true;
                        try
                        {
                            biletkod = veri.BiletKodu.ToString();
                            soyad = veri.MüşteriSoyad.ToString();
                            if (YolcuSoyadTxtBox.Text == soyad && BiletKodTextBox.Text == biletkod)
                            {
                                MesajLabel.Text = "Sayın " + soyad + " Aradığınız Rezervasyon Kaydı Başarıyla Bulundu.";
                            }
                            else if (YolcuSoyadTxtBox.Text != soyad && BiletKodTextBox.Text != biletkod)
                            {
                                MesajLabel.Text = "Aratılan Kayıt Bulunamadı.";
                            }
                        }
                        catch (Exception)
                        {
                            MesajLabel.Text = "Aratılan Kayıt Bulunamadı.";

                        }                  

                    }
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
