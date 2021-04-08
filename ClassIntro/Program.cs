using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
         //   bool boolHavaDurumu = true;
         //   string havaDurumu = boolHavaDurumu ? "Yağmurlu, Şemsiyenizi alın.." : "Güneşli, Gözlüğünüzü alın..";
         //   Console.WriteLine(havaDurumu);


            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Eğitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 100;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Eğitmen = "Ahmet Tanrıkulu";
            kurs2.IzlenmeOrani = 1000;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = ".NET";
            kurs3.Eğitmen = "Gülçin Ersöz";
            kurs3.IzlenmeOrani = 400;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "PHP";
            kurs4.Eğitmen = "Alex De Souza";
            kurs4.IzlenmeOrani = 1200;

            //  Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Eğitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Eğitmen);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Eğitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
