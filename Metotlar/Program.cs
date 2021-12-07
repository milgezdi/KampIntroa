using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";


            string[] meyveler = new string[] { };
            
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdedi = 100;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.StokAdedi = 50;

            Urun[] urunler = new Urun[] {urun1,urun2 };

            // type safe tip güvenli
            //                    
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine("---------------------------");
            }

            Console.WriteLine("---------------- M E T O D L A R ---------------------");

            //instance - örnek 
            //encapsulation kapsamak olarak tercübe edilir. 
            
            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Deveci", 12,10);
            
            sepetManager.Ekle2("Elma", "Amasya", 12,9);

            sepetManager.Ekle2("karpuz", "Diyarbakır karpuzu", 12,8);


        }
    }
}


// dont repaet yourself ++ kendini tekrar etme  DRY yazdığın code bloğunu farklı sayflarda yazarsanız projelerde kaç sayfada düzeltilmesi gerekecek
// Clean Code Temiz kod 
// BEst Practics En iyi uygulama teknikleri anlatılacak

// sepete ekle kodu