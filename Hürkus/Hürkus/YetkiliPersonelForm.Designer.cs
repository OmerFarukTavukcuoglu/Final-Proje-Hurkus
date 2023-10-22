namespace Hürkus
{
    partial class YetkiliPersonelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YetkiliPersonelForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.GüncelleBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.GösterBtn = new System.Windows.Forms.Button();
            this.SilBtn = new System.Windows.Forms.Button();
            this.RaporBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Hürkus.Properties.Resources.YetkiliPersonel_arka_planı;
            this.panel1.Controls.Add(this.RaporBtn);
            this.panel1.Controls.Add(this.GüncelleBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.GösterBtn);
            this.panel1.Controls.Add(this.SilBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 522);
            this.panel1.TabIndex = 35;
            // 
            // GüncelleBtn
            // 
            this.GüncelleBtn.BackColor = System.Drawing.Color.Transparent;
            this.GüncelleBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GüncelleBtn.BackgroundImage")));
            this.GüncelleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GüncelleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GüncelleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GüncelleBtn.Location = new System.Drawing.Point(884, 376);
            this.GüncelleBtn.Name = "GüncelleBtn";
            this.GüncelleBtn.Size = new System.Drawing.Size(116, 66);
            this.GüncelleBtn.TabIndex = 2;
            this.GüncelleBtn.Text = "        Güncelle";
            this.GüncelleBtn.UseVisualStyleBackColor = false;
            this.GüncelleBtn.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Image = global::Hürkus.Properties.Resources._626215;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(35, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "  ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(496, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 29);
            this.label2.TabIndex = 33;
            this.label2.Text = "Yolcu Bilgileri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(157, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(843, 286);
            this.dataGridView1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Image = global::Hürkus.Properties.Resources.blue_cross_icon;
            this.label5.Location = new System.Drawing.Point(1067, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 39);
            this.label5.TabIndex = 32;
            this.label5.Text = "    ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // GösterBtn
            // 
            this.GösterBtn.BackColor = System.Drawing.Color.Transparent;
            this.GösterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GösterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GösterBtn.Image = global::Hürkus.Properties.Resources.search_icon1;
            this.GösterBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GösterBtn.Location = new System.Drawing.Point(615, 376);
            this.GösterBtn.Name = "GösterBtn";
            this.GösterBtn.Size = new System.Drawing.Size(116, 66);
            this.GösterBtn.TabIndex = 0;
            this.GösterBtn.Text = "Göster";
            this.GösterBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GösterBtn.UseVisualStyleBackColor = false;
            this.GösterBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // SilBtn
            // 
            this.SilBtn.BackColor = System.Drawing.Color.Transparent;
            this.SilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SilBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SilBtn.Image = global::Hürkus.Properties.Resources.document_delete_icon__1_;
            this.SilBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SilBtn.Location = new System.Drawing.Point(757, 376);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(102, 66);
            this.SilBtn.TabIndex = 1;
            this.SilBtn.Text = "Sil";
            this.SilBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SilBtn.UseVisualStyleBackColor = false;
            this.SilBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // RaporBtn
            // 
            this.RaporBtn.BackColor = System.Drawing.Color.Transparent;
            this.RaporBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RaporBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RaporBtn.Image = ((System.Drawing.Image)(resources.GetObject("RaporBtn.Image")));
            this.RaporBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RaporBtn.Location = new System.Drawing.Point(246, 376);
            this.RaporBtn.Name = "RaporBtn";
            this.RaporBtn.Size = new System.Drawing.Size(194, 66);
            this.RaporBtn.TabIndex = 34;
            this.RaporBtn.Text = "Raporlama Form";
            this.RaporBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RaporBtn.UseVisualStyleBackColor = false;
            this.RaporBtn.Click += new System.EventHandler(this.RaporBtn_Click);
            // 
            // YetkiliPersonelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 522);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "YetkiliPersonelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YetkiliPersonelForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button GösterBtn;
        private System.Windows.Forms.Button SilBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button GüncelleBtn;
        private System.Windows.Forms.Button RaporBtn;
    }
}