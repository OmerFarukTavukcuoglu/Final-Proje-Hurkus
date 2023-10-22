namespace Hürkus
{
    partial class PersonelGüncellemeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelGüncellemeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.AdresRichText = new System.Windows.Forms.RichTextBox();
            this.MüsteriEpostaTextBox = new System.Windows.Forms.TextBox();
            this.MüsteriTelTextBox = new System.Windows.Forms.TextBox();
            this.MüsteriTCtextBox = new System.Windows.Forms.TextBox();
            this.MüsteriSoyadTextBox = new System.Windows.Forms.TextBox();
            this.MüsteriAdTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GüncelleBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Hürkus.Properties.Resources.YetkiliPersonel_arka_planı1;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.GüncelleBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.AdresRichText);
            this.panel1.Controls.Add(this.MüsteriEpostaTextBox);
            this.panel1.Controls.Add(this.MüsteriTelTextBox);
            this.panel1.Controls.Add(this.MüsteriTCtextBox);
            this.panel1.Controls.Add(this.MüsteriSoyadTextBox);
            this.panel1.Controls.Add(this.MüsteriAdTextBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 500);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(192, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 100;
            this.label5.Text = "İkametgah Adresi";
            // 
            // AdresRichText
            // 
            this.AdresRichText.Location = new System.Drawing.Point(341, 215);
            this.AdresRichText.Name = "AdresRichText";
            this.AdresRichText.Size = new System.Drawing.Size(302, 96);
            this.AdresRichText.TabIndex = 5;
            this.AdresRichText.Text = "";
            // 
            // MüsteriEpostaTextBox
            // 
            this.MüsteriEpostaTextBox.Location = new System.Drawing.Point(175, 226);
            this.MüsteriEpostaTextBox.Name = "MüsteriEpostaTextBox";
            this.MüsteriEpostaTextBox.Size = new System.Drawing.Size(145, 20);
            this.MüsteriEpostaTextBox.TabIndex = 4;
            // 
            // MüsteriTelTextBox
            // 
            this.MüsteriTelTextBox.Location = new System.Drawing.Point(498, 174);
            this.MüsteriTelTextBox.Name = "MüsteriTelTextBox";
            this.MüsteriTelTextBox.Size = new System.Drawing.Size(145, 20);
            this.MüsteriTelTextBox.TabIndex = 3;
            this.MüsteriTelTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MüsteriTelTextBox_KeyPress);
            // 
            // MüsteriTCtextBox
            // 
            this.MüsteriTCtextBox.Location = new System.Drawing.Point(175, 172);
            this.MüsteriTCtextBox.Name = "MüsteriTCtextBox";
            this.MüsteriTCtextBox.Size = new System.Drawing.Size(145, 20);
            this.MüsteriTCtextBox.TabIndex = 2;
            this.MüsteriTCtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MüsteriTCtextBox_KeyPress);
            // 
            // MüsteriSoyadTextBox
            // 
            this.MüsteriSoyadTextBox.Location = new System.Drawing.Point(498, 116);
            this.MüsteriSoyadTextBox.Name = "MüsteriSoyadTextBox";
            this.MüsteriSoyadTextBox.Size = new System.Drawing.Size(145, 20);
            this.MüsteriSoyadTextBox.TabIndex = 1;
            this.MüsteriSoyadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MüsteriSoyadTextBox_KeyPress);
            // 
            // MüsteriAdTextBox
            // 
            this.MüsteriAdTextBox.Location = new System.Drawing.Point(175, 116);
            this.MüsteriAdTextBox.Name = "MüsteriAdTextBox";
            this.MüsteriAdTextBox.Size = new System.Drawing.Size(145, 20);
            this.MüsteriAdTextBox.TabIndex = 0;
            this.MüsteriAdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MüsteriAdTextBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(104, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 85;
            this.label8.Text = "Adınız:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(43, 226);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 20);
            this.label12.TabIndex = 89;
            this.label12.Text = "E-Posta Adresi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(395, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 86;
            this.label9.Text = "Soyadınız:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(349, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 20);
            this.label11.TabIndex = 88;
            this.label11.Text = "Telefon Numarası:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(14, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 20);
            this.label10.TabIndex = 87;
            this.label10.Text = "TC Kimlik Numarası:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(221, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 36);
            this.label1.TabIndex = 101;
            this.label1.Text = "Müşteri Güncelleme Panel";
            // 
            // GüncelleBtn
            // 
            this.GüncelleBtn.BackColor = System.Drawing.Color.Transparent;
            this.GüncelleBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GüncelleBtn.BackgroundImage")));
            this.GüncelleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GüncelleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GüncelleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GüncelleBtn.Location = new System.Drawing.Point(527, 339);
            this.GüncelleBtn.Name = "GüncelleBtn";
            this.GüncelleBtn.Size = new System.Drawing.Size(116, 66);
            this.GüncelleBtn.TabIndex = 6;
            this.GüncelleBtn.Text = "        Güncelle";
            this.GüncelleBtn.UseVisualStyleBackColor = false;
            this.GüncelleBtn.Click += new System.EventHandler(this.GüncelleBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Image = global::Hürkus.Properties.Resources.blue_cross_icon;
            this.label2.Location = new System.Drawing.Point(649, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 39);
            this.label2.TabIndex = 102;
            this.label2.Text = "         ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PersonelGüncellemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonelGüncellemeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelGüncellemeForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox MüsteriEpostaTextBox;
        public System.Windows.Forms.TextBox MüsteriTelTextBox;
        public System.Windows.Forms.TextBox MüsteriTCtextBox;
        public System.Windows.Forms.TextBox MüsteriSoyadTextBox;
        public System.Windows.Forms.TextBox MüsteriAdTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.RichTextBox AdresRichText;
        private System.Windows.Forms.Button GüncelleBtn;
        private System.Windows.Forms.Label label2;
    }
}