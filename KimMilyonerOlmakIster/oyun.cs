using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace KimMilyonerOlmakIster
{
    public partial class oyun : Form
    {
        public oyun()
        {
        
            InitializeComponent();
        }
        int sayi;
        int odul = 0;
        int sure = 30;
        int soruSayisi=1;
        int Gpara = 0;
        Form1 ne = new Form1();
        ArrayList sayilar = new ArrayList();
        ArrayList sayilar1 = new ArrayList();
        ArrayList sayilar2 = new ArrayList();
        SoundPlayer muzik = new SoundPlayer();
        private void oyun_Load(object sender, EventArgs e)
        {
            lbla.Visible = true;
            lblb.Visible = true;
            lblc.Visible = true;
            lbld.Visible = true;
            if (soruSayisi == 1)
            {
                btnCekil.Visible = false;
            }
            else
            {
                btnCekil.Visible = true;
            }
            paraSkala();
            string yer = Application.StartupPath + "\\Who.wav";
            muzik.SoundLocation = yer;
            muzik.Play();
            if (soruSayisi == 1 || soruSayisi == 2 || soruSayisi == 3 || soruSayisi == 4)
                Soru14();
            else if (soruSayisi == 5 || soruSayisi == 6 || soruSayisi == 7 || soruSayisi == 8)
                soru58();
            else if (soruSayisi == 9 || soruSayisi == 10 || soruSayisi == 11 || soruSayisi == 12 || soruSayisi == 13 || soruSayisi == 14 || soruSayisi == 15)
                soru910();
            else if (soruSayisi==16)
            {
                MessageBox.Show("Tekbirkler Bütün Soruları Bildiniz\nÖdülünüz: 1 Milyon TL");
            }   
        }

        private void lbla_Click(object sender, EventArgs e)
        {
            muzik.Stop();
            timer1.Stop();
            sure = 30; 
            Kontrol(lbla.Text.ToString());
            Garantipara(soruSayisi);
            oyun_Load(sender, e);
        }

        private void lblb_Click(object sender, EventArgs e)
        {
            muzik.Stop();
            timer1.Stop();
            sure = 30;
            Kontrol(lblb.Text.ToString());
            Garantipara(soruSayisi);
            oyun_Load(sender, e);
        }

        private void lblc_Click(object sender, EventArgs e)
        {
            muzik.Stop();
            timer1.Stop();
            sure = 30;
            Kontrol(lblc.Text.ToString());
            Garantipara(soruSayisi);
            oyun_Load(sender, e);
        }

        private void lbld_Click(object sender, EventArgs e)
        {
            muzik.Stop();
            timer1.Stop();
            sure = 30;
            Kontrol(lbld.Text.ToString());
            Garantipara(soruSayisi);
            oyun_Load(sender, e);
        }
        private void btnCekil_Click(object sender, EventArgs e)
        {
           
            geriCekilmeOdulu(soruSayisi);
            Geri();
           
        }
        public void Kontrol(string cevap)
        {
           
            soruveCevap kntrl = new soruveCevap();
            kntrl.CevapKntrl14();
            kntrl.CevapKntrl14();
            kntrl.CevapKntrl58();
            kntrl.CevapKntrl910();
            if (soruSayisi == 1 || soruSayisi == 2 || soruSayisi == 3 || soruSayisi == 4)
            {
                if (kntrl.dogrucevap14[sayi].ToString() == cevap)
                {
                    
                    MessageBox.Show("Tebikler Doğru Cevapladınız");
                    soruSayisi++;
                    
                }
                else
                    kaybetme(kntrl.dogrucevap14[sayi].ToString());
            }
            else if (soruSayisi == 5 || soruSayisi == 6 || soruSayisi == 7 || soruSayisi == 8)
            {
                if (kntrl.dogrucevap58[sayi].ToString() == cevap)
                {
                    MessageBox.Show("Tebikler Doğru Cevapladınız");
                    soruSayisi++;
                }
                else
                    kaybetme(kntrl.dogrucevap58[sayi].ToString());
            }
            else if (soruSayisi == 9 || soruSayisi == 10 || soruSayisi == 11 || soruSayisi == 12 || soruSayisi == 13 || soruSayisi == 14 || soruSayisi == 15)
            {
                if (kntrl.dogrucevap910[sayi].ToString() == cevap)
                {
                    MessageBox.Show("Tebikler Doğru Cevapladınız");
                    soruSayisi++;
                }
                else
                    kaybetme(kntrl.dogrucevap910[sayi].ToString());
            }
           
            
        }
        public void kaybetme(object dizi)
        {
            soruveCevap kntrl = new soruveCevap();
            kntrl.CevapKntrl14();
            kntrl.CevapKntrl58();
            kntrl.CevapKntrl910();
            DialogResult = MessageBox.Show("Yalnış Cevapladınız "+"\nDoğru Cevap: "+dizi +"\nÖdül: "+ Gpara + " TL\n Yeni Oyun Oynamak İstermisiniz?", "KAYBETTİNİZ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                timer1.Stop();
                odul = 0;
                sure = 30;
                soruSayisi = 1;
                this.Close();
               
                ne.Visible = true;
             
            }
            else
            {
                Application.Exit();
            }

        }
     private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            lblSure.Text = sure.ToString();
            if (sure == 0)
            {
             
                DialogResult =   MessageBox.Show("Süreniz Doldu Odülünüz: "+odul+" TL\n Yeni Oyun Oynamak İstermisiniz?","KAYBETTİNİZ",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (DialogResult==System.Windows.Forms.DialogResult.Yes)
                {
                    odul = 0;
                    sure = 5;
                    soruSayisi = 1;
                    timer1.Stop();
              
                    oyun_Load(sender, e);

                }
                else
                {
                    Application.Exit();
                }
                
            }
        }
        public void Soru14()
        {

            timer1.Start();
            Random rnd = new Random();
            soruveCevap olustur = new soruveCevap();
            olustur.Soru14();
        don:
            sayi = rnd.Next(0, olustur.dsoru14.Count-1);
            foreach (int sayil in sayilar)
            {
                if (sayil == sayi)
                {
                    goto don;
                }
            }
            sayilar.Add(sayi);
            olustur.cevap14();
            richTextBox1.Text = olustur.dsoru14[sayi].ToString();
            lbla.Text = olustur.dcevap14[(sayi * 4)].ToString();
            lblb.Text = olustur.dcevap14[(sayi * 4) + 1].ToString();
            lblc.Text = olustur.dcevap14[(sayi * 4) + 2].ToString();
            lbld.Text = olustur.dcevap14[(sayi * 4) + 3].ToString();
        }
        public void soru58()
        {

            lblSure.Text = "------";
            Random rnd = new Random();
            soruveCevap olustur = new soruveCevap();
            olustur.Soru58();
        don:
            sayi = rnd.Next(0, olustur.dsoru58.Count-1);
            foreach (int sayil in sayilar1)
            {
                if (sayil == sayi)
                {
                    goto don;
                }
            }
            sayilar1.Add(sayi);
            olustur.cevap58();
            richTextBox1.Text = olustur.dsoru58[sayi].ToString();
            lbla.Text = olustur.dcevap58[(sayi * 4)].ToString();
            lblb.Text = olustur.dcevap58[(sayi * 4) + 1].ToString();
            lblc.Text = olustur.dcevap58[(sayi * 4) + 2].ToString();
            lbld.Text = olustur.dcevap58[(sayi * 4) + 3].ToString();
        }
        public void soru910()
        {
            
            Random rnd = new Random();
            soruveCevap olustur = new soruveCevap();
            olustur.Soru910();
        don:
            sayi = rnd.Next(0, olustur.dsoru910.Count-1);
            foreach (int sayil in sayilar2)
            {
                if (sayil == sayi)
                {
                    goto don;
                }
            }
            sayilar2.Add(sayi);
            olustur.cevap910();
            richTextBox1.Text = olustur.dsoru910[sayi].ToString();
            lbla.Text = olustur.dcevap910[(sayi * 4)].ToString();
            lblb.Text = olustur.dcevap910[(sayi * 4) + 1].ToString();
            lblc.Text = olustur.dcevap910[(sayi * 4) + 2].ToString();
            lbld.Text = olustur.dcevap910[(sayi * 4) + 3].ToString();
        }
        public void paraSkala()
        {
            switch (soruSayisi)
            {
                case 1:lbl100.BackColor = Color.Yellow; break;
                case 2: lbl100.BackColor = Color.Green;
                    lbl200.BackColor = Color.Yellow; break;
                case 3: lbl300.BackColor = Color.Yellow;
                    lbl200.BackColor = Color.Green; break;
                case 4: lbl500.BackColor = Color.Yellow;
                    lbl300.BackColor = Color.Green; break;
                case 5: lbl1K.BackColor = Color.Yellow;
                    lbl500.BackColor = Color.Green; break;
                case 6: label2K.BackColor = Color.Yellow;
                    lbl1K.BackColor = Color.Green; break;
                case 7:lbl4K.BackColor = Color.Yellow;
                    label2K.BackColor = Color.Green; break;
                case 8: lbl8K.BackColor = Color.Yellow;
                    lbl4K.BackColor = Color.Green; break; 
                case 9: lbl8K.BackColor = Color.Green;
                    lbl16K.BackColor = Color.Yellow; break;
                case 10:lbl32k.BackColor = Color.Yellow;
                    lbl16K.BackColor = Color.Green; break;
                case 11:lbl64K.BackColor = Color.Yellow;
                    lbl32k.BackColor = Color.Green; break;
                case 12: lbl125K.BackColor = Color.Yellow;
                    lbl64K.BackColor = Color.Green; break;
                case 13: lbl250K.BackColor = Color.Yellow;
                    lbl125K.BackColor = Color.Green; break;
                case 14:lbl500K.BackColor = Color.Yellow;
                    lbl250K.BackColor = Color.Green; break;
                case 15:lblMilyon.BackColor = Color.Yellow;  break;
            }
        }
        public void Garantipara(int Numara)
        {
            switch (Numara)
            {
                case 1:Gpara = 0; break;
                case 2:Gpara = 100; break;
                case 6:Gpara = 1000; break;
                case 11:Gpara = 32000; break;
                case 14:Gpara = 250000; break;
            }
        }
        public void geriCekilmeOdulu(int numara)
        {
            switch (numara)
            {
                case 1: odul = 0; break;
                case 2: odul = 100; break;
                case 3: odul = 200; break;
                case 4: odul = 300; break; 
                case 5: odul = 500; break;
                case 6: odul = 1000; break;
                case 7: odul = 2000; break;
                case 8: odul = 4000; break;
                case 9: odul = 8000; break;
                case 10: odul = 16000; break;
                case 11: odul = 32000; break;
                case 12: odul = 64000; break;
                case 13: odul = 125000; break;
                case 14: odul = 250000; break;
                case 15: odul = 500000; break;
            }
        }
        public void Geri()
        {
           
            soruveCevap kntrll = new soruveCevap();
            kntrll.CevapKntrl14();
            kntrll.CevapKntrl58();
            kntrll.CevapKntrl910();
            DialogResult cekil = MessageBox.Show("Eminmisiniz ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cekil == System.Windows.Forms.DialogResult.Yes)
            {
                DialogResult cekiLl = MessageBox.Show("Son Kararınız mı ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cekiLl == System.Windows.Forms.DialogResult.Yes)
                {
                    if (soruSayisi == 1 || soruSayisi == 2 || soruSayisi == 3 || soruSayisi == 4)
                    {
                        MessageBox.Show("Doğru Cevap: "+ kntrll.dogrucevap14[sayi].ToString() + "\nÖdül: " + odul.ToString() + " TL");
                        timer1.Stop();
                        muzik.Stop();
                        this.Close();
                        ne.Visible = true;
                    }
                    else if (soruSayisi == 5 || soruSayisi == 6 || soruSayisi == 7 || soruSayisi == 8)
                    {
                        MessageBox.Show("Doğru Cevap: " + kntrll.dogrucevap58[sayi].ToString() + "\nÖdül: " + odul.ToString() + " TL"); timer1.Stop();
                        muzik.Stop();
                        this.Close();
                        ne.Visible = true;
                    }
                    else if (soruSayisi == 9 || soruSayisi == 10 || soruSayisi == 11 || soruSayisi == 12 || soruSayisi == 13 || soruSayisi == 14 || soruSayisi == 15)
                    {
                        MessageBox.Show("Doğru Cevap: " + kntrll.dogrucevap910[sayi].ToString()+"\nÖdül: "+odul.ToString()+" TL");
                        timer1.Stop();
                        muzik.Stop();
                        this.Close();
                        ne.Visible = true;
                    }
                }
            }
        }

        private void btnSeyirci_Click(object sender, EventArgs e)
        {
            btntTablo.Visible = true;
            btnSeyirci.Visible = false;
            int denklem = 100;
            chart1.Visible = true;
            Random rnd = new Random();
            int[] bulunanlar = new int[4];
            for (int i = 0; i < 3; i++)
            {
               
                int asd = rnd.Next(0, denklem);
                bulunanlar[i] = asd;
                denklem = denklem - asd;
                if (denklem == 0)
                    break;
            }
            bulunanlar[3] = denklem;
            soruveCevap kntrl = new soruveCevap();
            kntrl.CevapKntrl14();
            kntrl.CevapKntrl58();
            kntrl.CevapKntrl910();
            kntrl.cevap14();
            kntrl.cevap58();
            kntrl.cevap910();
            if (soruSayisi == 1 || soruSayisi == 2 || soruSayisi == 3 || soruSayisi == 4)
            {
              
                chart1.Series.Add(kntrl.dogrucevap14[sayi].ToString()).Points.AddXY("-",100);
            }
            else if (soruSayisi == 5 || soruSayisi == 6 || soruSayisi == 7 || soruSayisi == 8)
            {
                chart1.Series.Add(kntrl.dcevap58[(sayi * 4)].ToString()).Points.AddXY("-", bulunanlar[0]);
                chart1.Series.Add(kntrl.dcevap58[(sayi * 4) + 1].ToString()).Points.AddXY("-", bulunanlar[1]);
                chart1.Series.Add(kntrl.dcevap58[(sayi * 4) + 2].ToString()).Points.AddXY("-", bulunanlar[2]);
                chart1.Series.Add(kntrl.dcevap58[(sayi * 4) + 3].ToString()).Points.AddXY("-", bulunanlar[3]);
            }
            else if (soruSayisi == 9 || soruSayisi == 10 || soruSayisi == 11 || soruSayisi == 12 || soruSayisi == 13 || soruSayisi == 14 || soruSayisi == 15)
            {
                chart1.Series.Add(kntrl.dcevap910[(sayi * 4)].ToString()).Points.AddXY("-", bulunanlar[0]);
                chart1.Series.Add(kntrl.dcevap910[(sayi * 4) + 1].ToString()).Points.AddXY("-", bulunanlar[1]);
                chart1.Series.Add(kntrl.dcevap910[(sayi * 4) + 2].ToString()).Points.AddXY("-", bulunanlar[2]);
                chart1.Series.Add(kntrl.dcevap910[(sayi * 4) + 3].ToString()).Points.AddXY("-", bulunanlar[3]);
            }
        }

        private void btntTablo_Click(object sender, EventArgs e)
        {
            btntTablo.Visible = false;
            chart1.Visible = false;
        }

        private void btnTelefon_Click(object sender, EventArgs e)
        {
            btnTelefon.Visible = false;
            btnIlberCik.Visible = true;
            btnIlber.Visible = true;
            btnPolat.Visible = true;
            btnSokak.Visible = true;
        }

        private void btnYari_Click(object sender, EventArgs e)
        {
           btnYari.Visible = false;
            int sayac = 0;
            soruveCevap kntrl = new soruveCevap();
            kntrl.CevapKntrl14();
            kntrl.CevapKntrl14();
            kntrl.CevapKntrl58();
            kntrl.CevapKntrl910();
            if (soruSayisi == 1 || soruSayisi == 2 || soruSayisi == 3 || soruSayisi == 4)
            {
                if (kntrl.dogrucevap14[sayi].ToString() !=lbla.Text)
                {
                    lbla.Visible = false;
                    sayac++;
                }
                if (kntrl.dogrucevap14[sayi].ToString() != lblb.Text)
                {
                    lblb.Visible = false;
                    sayac++;
                }
                 if (kntrl.dogrucevap14[sayi].ToString() != lblc.Text && sayac<2)
                {
                    lblc.Visible = false;
                    sayac++;
                }
            }
            else if (soruSayisi == 5 || soruSayisi == 6 || soruSayisi == 7 || soruSayisi == 8)
            {
                if (kntrl.dogrucevap58[sayi].ToString() !=lbla.Text)
                {
                    lbla.Visible = false;
                    sayac++;
                }
                if (kntrl.dogrucevap58[sayi].ToString() != lblc.Text)
                {
                    lblc.Visible = false;
                    sayac++;
                }
                if (kntrl.dogrucevap58[sayi].ToString() != lbld.Text && sayac<2)
                {
                    lbld.Visible = false;
                    sayac++;
                }

            }
            else if (soruSayisi == 9 || soruSayisi == 10 || soruSayisi == 11 || soruSayisi == 12 || soruSayisi == 13 || soruSayisi == 14 || soruSayisi == 15)
            {
                if (kntrl.dogrucevap910[sayi].ToString() != lbld.Text)
                {
                    lbld.Visible = false;
                    sayac++;
                }
                if (kntrl.dogrucevap910[sayi].ToString() != lbla.Text)
                {
                    lbla.Visible = false;
                    sayac++;
                }
                if (kntrl.dogrucevap910[sayi].ToString() != lblb.Text && sayac<2)
                {
                    lblb.Visible = false;
                    sayac++;
                }

            }

        }

        private void btnIlber_Click(object sender, EventArgs e)
        {
            btnIlber.Visible = false;
            btnPolat.Visible = false;
            btnSokak.Visible = false;
            soruveCevap kntrl = new soruveCevap();
            kntrl.CevapKntrl14();
            kntrl.CevapKntrl58();
            kntrl.CevapKntrl910();
            pbTelefon.Visible = true;
            rtbTelefon.Visible = true;
            string yer = Application.StartupPath + "\\ilber.jpg";
            pbTelefon.Image = Image.FromFile(yer);
            if (soruSayisi == 1 || soruSayisi == 2 || soruSayisi == 3 || soruSayisi == 4)
            {
                rtbTelefon.Text = "Çok Cahilsin \n Cevap: " +kntrl.dogrucevap14[sayi].ToString();

            }
            else if (soruSayisi == 5 || soruSayisi == 6 || soruSayisi == 7 || soruSayisi == 8)
            {
                rtbTelefon.Text = "Çok Cahilsin \n Cevap: " + kntrl.dogrucevap58[sayi].ToString();
            }
            else if (soruSayisi == 9 || soruSayisi == 10 || soruSayisi == 11 || soruSayisi == 12 || soruSayisi == 13 || soruSayisi == 14 || soruSayisi == 15)
            {
                rtbTelefon.Text = "Çok Cahilsin \n Cevap: " + kntrl.dogrucevap910[sayi].ToString();
            }
           
        }

        private void btnPolat_Click(object sender, EventArgs e)
        {
            btnIlber.Visible = false;
            btnPolat.Visible = false;
            btnSokak.Visible = false;
            Random rnd = new Random();
            int gele = rnd.Next(0,4);
            soruveCevap kntrl = new soruveCevap();
            kntrl.cevap14();
            kntrl.cevap58();
            kntrl.cevap910();
            kntrl.CevapKntrl14();
            kntrl.CevapKntrl58();
            kntrl.CevapKntrl910();
            pbTelefon.Visible = true;
            rtbTelefon.Visible = true;
            string yer = Application.StartupPath + "\\polat.jpg";
            pbTelefon.Image = Image.FromFile(yer);
            if (soruSayisi == 1 || soruSayisi == 2 || soruSayisi == 3 || soruSayisi == 4)
            {
                rtbTelefon.Text = "Kedi Gözleri Gibi Cevabı Veriyorum \n Cevap: " + kntrl.dogrucevap14[sayi].ToString();

            }
            else if (soruSayisi == 5 || soruSayisi == 6 || soruSayisi == 7 || soruSayisi == 8)
            {
                rtbTelefon.Text = "Kedi Gözleri Gibi Cevabı Veriyorum \n Cevap: " + kntrl.dcevap58[(sayi * 4)].ToString();
            }
            else if (soruSayisi == 9 || soruSayisi == 10 || soruSayisi == 11 || soruSayisi == 12 || soruSayisi == 13 || soruSayisi == 14 || soruSayisi == 15)
            {
                rtbTelefon.Text = "Kedi Gözleri Gibi Cevabı Veriyorum \n Cevap: " + kntrl.dcevap910[(sayi*4)+gele].ToString();
            }
        }

        private void btnSokak_Click(object sender, EventArgs e)
        {
            btnIlber.Visible = false;
            btnPolat.Visible = false;
            btnSokak.Visible = false;
            Random rnd = new Random();
            int gele = rnd.Next(0, 4);
            soruveCevap kntrl = new soruveCevap();
            kntrl.cevap14();
            kntrl.cevap58();
            kntrl.cevap910();
            kntrl.CevapKntrl14();
            kntrl.CevapKntrl58();
            kntrl.CevapKntrl910();
            pbTelefon.Visible = true;
            rtbTelefon.Visible = true;
            string yer = Application.StartupPath + "\\sokak.jpg";
            pbTelefon.Image = Image.FromFile(yer);
            if (soruSayisi == 1 || soruSayisi == 2 || soruSayisi == 3 || soruSayisi == 4)
            {
                rtbTelefon.Text = "Ben Sayısalcıyım Ama Tarihide Çok Severim \n Cevap: " + kntrl.dcevap14[(sayi * 4) + gele].ToString();

            }
            else if (soruSayisi == 5 || soruSayisi == 6 || soruSayisi == 7 || soruSayisi == 8)
            {
                rtbTelefon.Text = "Ben Sayısalcıyım Ama Tarihide Çok Severim \n Cevap: " + kntrl.dcevap58[(sayi * 4) + gele].ToString();
            }
            else if (soruSayisi == 9 || soruSayisi == 10 || soruSayisi == 11 || soruSayisi == 12 || soruSayisi == 13 || soruSayisi == 14 || soruSayisi == 15)
            {
                rtbTelefon.Text = "Ben Sayısalcıyım Ama Tarihide Çok Severim \n Cevap: " + kntrl.dcevap910[(sayi * 4) + gele].ToString();
            }
        }

        private void btnIlberCik_Click(object sender, EventArgs e)
        {
            pbTelefon.Visible = false;
            rtbTelefon.Visible = false;
            btnIlberCik.Visible = false;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            DialogResult cık;
            cık = MessageBox.Show("Çıkış Yapmak İstediğinize Eminmisiniz ?","UYARI",MessageBoxButtons.YesNo);
            if (cık==System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                ne.Show();
                muzik.Stop();
                
                
            }
        }
    }

  
    
}
