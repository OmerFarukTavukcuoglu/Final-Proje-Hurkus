namespace Hürkus
{
    partial class Bilet_Al_Form
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.PersonelGirisLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Gidis_Tarih_Picker = new System.Windows.Forms.DateTimePicker();
            this.Tek_Yön_CheckBox = new System.Windows.Forms.CheckBox();
            this.TarihTemizleBtn = new System.Windows.Forms.Button();
            this.Dönüs_Tarih_Picker = new System.Windows.Forms.DateTimePicker();
            this.YolcuSayısı_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.YolcuSayısıBtn = new System.Windows.Forms.Button();
            this.UcusDurumBtn = new System.Windows.Forms.Button();
            this.KalkısYeri = new System.Windows.Forms.Button();
            this.Check_inBtn = new System.Windows.Forms.Button();
            this.GidisYeriCombobox = new System.Windows.Forms.ComboBox();
            this.TarihBtn = new System.Windows.Forms.Button();
            this.BiletAlBtn = new System.Windows.Forms.Button();
            this.DevamBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Hürkus.Properties.Resources._3332;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.PersonelGirisLabel);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.YolcuSayısı_TextBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.YolcuSayısıBtn);
            this.panel2.Controls.Add(this.UcusDurumBtn);
            this.panel2.Controls.Add(this.KalkısYeri);
            this.panel2.Controls.Add(this.Check_inBtn);
            this.panel2.Controls.Add(this.GidisYeriCombobox);
            this.panel2.Controls.Add(this.TarihBtn);
            this.panel2.Controls.Add(this.BiletAlBtn);
            this.panel2.Controls.Add(this.DevamBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1019, 538);
            this.panel2.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Image = global::Hürkus.Properties.Resources.blue_cross_icon;
            this.label5.Location = new System.Drawing.Point(900, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 39);
            this.label5.TabIndex = 53;
            this.label5.Text = "         ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // PersonelGirisLabel
            // 
            this.PersonelGirisLabel.AutoSize = true;
            this.PersonelGirisLabel.BackColor = System.Drawing.Color.Transparent;
            this.PersonelGirisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelGirisLabel.Image = global::Hürkus.Properties.Resources.online_education_teacher_staff_32;
            this.PersonelGirisLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PersonelGirisLabel.Location = new System.Drawing.Point(827, 486);
            this.PersonelGirisLabel.Name = "PersonelGirisLabel";
            this.PersonelGirisLabel.Size = new System.Drawing.Size(170, 26);
            this.PersonelGirisLabel.TabIndex = 52;
            this.PersonelGirisLabel.Text = "       Yetkili Girişi";
            this.PersonelGirisLabel.Click += new System.EventHandler(this.PersonelGirisLabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Gidis_Tarih_Picker);
            this.panel1.Controls.Add(this.Tek_Yön_CheckBox);
            this.panel1.Controls.Add(this.TarihTemizleBtn);
            this.panel1.Controls.Add(this.Dönüs_Tarih_Picker);
            this.panel1.Location = new System.Drawing.Point(259, 414);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 112);
            this.panel1.TabIndex = 51;
            // 
            // Gidis_Tarih_Picker
            // 
            this.Gidis_Tarih_Picker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gidis_Tarih_Picker.Location = new System.Drawing.Point(7, 42);
            this.Gidis_Tarih_Picker.Name = "Gidis_Tarih_Picker";
            this.Gidis_Tarih_Picker.Size = new System.Drawing.Size(200, 20);
            this.Gidis_Tarih_Picker.TabIndex = 0;
            this.Gidis_Tarih_Picker.ValueChanged += new System.EventHandler(this.Gidis_Tarih_Picker_ValueChanged);
            // 
            // Tek_Yön_CheckBox
            // 
            this.Tek_Yön_CheckBox.AutoSize = true;
            this.Tek_Yön_CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tek_Yön_CheckBox.Location = new System.Drawing.Point(7, 9);
            this.Tek_Yön_CheckBox.Name = "Tek_Yön_CheckBox";
            this.Tek_Yön_CheckBox.Size = new System.Drawing.Size(80, 21);
            this.Tek_Yön_CheckBox.TabIndex = 2;
            this.Tek_Yön_CheckBox.Text = "Tek Yön";
            this.Tek_Yön_CheckBox.UseVisualStyleBackColor = true;
            this.Tek_Yön_CheckBox.CheckedChanged += new System.EventHandler(this.Tek_Yön_CheckBox_CheckedChanged);
            // 
            // TarihTemizleBtn
            // 
            this.TarihTemizleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TarihTemizleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TarihTemizleBtn.Location = new System.Drawing.Point(98, 4);
            this.TarihTemizleBtn.Name = "TarihTemizleBtn";
            this.TarihTemizleBtn.Size = new System.Drawing.Size(109, 26);
            this.TarihTemizleBtn.TabIndex = 36;
            this.TarihTemizleBtn.Text = "Tarih Temizle";
            this.TarihTemizleBtn.UseVisualStyleBackColor = true;
            this.TarihTemizleBtn.Click += new System.EventHandler(this.TarihTemizleBtn_Click);
            // 
            // Dönüs_Tarih_Picker
            // 
            this.Dönüs_Tarih_Picker.Location = new System.Drawing.Point(232, 42);
            this.Dönüs_Tarih_Picker.Name = "Dönüs_Tarih_Picker";
            this.Dönüs_Tarih_Picker.Size = new System.Drawing.Size(200, 20);
            this.Dönüs_Tarih_Picker.TabIndex = 1;
            this.Dönüs_Tarih_Picker.ValueChanged += new System.EventHandler(this.Dönüs_Tarih_Picker_ValueChanged);
            // 
            // YolcuSayısı_TextBox
            // 
            this.YolcuSayısı_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YolcuSayısı_TextBox.Location = new System.Drawing.Point(738, 403);
            this.YolcuSayısı_TextBox.Name = "YolcuSayısı_TextBox";
            this.YolcuSayısı_TextBox.Size = new System.Drawing.Size(94, 29);
            this.YolcuSayısı_TextBox.TabIndex = 50;
            this.YolcuSayısı_TextBox.TextChanged += new System.EventHandler(this.YolcuSayısı_TextBox_TextChanged);
            this.YolcuSayısı_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YolcuSayısı_TextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(365, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 31);
            this.label3.TabIndex = 49;
            this.label3.Text = "Nereyi Keşfetmek İstersiniz?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(479, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 36);
            this.label2.TabIndex = 48;
            this.label2.Text = "Merhaba";
            // 
            // YolcuSayısıBtn
            // 
            this.YolcuSayısıBtn.BackColor = System.Drawing.Color.Transparent;
            this.YolcuSayısıBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YolcuSayısıBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YolcuSayısıBtn.ForeColor = System.Drawing.Color.Black;
            this.YolcuSayısıBtn.Image = global::Hürkus.Properties.Resources.Group_Folder_icon;
            this.YolcuSayısıBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.YolcuSayısıBtn.Location = new System.Drawing.Point(738, 328);
            this.YolcuSayısıBtn.Name = "YolcuSayısıBtn";
            this.YolcuSayısıBtn.Size = new System.Drawing.Size(178, 59);
            this.YolcuSayısıBtn.TabIndex = 46;
            this.YolcuSayısıBtn.Text = "Yolcu Sayısı";
            this.YolcuSayısıBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.YolcuSayısıBtn.UseVisualStyleBackColor = false;
            this.YolcuSayısıBtn.Click += new System.EventHandler(this.YolcuSayısıBtn_Click);
            // 
            // UcusDurumBtn
            // 
            this.UcusDurumBtn.BackColor = System.Drawing.Color.Transparent;
            this.UcusDurumBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UcusDurumBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UcusDurumBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UcusDurumBtn.Image = global::Hürkus.Properties.Resources.ticket_booking_48;
            this.UcusDurumBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UcusDurumBtn.Location = new System.Drawing.Point(604, 231);
            this.UcusDurumBtn.Name = "UcusDurumBtn";
            this.UcusDurumBtn.Size = new System.Drawing.Size(168, 73);
            this.UcusDurumBtn.TabIndex = 42;
            this.UcusDurumBtn.Text = "Uçus Durum";
            this.UcusDurumBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UcusDurumBtn.UseVisualStyleBackColor = false;
            this.UcusDurumBtn.Click += new System.EventHandler(this.UcusDurumBtn_Click);
            // 
            // KalkısYeri
            // 
            this.KalkısYeri.BackColor = System.Drawing.Color.Transparent;
            this.KalkısYeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KalkısYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KalkısYeri.ForeColor = System.Drawing.Color.Black;
            this.KalkısYeri.Image = global::Hürkus.Properties.Resources.location_icon;
            this.KalkısYeri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KalkısYeri.Location = new System.Drawing.Point(111, 328);
            this.KalkısYeri.Name = "KalkısYeri";
            this.KalkısYeri.Size = new System.Drawing.Size(168, 59);
            this.KalkısYeri.TabIndex = 43;
            this.KalkısYeri.Text = "İstanbul";
            this.KalkısYeri.UseVisualStyleBackColor = false;
            // 
            // Check_inBtn
            // 
            this.Check_inBtn.BackColor = System.Drawing.Color.Transparent;
            this.Check_inBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Check_inBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Check_inBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Check_inBtn.Image = global::Hürkus.Properties.Resources.registration_reservation_admission_cashier_48;
            this.Check_inBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Check_inBtn.Location = new System.Drawing.Point(382, 231);
            this.Check_inBtn.Name = "Check_inBtn";
            this.Check_inBtn.Size = new System.Drawing.Size(190, 73);
            this.Check_inBtn.TabIndex = 41;
            this.Check_inBtn.Text = "Rezervasyon";
            this.Check_inBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Check_inBtn.UseVisualStyleBackColor = false;
            this.Check_inBtn.Click += new System.EventHandler(this.Check_inBtn_Click);
            // 
            // GidisYeriCombobox
            // 
            this.GidisYeriCombobox.DropDownHeight = 185;
            this.GidisYeriCombobox.DropDownWidth = 150;
            this.GidisYeriCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(120)));
            this.GidisYeriCombobox.FormattingEnabled = true;
            this.GidisYeriCombobox.IntegralHeight = false;
            this.GidisYeriCombobox.ItemHeight = 33;
            this.GidisYeriCombobox.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Ankara",
            "Batman",
            "Bingöl",
            "Bursa",
            "Çanakkale",
            "Denizli",
            "Erzurum",
            "Muğla",
            "Trabzon"});
            this.GidisYeriCombobox.Location = new System.Drawing.Point(300, 346);
            this.GidisYeriCombobox.Name = "GidisYeriCombobox";
            this.GidisYeriCombobox.Size = new System.Drawing.Size(194, 41);
            this.GidisYeriCombobox.TabIndex = 44;
            // 
            // TarihBtn
            // 
            this.TarihBtn.BackColor = System.Drawing.Color.Transparent;
            this.TarihBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TarihBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TarihBtn.ForeColor = System.Drawing.Color.Black;
            this.TarihBtn.Image = global::Hürkus.Properties.Resources.Calendar_icon;
            this.TarihBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TarihBtn.Location = new System.Drawing.Point(516, 327);
            this.TarihBtn.Name = "TarihBtn";
            this.TarihBtn.Size = new System.Drawing.Size(198, 60);
            this.TarihBtn.TabIndex = 45;
            this.TarihBtn.Text = "Uçuş Takvimi";
            this.TarihBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TarihBtn.UseVisualStyleBackColor = false;
            this.TarihBtn.Click += new System.EventHandler(this.TarihBtn_Click);
            // 
            // BiletAlBtn
            // 
            this.BiletAlBtn.BackColor = System.Drawing.Color.Transparent;
            this.BiletAlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BiletAlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BiletAlBtn.ForeColor = System.Drawing.Color.Black;
            this.BiletAlBtn.Image = global::Hürkus.Properties.Resources.free_36_641;
            this.BiletAlBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BiletAlBtn.Location = new System.Drawing.Point(199, 231);
            this.BiletAlBtn.Name = "BiletAlBtn";
            this.BiletAlBtn.Size = new System.Drawing.Size(150, 73);
            this.BiletAlBtn.TabIndex = 40;
            this.BiletAlBtn.Text = "Bilet Al";
            this.BiletAlBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BiletAlBtn.UseVisualStyleBackColor = false;
            // 
            // DevamBtn
            // 
            this.DevamBtn.BackColor = System.Drawing.Color.Transparent;
            this.DevamBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DevamBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DevamBtn.ForeColor = System.Drawing.Color.Black;
            this.DevamBtn.Image = global::Hürkus.Properties.Resources.scroll_right_icon;
            this.DevamBtn.Location = new System.Drawing.Point(927, 323);
            this.DevamBtn.Name = "DevamBtn";
            this.DevamBtn.Size = new System.Drawing.Size(78, 73);
            this.DevamBtn.TabIndex = 47;
            this.DevamBtn.UseVisualStyleBackColor = false;
            this.DevamBtn.Click += new System.EventHandler(this.DevamBtn_Click);
            // 
            // Bilet_Al_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 538);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Bilet_Al_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilet_Al_Form";
            this.Load += new System.EventHandler(this.Bilet_Al_Form_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PersonelGirisLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox Tek_Yön_CheckBox;
        private System.Windows.Forms.Button TarihTemizleBtn;
        private System.Windows.Forms.DateTimePicker Dönüs_Tarih_Picker;
        public System.Windows.Forms.DateTimePicker Gidis_Tarih_Picker;
        public System.Windows.Forms.TextBox YolcuSayısı_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button YolcuSayısıBtn;
        private System.Windows.Forms.Button UcusDurumBtn;
        public System.Windows.Forms.Button KalkısYeri;
        private System.Windows.Forms.Button Check_inBtn;
        public System.Windows.Forms.ComboBox GidisYeriCombobox;
        private System.Windows.Forms.Button TarihBtn;
        private System.Windows.Forms.Button BiletAlBtn;
        private System.Windows.Forms.Button DevamBtn;
    }
}