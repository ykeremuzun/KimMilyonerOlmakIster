using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace KimMilyonerOlmakIster
{
    class kaydet
    {
        Form1 yeni = new Form1();

        public void kolaySoru(string a)
        {
            FileStream KayitIslemi = new FileStream("sorular14.txt",FileMode.Append);
            StreamWriter dosyaYaz = new StreamWriter(KayitIslemi,Encoding.GetEncoding("windows-1254"));
            dosyaYaz.WriteLine(a);
            dosyaYaz.Close() ;
        }
        public void ortaSoru(string a)
        {
            FileStream KayitIslemi2 = new FileStream("sorular58.txt", FileMode.Append);
            StreamWriter dosyaYaz2 = new StreamWriter(KayitIslemi2, Encoding.GetEncoding("windows-1254"));
            dosyaYaz2.WriteLine(a);
            dosyaYaz2.Close();
        }
       public void zorSoru(string a)
        {
            FileStream KayitIslemi3 = new FileStream("sorular910.txt", FileMode.Append);
            StreamWriter dosyaYaz3 = new StreamWriter(KayitIslemi3, Encoding.GetEncoding("windows-1254"));
            dosyaYaz3.WriteLine(a);
            dosyaYaz3.Close();
        }
        public void kolayCevap(string a,string b,string c,string d)
        {
            FileStream KayitIslemiC = new FileStream("cevaplar14.txt", FileMode.Append);
            StreamWriter dosyaYazC = new StreamWriter(KayitIslemiC, Encoding.GetEncoding("windows-1254"));
            dosyaYazC.WriteLine(a);
            dosyaYazC.WriteLine(b);
            dosyaYazC.WriteLine(c);
            dosyaYazC.WriteLine(d);
            dosyaYazC.Close();
        }
        public void ortaCevap(string a, string b, string c, string d)
        {
            FileStream KayitIslemi2c = new FileStream("cevaplar58.txt", FileMode.Append);
            StreamWriter dosyaYaz2c = new StreamWriter(KayitIslemi2c, Encoding.GetEncoding("windows-1254"));
            dosyaYaz2c.WriteLine(a);
            dosyaYaz2c.WriteLine(b);
            dosyaYaz2c.WriteLine(c);
            dosyaYaz2c.WriteLine(d);
            dosyaYaz2c.Close();
        }
        public void zorCevap(string a, string b, string c, string d)
        {
            FileStream KayitIslemi3c = new FileStream("cevaplar910.txt", FileMode.Append);
            StreamWriter dosyaYaz3c = new StreamWriter(KayitIslemi3c, Encoding.GetEncoding("windows-1254"));
            dosyaYaz3c.WriteLine(a);
            dosyaYaz3c.WriteLine(b);
            dosyaYaz3c.WriteLine(c);
            dosyaYaz3c.WriteLine(d);
            dosyaYaz3c.Close();
        }
        public void kolayDCevap(string a)
        {
            FileStream KayitIslemiDC = new FileStream("dogrucevaplar14.txt", FileMode.Append);
            StreamWriter dosyaYazDC = new StreamWriter(KayitIslemiDC, Encoding.GetEncoding("windows-1254"));
            dosyaYazDC.WriteLine(a);
            dosyaYazDC.Close();
        }
        public void ortaDCevap(string a)
        {
            FileStream KayitIslemi2dc = new FileStream("dogrucevaplar58.txt", FileMode.Append);
            StreamWriter dosyaYaz2dc = new StreamWriter(KayitIslemi2dc, Encoding.GetEncoding("windows-1254"));
            dosyaYaz2dc.WriteLine(a);
            dosyaYaz2dc.Close();
        }
        public void zorDCevap(string a)
        {
            FileStream KayitIslemi3dc = new FileStream("dogrucevaplar910.txt", FileMode.Append);
            StreamWriter dosyaYaz3dc = new StreamWriter(KayitIslemi3dc, Encoding.GetEncoding("windows-1254"));
            dosyaYaz3dc.WriteLine(a);
            dosyaYaz3dc.Close();
        }
    }
}
