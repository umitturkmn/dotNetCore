﻿using System;
using System.Linq;

namespace dotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
        //erisim_belirteci geri_donustipi metod_adı(parametre vs)
        //
            //komutlar
            //return;
        //

        int a = 3;
        int b = 6;
        Console.WriteLine(a+b);

        Console.WriteLine(Topla(45,78));
        Metodlar ornek = new Metodlar();
        ornek.EkranaYazdir("1. Sayıyıyı giriniz: ");
        int x = int.Parse(Console.ReadLine());
        ornek.EkranaYazdir("2. Sayıyıyı giriniz: ");
        int y = int.Parse(Console.ReadLine());
        ornek.EkranaYazdir("Toplamları: " );
        string sonuc = Topla(x,y).ToString();
        ornek.EkranaYazdir(sonuc);
        int sonuc2 = ornek.ArttırVeTopla(x,y);
        ornek.EkranaYazdir(sonuc2.ToString());

        }
        static int Topla(int x, int y)
        {
            return (x+y);

        }
    }
    class Metodlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public int ArttırVeTopla(int x, int y)
        {
            x+=1;
            y+=1;
            return x+y;
        }
    }

}
    
