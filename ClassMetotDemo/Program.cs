using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Mehmet";
            musteri1.Soyadi = "Kaya";
            musteri1.Yasi = 33;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Selin";
            musteri2.Soyadi = "Gözüpek";
            musteri2.Yasi = 28;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Kahraman";
            musteri3.Soyadi = "Çalık";
            musteri3.Yasi = 44;

            MusteriManager musteriManager = new MusteriManager();
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            while (true)
            {
                Console.WriteLine("Banka sistemine hoşgeldiniz. Lütfen yapmak istediğiniz işlemi seçiniz : ");
                Console.WriteLine("1- Müşteri kaydı ekleme");
                Console.WriteLine("2-Müşteri  kaydı silme");
                Console.WriteLine("3-Müşterileri listeleme");
                Console.WriteLine("4-Çıkış");
                string islem = Console.ReadLine().ToString();

                if (islem == "1")
                {
                    musteriManager.MusteriEkle(musteri1);
                    Console.WriteLine("-------------------------------------");
                    musteriManager.MusteriEkle(musteri2);
                    Console.WriteLine("-------------------------------------");
                    musteriManager.MusteriEkle(musteri3);
                    Console.WriteLine("-------------------------------------");
                }
                else if (islem == "2")
                {
                    musteriManager.MusteriSil(musteri2);
                    Console.WriteLine("-------------------------------------");
                    musteriManager.MusteriSil(musteri1);
                    Console.WriteLine("-------------------------------------");
                }
                else if (islem == "3")
                {
                    foreach (var musteri in musteriler)
                    {
                        Console.WriteLine(musteri.Id);
                        Console.WriteLine(musteri.Adi);
                        Console.WriteLine(musteri.Soyadi);
                        Console.WriteLine(musteri.Yasi);
                        Console.WriteLine("------------------------------");
                    }
                    Console.WriteLine("Tüm müşteriler listelenmiştir.");
                }
                else if (islem == "4")
                {
                    break;
                }
            }
        }
    }
}
