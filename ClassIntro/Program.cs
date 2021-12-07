using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Mehmet";
            int yas = 45;

            Kurs kurs1 =new Kurs();
            kurs1.KursAdı = "C#";
            kurs1.Egitmeni = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = "Java";
            kurs2.Egitmeni = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdı = "Python";
            kurs3.Egitmeni = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            //Console.WriteLine(kurs1.KursAdı + " : " + kurs1.Egitmeni);
            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdı + " : " + kurs.Egitmeni + " : " + kurs.IzlenmeOrani);
               // Console.WriteLine(kurs.Egitmeni);
            }
            
        }
    }

    class Kurs
    {
        public string KursAdı { get; set; }

        public string Egitmeni { get; set; }

        public int IzlenmeOrani { get; set; }


    }
}
