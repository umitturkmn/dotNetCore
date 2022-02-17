﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace dotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Koleksiyonlar
            //List<T> class
            //T-> object türündedir.

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(24);
            sayiListesi.Add(4);
            sayiListesi.Add(44);
            sayiListesi.Add(27);
            sayiListesi.Add(52);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mor");
            renkListesi.Add("Sarı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Beyaz");
            
            //Count
            Console.WriteLine(renkListesi.Count); //Eleman sayısını verir.
            Console.WriteLine(sayiListesi.Count);
            
            //Foreach ve list foreach
            foreach (var item in sayiListesi)
            {
                Console.WriteLine(item);
            }
            foreach (var item in renkListesi)
            {
                Console.WriteLine(item);
            }

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi)); //yukaridakinin farklı yazılış şekli.

            //Listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Beyaz");

            //İndexe göre çıkarma
            sayiListesi.RemoveAt(2);
            renkListesi.RemoveAt(1);

            //Liste içerisinde arama yapma
            if(sayiListesi.Contains(10))
            {
                Console.WriteLine("10 bulundu.");
            }
            //Eleman ile indexe erişme
            renkListesi.BinarySearch("Kırmızı"); //var mıy yok mu bulur indeksini getir.

            //Diziyi listeye çevirmeye
            string[] hayvanlar = {"kedi","köpek","kuş"};

            List<string> hayvanListesi = new List<string>(hayvanlar); // bu şekilde dönüştürülür

            //Listeyi temizleme
            hayvanListesi.Clear(); //Listeyi temizler

            //List içerisinde nesne tutmak
            List<KUllanıcılar> kullanıcıListesi = new List<KUllanıcılar>();
            KUllanıcılar kullanıcı1 = new KUllanıcılar();
            KUllanıcılar kullanıcı2 = new KUllanıcılar();
            kullanıcı1.Isim = "Ümit";
            kullanıcı1.Soyisim ="Türkmen";
            kullanıcı1.Yas=25;
            kullanıcıListesi.Add(kullanıcı1);
            kullanıcı1.Isim = "Mavera";
            kullanıcı1.Soyisim ="Türkmen";
            kullanıcı1.Yas=25;
            kullanıcıListesi.Add(kullanıcı2);

            List<KUllanıcılar> yeniListe = new List<KUllanıcılar>();
            yeniListe.Add(new KUllanıcılar(){
                Isim="Ahmet",
                Soyisim="Türkmen",
                Yas=52
            });

            foreach (var kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcının Adı: "+ kullanıcı.Isim);
                Console.WriteLine("Kullanıcının Soyadı: "+ kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcının Yaşı: "+ kullanıcı.Yas);
                Console.WriteLine("---------------------------");
            }

        }   
        public class KUllanıcılar{
            private string isim;
            private string soyisim;
            private int yas;

            public string Isim { get => isim; set => isim = value; }
            public string Soyisim { get => soyisim; set => soyisim = value; }
            public int Yas { get => yas; set => yas = value; }
        }
    }
    
    
    

}
    
