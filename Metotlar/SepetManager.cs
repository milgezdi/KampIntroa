using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    { 
        // naming concvention 
        // syntax yazım şekli
        public void Ekle(Urun urun)  // () görüyorsan metod çalışıyor
        {
            Console.WriteLine(" Tebrikler. Sepete Eklendi : " +urun.Adi);
             
           
        }

        public void Ekle2(string urunAdi,string aciklama,double fiyat, int stokAdedi)
        {
            Console.WriteLine(" Tebrikler. Sepete Eklendi : " + urunAdi +"  "+ stokAdedi);
        }
    }
}
