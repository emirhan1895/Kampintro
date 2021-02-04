using System;

namespace uygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            Products urun1 = new Products();
            urun1.urunAdi = "iphone5";
            urun1.urunFiyati = 1567;
            urun1.urunPuani = 4;

            Products urun2 = new Products();
            urun2.urunAdi = "iphone5";
            urun2.urunFiyati = 1657;
            urun2.urunPuani = 2;

            Products urun3 = new Products();
            urun3.urunAdi = "iphone5";
            urun3.urunFiyati = 1537;
            urun3.urunPuani = 5;

            Products[] urunler = new Products[] {urun1,urun2,urun3 };
            int i = 0;
            while (i <urunler.Length)
            {
                Console.WriteLine(urunler[i].urunAdi+urunler[i].urunFiyati+urunler[i].urunPuani);
                i++;
            }

        }
    }

    class Products
    {
        public string urunAdi { get; set; }
        public float urunFiyati { get; set; }
        public float urunPuani { get; set; }
    }
}
