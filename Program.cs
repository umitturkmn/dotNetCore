﻿using System;
using System.Linq;

namespace dotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
        //out parametreler
        string sayi = "999";
        int outSayi;

        bool sonuc = int.TryParse(sayi,out outSayi);
        if (sonuc == true)
        {
            Console.WriteLine("Başarılı");
            Console.WriteLine(outSayi);
        } 
        else 
            Console.WriteLine("Başarısız.");


        Metodlar instance = new Metodlar();
        instance.Topla(4,5,out int toplamSonucu);
        Console.WriteLine(toplamSonucu);

        //Metot Overloading
        int ifade = 999;
        instance.EkranaYazdir(ifade);


        }   
    }
    class Metodlar
    {








        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public int ArttırVeTopla(int x, int y)
        {
            x+=1;
            y+=1;
            return x+y;
        }
        public void Topla(int x, int y,out int toplam)
        {
           toplam = x+y;

        }
    }

}
    
