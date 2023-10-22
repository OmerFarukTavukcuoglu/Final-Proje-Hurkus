namespace Hürkus
{
    partial class PersonelGirisForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PerAdTextBox = new System.Windows.Forms.TextBox();
            this.PerSifreTextBox = new System.Windows.Forms.TextBox();
            this.girisBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(109, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(93, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personel Şifre.";
            // 
            // PerAdTextBox
            // 
            this.PerAdTextBox.Location = new System.Drawing.Point(226, 77);
            this.PerAdTextBox.Name = "PerAdTextBox";
            this.PerAdTextBox.Size = new System.Drawing.Size(133, 20);
            this.PerAdTextBox.TabIndex = 2;
            // 
            // PerSifreTextBox
            // 
            this.PerSifreTextBox.Location = new System.Drawing.Point(226, 132);
            this.PerSifreTextBox.Name = "PerSifreTextBox";
            this.PerSifreTextBox.Size = new System.Drawing.Size(133, 20);
            this.PerSifreTextBox.TabIndex = 3;
            this.PerSifreTextBox.UseSystemPasswordChar = true;
            // 
            // girisBtn
            // 
            this.girisBtn.BackColor = System.Drawing.Color.Transparent;
            this.girisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisBtn.Image = global::Hürkus.Properties.Resources.user_info_icon1;
            this.girisBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.girisBtn.Location = new System.Drawing.Point(250, 185);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(109, 59);
            this.girisBtn.TabIndex = 4;
            this.girisBtn.Text = "  GİRİŞ";
            this.girisBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.girisBtn.UseVisualStyleBackColor = false;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Image = global::Hürkus.Properties.Resources.blue_cross_icon;
            this.label5.Location = new System.Drawing.Point(384, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 39);
            this.label5.TabIndex = 38;
            this.label5.Text = "         ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // PersonelGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hürkus.Properties.Resources._3335;
            this.ClientSize = new System.Drawing.Size(503, 325);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.girisBtn);
            this.Controls.Add(this.PerSifreTextBox);
            this.Controls.Add(this.PerAdTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonelGirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelGirisForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PerAdTextBox;
        private System.Windows.Forms.TextBox PerSifreTextBox;
        private System.Windows.Forms.Button girisBtn;
        private System.Windows.Forms.Label label5;
    }
}