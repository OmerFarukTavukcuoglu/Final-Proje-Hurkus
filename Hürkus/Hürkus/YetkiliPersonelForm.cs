using BAL;
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
    public partial class YetkiliPersonelForm : Form
    {
        public YetkiliPersonelForm()
        {
            InitializeComponent();
        }
        public Informations info = new Informations();

        Operations Facade = new Operations();

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Silmek İstediğine Emin Misin?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
           
                foreach (DataGridViewRow drow in dataGridView1.SelectedRows)  //Seçili Satırlar'daki değeri alma
                {
                    int numara = Convert.ToInt32(drow.Cells[0].Value);
                    Facade.MüsteriSil(Convert.ToInt32(numara));
                    MessageBox.Show("Silme İşlemi Başarılı");
                }
                dataGridView1.DataSource = Facade.BilgiGöster(info);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Facade.BilgiGöster(info);
            dataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Bilet_Al_Form BAF = new Bilet_Al_Form();
            BAF.MdiParent = this.MdiParent;
            BAF.Dock = DockStyle.Fill;
            this.Hide();
            BAF.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        public void button3_Click_1(object sender, EventArgs e)
        {
            PersonelGüncellemeForm PGF = new PersonelGüncellemeForm();
            int satir_id = 0;
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)  //Seçili Satırları Silme
            {
                satir_id = Convert.ToInt32(drow.Cells[0].Value);
                PGF.satirid = satir_id;                
            }
            PGF.Show();                     
       }

        private void RaporBtn_Click(object sender, EventArgs e)
        {
            RaporlamaForm RP = new RaporlamaForm();
            RP.Show();
        }
    }
}

