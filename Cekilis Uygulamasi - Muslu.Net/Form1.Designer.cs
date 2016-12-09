namespace Cekilis_Uygulamasi___Muslu.Net
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.isimler = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kisiSayi = new System.Windows.Forms.NumericUpDown();
            this.yedekler = new System.Windows.Forms.CheckBox();
            this.loading = new System.Windows.Forms.PictureBox();
            this.bekle = new System.Windows.Forms.Label();
            this.cek = new System.Windows.Forms.Button();
            this.asil1 = new System.Windows.Forms.ListBox();
            this.sadeceAsil = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AsilveYedek = new System.Windows.Forms.GroupBox();
            this.yedek = new System.Windows.Forms.ListBox();
            this.asil2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.say = new System.Windows.Forms.Timer(this.components);
            this.bekleBakalim = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kisiSayi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            this.sadeceAsil.SuspendLayout();
            this.AsilveYedek.SuspendLayout();
            this.bekleBakalim.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // isimler
            // 
            this.isimler.Location = new System.Drawing.Point(13, 27);
            this.isimler.Multiline = true;
            this.isimler.Name = "isimler";
            this.isimler.Size = new System.Drawing.Size(210, 299);
            this.isimler.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsimleri Alt Alta Girin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kaç kişi kazanacak ? ";
            // 
            // kisiSayi
            // 
            this.kisiSayi.Location = new System.Drawing.Point(138, 17);
            this.kisiSayi.Name = "kisiSayi";
            this.kisiSayi.Size = new System.Drawing.Size(49, 20);
            this.kisiSayi.TabIndex = 3;
            this.kisiSayi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kisiSayi.ValueChanged += new System.EventHandler(this.kisiSayi_ValueChanged);
            this.kisiSayi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kisiSayi_MouseClick);
            // 
            // yedekler
            // 
            this.yedekler.AutoSize = true;
            this.yedekler.Location = new System.Drawing.Point(14, 54);
            this.yedekler.Name = "yedekler";
            this.yedekler.Size = new System.Drawing.Size(127, 17);
            this.yedekler.TabIndex = 4;
            this.yedekler.Text = "Yedekler seçilsin mi ?";
            this.yedekler.UseVisualStyleBackColor = true;
            // 
            // loading
            // 
            this.loading.Image = ((System.Drawing.Image)(resources.GetObject("loading.Image")));
            this.loading.Location = new System.Drawing.Point(28, 62);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(163, 120);
            this.loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loading.TabIndex = 5;
            this.loading.TabStop = false;
            // 
            // bekle
            // 
            this.bekle.AutoSize = true;
            this.bekle.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bekle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bekle.Location = new System.Drawing.Point(32, 28);
            this.bekle.Name = "bekle";
            this.bekle.Size = new System.Drawing.Size(159, 30);
            this.bekle.TabIndex = 6;
            this.bekle.Text = "Bekleyin...";
            // 
            // cek
            // 
            this.cek.Location = new System.Drawing.Point(147, 44);
            this.cek.Name = "cek";
            this.cek.Size = new System.Drawing.Size(96, 36);
            this.cek.TabIndex = 5;
            this.cek.Text = "Çekiliş Yap";
            this.cek.UseVisualStyleBackColor = true;
            this.cek.Click += new System.EventHandler(this.cek_Click);
            // 
            // asil1
            // 
            this.asil1.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asil1.FormattingEnabled = true;
            this.asil1.ItemHeight = 19;
            this.asil1.Location = new System.Drawing.Point(6, 52);
            this.asil1.Name = "asil1";
            this.asil1.Size = new System.Drawing.Size(300, 156);
            this.asil1.TabIndex = 8;
            // 
            // sadeceAsil
            // 
            this.sadeceAsil.Controls.Add(this.label5);
            this.sadeceAsil.Controls.Add(this.asil1);
            this.sadeceAsil.Location = new System.Drawing.Point(237, 112);
            this.sadeceAsil.Name = "sadeceAsil";
            this.sadeceAsil.Size = new System.Drawing.Size(318, 220);
            this.sadeceAsil.TabIndex = 9;
            this.sadeceAsil.TabStop = false;
            this.sadeceAsil.Text = "Asil Liste";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Chaparral Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(109, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Asil Kişi(ler)";
            // 
            // AsilveYedek
            // 
            this.AsilveYedek.Controls.Add(this.yedek);
            this.AsilveYedek.Controls.Add(this.asil2);
            this.AsilveYedek.Controls.Add(this.label4);
            this.AsilveYedek.Controls.Add(this.label3);
            this.AsilveYedek.Location = new System.Drawing.Point(237, 108);
            this.AsilveYedek.Name = "AsilveYedek";
            this.AsilveYedek.Size = new System.Drawing.Size(324, 218);
            this.AsilveYedek.TabIndex = 9;
            this.AsilveYedek.TabStop = false;
            this.AsilveYedek.Text = "Asil ve Yedek";
            // 
            // yedek
            // 
            this.yedek.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yedek.FormattingEnabled = true;
            this.yedek.ItemHeight = 19;
            this.yedek.Location = new System.Drawing.Point(163, 43);
            this.yedek.Name = "yedek";
            this.yedek.Size = new System.Drawing.Size(147, 156);
            this.yedek.TabIndex = 3;
            // 
            // asil2
            // 
            this.asil2.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asil2.FormattingEnabled = true;
            this.asil2.ItemHeight = 19;
            this.asil2.Location = new System.Drawing.Point(6, 43);
            this.asil2.Name = "asil2";
            this.asil2.Size = new System.Drawing.Size(147, 156);
            this.asil2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Chaparral Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(190, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Yedek Kişi(ler)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Chaparral Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Asil Kişi(ler)";
            // 
            // say
            // 
            this.say.Interval = 2200;
            this.say.Tick += new System.EventHandler(this.say_Tick);
            // 
            // bekleBakalim
            // 
            this.bekleBakalim.Controls.Add(this.loading);
            this.bekleBakalim.Controls.Add(this.bekle);
            this.bekleBakalim.Location = new System.Drawing.Point(283, 123);
            this.bekleBakalim.Name = "bekleBakalim";
            this.bekleBakalim.Size = new System.Drawing.Size(210, 196);
            this.bekleBakalim.TabIndex = 10;
            this.bekleBakalim.TabStop = false;
            this.bekleBakalim.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(223, 332);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(149, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.muslu.net | Tayyip Muslu";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cek);
            this.groupBox1.Controls.Add(this.yedekler);
            this.groupBox1.Controls.Add(this.kisiSayi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(237, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 86);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgiler";
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(283, 164);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(228, 79);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logo.TabIndex = 13;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 354);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.bekleBakalim);
            this.Controls.Add(this.AsilveYedek);
            this.Controls.Add(this.sadeceAsil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.isimler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(584, 393);
            this.MinimumSize = new System.Drawing.Size(584, 393);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muslu Çekiliş v1 | www.muslu.net";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kisiSayi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            this.sadeceAsil.ResumeLayout(false);
            this.sadeceAsil.PerformLayout();
            this.AsilveYedek.ResumeLayout(false);
            this.AsilveYedek.PerformLayout();
            this.bekleBakalim.ResumeLayout(false);
            this.bekleBakalim.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox isimler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown kisiSayi;
        private System.Windows.Forms.CheckBox yedekler;
        private System.Windows.Forms.PictureBox loading;
        private System.Windows.Forms.Label bekle;
        private System.Windows.Forms.Button cek;
        private System.Windows.Forms.ListBox asil1;
        private System.Windows.Forms.GroupBox sadeceAsil;
        private System.Windows.Forms.GroupBox AsilveYedek;
        private System.Windows.Forms.ListBox yedek;
        private System.Windows.Forms.ListBox asil2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer say;
        private System.Windows.Forms.GroupBox bekleBakalim;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox logo;
    }
}

