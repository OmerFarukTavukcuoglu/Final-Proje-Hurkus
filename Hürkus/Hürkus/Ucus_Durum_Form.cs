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
    public partial class Ucus_Durum_Form : Form
    {
        public Ucus_Durum_Form()
        {
            InitializeComponent();
        }

        private void Check_inBtn_Click(object sender, EventArgs e)
        {
            Check_in_Form CIF = new Check_in_Form();
            CIF.MdiParent = this.MdiParent;
            CIF.Dock = DockStyle.Fill;
            this.Hide();
            CIF.Show();
        }

        private void BiletAlBtn_Click(object sender, EventArgs e)
        {
            Bilet_Al_Form bilet = new Bilet_Al_Form();

            bilet.MdiParent = this.MdiParent;
            this.Hide();
            bilet.Show();
        }


        private void Ucus_Durum_Form_Load(object sender, EventArgs e)
        {
            UcusDurumBtn.BackColor = Color.SlateGray;
            UcusSonucLbl.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            if(UcakNoTextBox.Text=="")
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UcusSonucLbl.Visible = true;

                using (havayoluEntities havayolu = new havayoluEntities())
                {
                    SeyehatBilgileri veri = (from nesne in havayolu.SeyehatBilgileris where nesne.UçakNo.ToString() == UcakNoTextBox.Text select nesne).FirstOrDefault();

                    int ucakno;
                    string varisyeri, kalkisyeri;
                    if (veri != null)
                    {
                        ucakno = Convert.ToInt32(veri.UçakNo);
                        kalkisyeri = veri.KalkışYeri;
                        varisyeri = veri.VarışYeri;
                        UcusSonucLbl.Text = "Ucus Durum:  Olumlu. Aratılan Uçak " + kalkisyeri + " - " + varisyeri + " için Havalanacak";
                    }
                    else
                    {
                        UcusSonucLbl.Text = "Ucus Durum: Olumsuz";
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
 