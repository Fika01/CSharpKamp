using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlama Başlangıç için tele Kurs";
            string kurs3 = "Java";


            //array dizi
            string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kampı",
                "Programlama Başlangıç için tele Kurs", 
                "Java" ,
                "Python"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu");
        }
    }
}
