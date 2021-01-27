using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.Yasi + "müşterisi eklenmiştir.");
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.Yasi + "müşterisi silinmiştir.");
        }
    }
}
