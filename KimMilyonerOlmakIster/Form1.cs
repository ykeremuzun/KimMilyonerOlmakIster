using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace KimMilyonerOlmakIster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //ArrayList sayilar = new ArrayList();
        private void label1_Click(object sender, EventArgs e)
        {
            BtnYrdm.Visible = true;
            pbYardim.Visible = true;
            pbResim.Visible = true;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.Green;

        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.MidnightBlue;
        }

        private void label4_Click(object sender, EventArgs e)
        {
           DialogResult cikis= MessageBox.Show("Çıkmak İstediğinizden Eminmisiniz","ÇIKIŞ",MessageBoxButtons.YesNo);
            if (cikis==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.BackColor = Color.Green;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.BackColor = Color.MidnightBlue;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            btnOdul.Visible = true;
            pbOdul.Visible = true;
            
        }

        private void btnOdul_Click(object sender, EventArgs e)
        {
            pbOdul.Visible = false;
            btnOdul.Visible = false;
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.BackColor = Color.Green;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = Color.MidnightBlue;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            oyun yeni = new oyun();
            yeni.Show();
            this.Hide();
        }

        private void label3_MouseLeave_1(object sender, EventArgs e)
        {
            label3.BackColor = Color.MidnightBlue;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.BackColor = Color.Green;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.MidnightBlue;
        }

        private void BtnYrdm_Click(object sender, EventArgs e)
        {
            BtnYrdm.Visible = false;
            pbYardim.Visible = false;
            pbResim.Visible = false;
        }

        private void btnSoruGirisi_Click(object sender, EventArgs e)
        {
            btnSoruGirisi.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            txtDogruCevap.Visible = true;
            label6.Visible = true;
            btnKaydet.Visible = true;
            btnGeri.Visible = true;
            lblCevapa.Visible = true;
            lblCevapb.Visible = true;
            lblCevapc.Visible = true;
            lblCevapd.Visible = true;
            lblGiris.Visible = true;
            txtA.Visible = true;
            txtb.Visible = true;
            txtC.Visible = true;
            txtD.Visible = true;
            txtSoruGiris.Visible = true;
            rbKolay.Visible = true;
            rbOrta.Visible = true;
            rbZor.Visible = true;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            btnSoruGirisi.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            txtDogruCevap.Visible = false;
            label6.Visible = false;
            btnKaydet.Visible = false;
            btnGeri.Visible = false;
            lblCevapa.Visible = false;
            lblCevapb.Visible = false;
            lblCevapc.Visible = false;
            lblCevapd.Visible = false;
            lblGiris.Visible = false;
            txtA.Visible = false;
            txtb.Visible = false;
            txtC.Visible = false;
            txtD.Visible = false;
            txtSoruGiris.Visible = false;
            rbKolay.Visible = false;
            rbOrta.Visible = false;
            rbZor.Visible = false;
            txtSoruGiris.Clear();
            txtD.Clear();
            txtC.Clear();
            txtb.Clear();
            txtA.Clear();
            txtDogruCevap.Clear();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string soru = txtSoruGiris.Text.ToString();
            string cevapa = txtA.Text.ToString();
            string cevapb = txtb.Text.ToString();
            string cevapc = txtC.Text.ToString();
            string cevapd = txtD.Text.ToString();
            string dogruCevap = txtDogruCevap.Text.ToString();
            kaydet basla = new kaydet();
            if (rbKolay.Checked==true)
            {
                basla.kolaySoru(soru);
                basla.kolayCevap(cevapa,cevapb,cevapc,cevapd);
                basla.kolayDCevap(dogruCevap);
            }
            else if (rbOrta.Checked==true)
            {
                basla.ortaSoru(soru);
                basla.ortaCevap(cevapa, cevapb, cevapc, cevapd);
                basla.ortaDCevap(dogruCevap);
            }
            else if (rbZor.Checked==true)
            {
                basla.zorSoru(soru);
                basla.zorCevap(cevapa, cevapb, cevapc, cevapd);
                basla.zorDCevap(dogruCevap);
            }
            else
            {
                MessageBox.Show("Lütfen Seviye Seçiniz");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
   
}
