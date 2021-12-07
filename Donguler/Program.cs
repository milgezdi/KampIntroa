using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programalamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);

            //array -- diziler

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programalamaya başlangıç için temel kurs" ,"Java","Python","c#"};




            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("___________For bitti______");

            //dizlerde kulanılır genel olarak foreach
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}
