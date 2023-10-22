using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hürkus
{
    public partial class Bilet_Al_Form : Form
    {
        public Bilet_Al_Form()
        {
            InitializeComponent();
       
        }
        Check_in_Form CIF = new Check_in_Form();
        Ucus_Durum_Form UDF = new Ucus_Durum_Form();

        bool durum = true;
        bool baslangic = false;
        DateTime gidis;
        DateTime dönüs;


        private void Bilet_Al_Form_Load(object sender, EventArgs e)
        {
        
            panel1.Visible = false;
            YolcuSayısı_TextBox.Visible = false;
            BiletAlBtn.BackColor = Color.SlateGray;
            Gidis_Tarih_Picker.CustomFormat = "dddd dd--MM-yyyy";
            Dönüs_Tarih_Picker.CustomFormat = "dddd dd--MM-yyyy";
        }


        private void YolcuSayısıBtn_Click(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                panel1.Visible = false;
            }
            if (YolcuSayısı_TextBox.Visible == true)
            {
                YolcuSayısı_TextBox.Visible = false;
            }
            else if (YolcuSayısı_TextBox.Visible == false)
            {
                YolcuSayısı_TextBox.Visible = true;
                YolcuSayısı_TextBox.Focus();
            }
        }

        private void Check_inBtn_Click(object sender, EventArgs e)
        {
            CIF.MdiParent = this.MdiParent;
            CIF.Dock = DockStyle.Fill;
            this.Hide();
            CIF.Show();
        }

        private void UcusDurumBtn_Click(object sender, EventArgs e)
        {
            UDF.MdiParent = this.MdiParent;
            UDF.Dock = DockStyle.Fill;
            this.Hide();
            UDF.Show();
        }

        private void TarihBtn_Click(object sender, EventArgs e)
        {
            YolcuSayısı_TextBox.Visible = false;
            if (durum == false)
            {
                panel1.Visible = true;
                durum = true;
            }
            else if (durum == true)
            {
                panel1.Visible = false;
                durum = false;
            }
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            else if (panel1.Visible == false)
                panel1.Visible = true;
        }

        private void DevamBtn_Click(object sender, EventArgs e)
        {
            
            if (GidisYeriCombobox.Text == "" ||TarihBtn.Text == "Uçuş Takvimi" ||YolcuSayısı_TextBox.Text =="")
            {
                MessageBox.Show("Devam Edebilmek İçin Gerekli Bilgileri Doldurmalısınız!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                if (Tek_Yön_CheckBox.Checked == false && Dönüs_Tarih_Picker.Value < Gidis_Tarih_Picker.Value)
                {
                    MessageBox.Show("Gidiş Tarihi , Dönüş Tarihinden Büyük Olamaz!");
                }
               
                else
                {
                    DateTime gidis = Gidis_Tarih_Picker.Value;
                    DateTime dönüs = Gidis_Tarih_Picker.Value;
                    //  string format = "yyyy-MM-dd HH:mm:ss";
                    Ödeme_Form ÖDMF = new Ödeme_Form();
                    ÖDMF.MdiParent = this.MdiParent;
                    this.Hide();
                    ÖDMF.Show();
                    ÖDMF.KisiSayısıLabel.Text = YolcuSayısı_TextBox.Text;
                    ÖDMF.GidisYerLabel.Text = GidisYeriCombobox.Text;
                    if (Tek_Yön_CheckBox.Checked)
                    {
                        ÖDMF.GidisTarihLabel.Text = Gidis_Tarih_Picker.Text;
                        gidis = Gidis_Tarih_Picker.Value;

                        ÖDMF.GidisTarihLabel.Text = gidis.ToString();
                        ÖDMF.DönüsTarihLabel.Text = SqlDateTime.MinValue.Value.ToString();
                        ÖDMF.DönüsTextLabel.Text = "";
                         ÖDMF.DönüsTarihLabel.Visible = false;
                       ÖDMF.DönüsTextLabel.Visible = false;
                    }
                    else
                    {
                        gidis = Gidis_Tarih_Picker.Value;
                        dönüs = Dönüs_Tarih_Picker.Value;
                        ÖDMF.GidisTarihLabel.Text = gidis.ToString();
                        ÖDMF.DönüsTarihLabel.Text = dönüs.ToString();
                    }
                }
                ConcretePrototype1 p1 = new ConcretePrototype1(GidisYeriCombobox.Text);
                ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
                string data = c1.yer;
            }
        }

        private void PersonelGirisLabel_Click(object sender, EventArgs e)
        {
            PersonelGirisForm PGF = new PersonelGirisForm();
            PGF.Show();
            this.Hide();
        }

        private void YolcuSayısı_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void YolcuSayısı_TextBox_TextChanged(object sender, EventArgs e)
        {
            YolcuSayısıBtn.Text = "Yolcu Sayısı " + " " + YolcuSayısı_TextBox.Text;
        }

        private void Dönüs_Tarih_Picker_ValueChanged(object sender, EventArgs e)
        {
            Dönüs_Tarih_Picker.Format = DateTimePickerFormat.Custom;
            Dönüs_Tarih_Picker.CustomFormat = "dddd dd-MM-yyyy";
            dönüs = Dönüs_Tarih_Picker.Value;
            if (gidis < dönüs)
            {
                TarihBtn.Text = Gidis_Tarih_Picker.Text + "\n" + Dönüs_Tarih_Picker.Text;
            }
            else if (gidis > dönüs)
            {
                TarihBtn.Text = Dönüs_Tarih_Picker.Text + "\n" + Gidis_Tarih_Picker.Text;
            }
        }

        private void Gidis_Tarih_Picker_ValueChanged(object sender, EventArgs e)
        {
            Gidis_Tarih_Picker.Format = DateTimePickerFormat.Custom;
            Gidis_Tarih_Picker.CustomFormat = "dddd dd-MM-yyyy";
            gidis = Gidis_Tarih_Picker.Value;
            if (baslangic == false)
            {
                TarihBtn.Text = Gidis_Tarih_Picker.Text;
            }
            else
                TarihBtn.Text = Gidis_Tarih_Picker.Text + "\n" + Dönüs_Tarih_Picker.Text;

            if (DateTime.Now == Dönüs_Tarih_Picker.Value)
            {
                baslangic = true;
            }
            if (baslangic == true)
            {
                if (gidis < dönüs)
                {
                    TarihBtn.Text = Gidis_Tarih_Picker.Text + "\n" + Dönüs_Tarih_Picker.Text;
                }
                else if (gidis > dönüs)
                {
                    TarihBtn.Text = Dönüs_Tarih_Picker.Text + "\n" + Gidis_Tarih_Picker.Text;
                }
            }
        }

        private void TarihTemizleBtn_Click(object sender, EventArgs e)
        {
            Gidis_Tarih_Picker.ResetText();
            Dönüs_Tarih_Picker.ResetText();

            TarihBtn.Text = "Tarih";
            if (Tek_Yön_CheckBox.Checked)
            {
                Dönüs_Tarih_Picker.Visible = false;
            }
            else if (Tek_Yön_CheckBox.Checked == false)
            {
                Dönüs_Tarih_Picker.Visible = true;
            }
        }

        private void Tek_Yön_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Tek_Yön_CheckBox.Checked)
            {
                Dönüs_Tarih_Picker.ResetText();
                Dönüs_Tarih_Picker.Enabled = false;
                Dönüs_Tarih_Picker.Visible = false;
            }
            else
            {
                Dönüs_Tarih_Picker.Enabled = true;
                Dönüs_Tarih_Picker.Visible = true;
            }
            TarihBtn.Text = Gidis_Tarih_Picker.Text;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        abstract class Prototype

        {
            private string _yer;


            public Prototype(string yer)
            {
                this._yer = yer;
            }



            public string yer
            {
                get { return _yer; }
            }

            public abstract Prototype Clone();
        }


        class ConcretePrototype1 : Prototype

        {
            // Constructor

            public ConcretePrototype1(string yer)
              : base(yer)
            {
            }

            // kopya

            public override Prototype Clone()
            {
                return (Prototype)this.MemberwiseClone();
            }
        }


    }
}
