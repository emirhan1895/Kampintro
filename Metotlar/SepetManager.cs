using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        // Naming Convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi: " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string Aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Sepete eklendi: " + urunAdi);
        }
    }
}
