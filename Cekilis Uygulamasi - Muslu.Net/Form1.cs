using System;
using System.Linq;
using System.Windows.Forms;

namespace Cekilis_Uygulamasi___Muslu.Net
{
    public partial class Form1 : Form
    {
        /*
         * Muslu.NET - Muhammet Tayyip MUSLU
         * http://www.muslu.net/?p=618
         * Published at 26 June 2015
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void cek_Click(object sender, EventArgs e)
        {
            try
            {
                bekleBakalim.Visible = true;
                AsilveYedek.Visible = false;
                sadeceAsil.Visible = false;
                logo.Visible = false;
                say.Start();
                
                int satir_sayisi = isimler.Lines.Count();
                int SecimKisiSayisi = int.Parse(kisiSayi.Value.ToString());
                asil1.Items.Clear();
                asil2.Items.Clear();
                yedek.Items.Clear();
                Random rasgele = new Random();
                for (int j = 1; j <= SecimKisiSayisi; j++)
                {
                    int tut = rasgele.Next(0, satir_sayisi);

                    string kont = asil1.FindString(isimler.Lines.GetValue(tut).ToString()).ToString();
                    if (kont == "-1")
                    {
                        asil1.Items.Add(isimler.Lines.GetValue(tut).ToString());
                        asil2.Items.Add(isimler.Lines.GetValue(tut).ToString());
                    }
                    else j--;
                }
                if (yedekler.Checked == true)
                {
                    for (int j = 1; j <= SecimKisiSayisi; j++)
                    {
                        int tut = rasgele.Next(0, satir_sayisi);

                        string kont = asil2.FindString(isimler.Lines.GetValue(tut).ToString()).ToString();
                        if (kont == "-1")
                        {
                            string kont2 = yedek.FindString(isimler.Lines.GetValue(tut).ToString()).ToString();
                            if (kont2 == "-1")
                            {
                                yedek.Items.Add(isimler.Lines.GetValue(tut).ToString());
                            }
                        }
                        else j--;
                    }
                }

            }
            catch (Exception HataYakala)
            {
                MessageBox.Show("Hata: " + HataYakala.Message, "Hata ! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kisiSayi_MouseClick(object sender, MouseEventArgs e)
        {
            kisiSayi.Maximum = isimler.Lines.Count();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AsilveYedek.Visible = false;
            sadeceAsil.Visible = false;
            logo.Visible = true;
        }
        private void kisiSayi_ValueChanged(object sender, EventArgs e)
        {
            kisiSayi.Maximum = isimler.Lines.Count();
        }
        private void say_Tick(object sender, EventArgs e)
        {
            bekleBakalim.Visible = false;
            logo.Visible = false;
            if (yedekler.Checked == true)
            {
                AsilveYedek.Visible = true;
                sadeceAsil.Visible = false;
            }
            else
            {
                AsilveYedek.Visible = false;
                sadeceAsil.Visible = true;
            }
            say.Stop();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.muslu.net");
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.muslu.net/?p=618");
        }
        
    }
}
