using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi : "+urun.Adi);
        }

        public void Ekle2(string urunadi, string aciklama, double fiyati)
        {
            Console.WriteLine("Sepete Eklendi : "+urunadi);
        }
    }
}
