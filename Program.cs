using System;
using System.Linq;

namespace dotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi tanımlama
            string[] renkler = new string[5];
            string[] hayvanlar = {"kedi","köpek","kuş","maymun"};

            int[] dizi;
            dizi = new int [6];

            //Dizilere Değer atama ve Erişim
            renkler[0]="Mavi";
            Console.WriteLine(hayvanlar[3]);
            dizi[3]= 11;

            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Döngülerle dizi kullanımı
            //Klavyeden girilen n sayıda sayının ortalamaları
            Console.Write("Kaç adet sayı gireceksiniz: ");
            int giris = int.Parse(Console.ReadLine());
            int toplam = 0;
            int[] dizi2 = new int [giris]; 
            for (int i = 0; i < giris; i++)
            {
                Console.Write("Sayı Giriniz: ");
                int sayı = int.Parse(Console.ReadLine());
                toplam += sayı;
                dizi2[i] = sayı; 
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Girdiğiniz sayılar: ");
            foreach (var i in dizi2)
            {
                Console.Write(i + "-");
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Toplamı: " + toplam);
            Console.WriteLine("Ortalaması: " + toplam/giris);
        }
    }
}
    
