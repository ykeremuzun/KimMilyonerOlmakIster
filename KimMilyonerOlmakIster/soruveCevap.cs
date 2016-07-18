using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace KimMilyonerOlmakIster
{
    class soruveCevap
    {
       // public int sayac =0;
       public ArrayList dsoru14 = new ArrayList();
        public ArrayList dcevap14 = new ArrayList();
        public ArrayList dogrucevap14 = new ArrayList();
        public void Soru14()
        { 
           
            string goruntule;
            FileStream getir14 = new FileStream("sorular14.txt",FileMode.Open);
            StreamReader okuma14 = new StreamReader(getir14, Encoding.GetEncoding("windows-1254"));
            while ((goruntule = okuma14.ReadLine()) != null)
            {
               // sayac++;
                dsoru14.Add(goruntule);
                
            }
            okuma14.Close();
        }
        public void cevap14()
        {
            string goruntule;
            FileStream getir14 = new FileStream("cevaplar14.txt", FileMode.Open);
            StreamReader okuma14 = new StreamReader(getir14, Encoding.GetEncoding("windows-1254"));
            while ((goruntule = okuma14.ReadLine()) != null)
            {
                dcevap14.Add(goruntule);

            }
            okuma14.Close();
        }
        public void CevapKntrl14()
        {
            string goruntule;
            FileStream getir14 = new FileStream("dogrucevaplar14.txt", FileMode.Open);
            StreamReader okuma14 = new StreamReader(getir14, Encoding.GetEncoding("windows-1254"));
            while ((goruntule = okuma14.ReadLine()) != null)
            {
                dogrucevap14.Add(goruntule);

            }
            okuma14.Close();
           
        }

        public ArrayList dsoru58 = new ArrayList();
        public ArrayList dcevap58 = new ArrayList();
        public ArrayList dogrucevap58 = new ArrayList();
        public void Soru58()
        {

            string goruntule;
            FileStream getir58 = new FileStream("sorular58.txt", FileMode.Open);
            StreamReader okuma58 = new StreamReader(getir58, Encoding.GetEncoding("windows-1254"));
            while ((goruntule = okuma58.ReadLine()) != null)
            {
                // sayac++;
                dsoru58.Add(goruntule);

            }
            okuma58.Close();
        }
        public void cevap58()
        {
            string goruntule;
            FileStream getir58 = new FileStream("cevaplar58.txt", FileMode.Open);
            StreamReader okuma58= new StreamReader(getir58, Encoding.GetEncoding("windows-1254"));
            while ((goruntule = okuma58.ReadLine()) != null)
            {
                dcevap58.Add(goruntule);

            }
            okuma58.Close();
        }
        public void CevapKntrl58()
        {
            string goruntule;
            FileStream getir58 = new FileStream("dogrucevaplar58.txt", FileMode.Open);
            StreamReader okuma58 = new StreamReader(getir58, Encoding.GetEncoding("windows-1254"));
            while ((goruntule = okuma58.ReadLine()) != null)
            {
                dogrucevap58.Add(goruntule);

            }
            okuma58.Close();

        }

        public ArrayList dsoru910 = new ArrayList();
        public ArrayList dcevap910 = new ArrayList();
        public ArrayList dogrucevap910 = new ArrayList();
        public void Soru910()
        {

            string goruntule;
            FileStream getir910 = new FileStream("sorular910.txt", FileMode.Open);
            StreamReader okuma910 = new StreamReader(getir910, Encoding.GetEncoding("windows-1254"));
            while ((goruntule = okuma910.ReadLine()) != null)
            {
                // sayac++;
                dsoru910.Add(goruntule);

            }
            okuma910.Close();
        }
        public void cevap910()
        {
            string goruntule;
            FileStream getir910 = new FileStream("cevaplar910.txt", FileMode.Open);
            StreamReader okuma910 = new StreamReader(getir910, Encoding.GetEncoding("windows-1254"));
            while ((goruntule = okuma910.ReadLine()) != null)
            {
                dcevap910.Add(goruntule);

            }
            okuma910.Close();
        }
        public void CevapKntrl910()
        {
            string goruntule;
            FileStream getir910 = new FileStream("dogrucevaplar910.txt", FileMode.Open);
            StreamReader okuma910 = new StreamReader(getir910, Encoding.GetEncoding("windows-1254"));
            while ((goruntule = okuma910.ReadLine()) != null)
            {
                dogrucevap910.Add(goruntule);

            }
            okuma910.Close();

        }



    }
}
