﻿using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 5;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------------");

            }

            Console.WriteLine("--------METOTLAR----------");
            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(urun2);
            sepetmanager.Ekle(urun1);

            sepetmanager.Ekle2("Armut", "Yeşil armut", 12);
            sepetmanager.Ekle2("Elma", "Yeşil elma", 8);
            sepetmanager.Ekle2("Karpuz", "Ceyhan", 10);


        }
    }
}
