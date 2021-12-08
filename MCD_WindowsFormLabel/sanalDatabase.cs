using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_WindowsFormLabel
{
    public class sanalDatabase
    {
        public static List<kullanici> KullaniciTablo = new List<kullanici>();
        static sanalDatabase()
        {
            KullaniciTablo.Add(new kullanici()
            {
                id = 1,
                isim="Emre",
                soyisim ="Gemici",
                kullaniciAdi ="emre.gemici",
                sifre ="1",
                aciklama ="Emre Gemici Kullanıcı Profil Bilgisi"
            });

            KullaniciTablo.Add(new kullanici()
            {
                id = 2,
                isim = "Elif",
                soyisim = "Gemici",
                kullaniciAdi = "elif.gemici",
                sifre = "2",
                aciklama = "Elif Gemici Kullanıcı Profil Bilgisi"
            });
        }
    }
}
