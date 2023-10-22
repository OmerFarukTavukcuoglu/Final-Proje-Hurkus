using BEL;
using BAL;
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
    public partial class Ödeme_AnaForm : Form
    {
        public Ödeme_AnaForm()
        {
            InitializeComponent();
        }


        public Informations info = new Informations();
        public Operations opr = new Operations();

        Ödeme_Form öf = new Ödeme_Form();

      
        string bilet_kod;

        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());

        }
        public void button1_Click(object sender, EventArgs e)
        {
            if(KartAdTextBox.Text == "" || KartNotxtBox.Text =="" || GüvenlikNoTxtBox.Text =="" ||AyCombobox.Text =="" || YılCombobox.Text=="")
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz!");
            }
            else
            {
                MessageBox.Show("İşlem Başarılı");
                öf = (Ödeme_Form)Application.OpenForms["Ödeme_Form"];
                öf.BiletAlBtn.Text = "İşlemi Tamamla";              
                bilet_kod = RandomString(8);
                öf.BiletKodu.Text = bilet_kod.ToString();
                this.Hide();
            }
        }


        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kapalbl_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void KartNotxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void GüvenlikNoTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
