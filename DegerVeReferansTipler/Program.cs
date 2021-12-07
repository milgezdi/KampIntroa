using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int sayi1 = 10;
            int sayi2 = 30;

            sayi1 = sayi2;

            sayi2 = 65;

            Console.WriteLine(sayi1);


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };

            sayilar1 = sayilar2;
            sayilar2[0] = 999;

            Console.WriteLine(sayilar2[0]);

        }
    }
}

// notlar
/*
 int, decimal,float,double,bool= değer tip
 array,calss,interface = referans tip oldupğunu hatıalr
calışma mantıığı   değer ve referans sitli tanımlar mevcuttur.

stack  Değer tipler                 heap referans tipler
sayi1=10 >30            
sayi2=30 >65       
cevap =30 olacak

stack  Değer tipler                 heap referans tipler
sayilar1                            10,20,30
sa

*/
