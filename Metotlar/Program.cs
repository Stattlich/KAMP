using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] meyveler = new string[] { };

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Product[] urunler = new Product[] {urun1, urun2 };

            foreach (var product in urunler)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("----------Metotlar-----------");

            SepetMaganer sepetMaganer = new SepetMaganer();
            sepetMaganer.Ekle(urun1);
            sepetMaganer.Ekle(urun2);

            sepetMaganer.Ekle2("Armut", "Yeşil armut", 12);
            sepetMaganer.Ekle2("Elma", "Yeşil elma", 12);
            sepetMaganer.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12);
        }

    }
}
