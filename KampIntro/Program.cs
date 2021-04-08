using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string KategoriEtiketi = "kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmısMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }


            if (sistemeGirisYapmısMi == true)
            {
                Console.WriteLine("Kullanıcı Adı Soyadı");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            
        }
    }
}
