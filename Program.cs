﻿using System;
using System.Linq;

namespace dotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            //1 den başlayarak consoldan girilen sayıya kadar ortolama yazdıran kod
            Console.Write("Sayı Giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam= 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            double ortolama = toplam / sayi;
            Console.WriteLine("Sayıların toplamı: " + toplam);
            Console.WriteLine("Sayıların Ortalaması: " + ortolama);


            Console.WriteLine("-------------------------------");
            //a dan z ye kadar tüm harfleri konsola yazdır.
            char character = 'a';
            while (character < 'z')
            {
                Console.Write(character + " ");    
                character++;
                
            }
            Console.WriteLine("-------------------------------");
            //Foreach
            string[] arabalar = {"Bmw","Ford","Toyota", "Nissan"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }




        }
    }
}
    
