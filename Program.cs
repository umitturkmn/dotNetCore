﻿using System;
using System.Linq;

namespace dotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {

            string degisken = " Ümit Türkmenin Malikanesine Hoşgeldiniz...";
            string degisken2 = "Ümit Türkmen Adamdır.";
            //Length
            Console.WriteLine(degisken.Length);
            //Toupper,ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());
            //Concat
            Console.WriteLine(string.Concat(degisken,"Adamsın"));
            //Compare,ComperaTo
            Console.WriteLine(degisken.CompareTo(degisken2));//0,1,-1
            Console.WriteLine(string.Compare(degisken,degisken2,true));
            Console.WriteLine(string.Compare(degisken,degisken2,true));
            //Contains
            Console.WriteLine(degisken.Contains(degisken2));//Bulıursa true döner
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz...")); //Bunla bitiyorsa true
            Console.WriteLine(degisken.StartsWith("Merhaba"));//aynısının laciverti
            //IndexOf
            Console.WriteLine(degisken.IndexOf("Üm")); //Kaçıncı indexte olduğunu bulur
            Console.WriteLine(degisken.LastIndexOf("Başkansın"));//yukarıdakinin tersini yapar
            //Insert
            Console.WriteLine(degisken.Insert(0,"Adamsın"));//ilgili indexten sonra ekleme yapar
            //Padleft,PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30, ' '));//İlgili kadar indexten sonra boşluk veya istenilen karakteri ekler
            //Remove
            Console.WriteLine(degisken.Remove(10));//ilgili indexten sonrasını siler
            Console.WriteLine(degisken.Remove(5,3));//ilgili indexten istenilen kadar index siler
            //Replace
            Console.WriteLine(degisken.Replace("Ümit","Adam"));//içeridekini istemnildiği gibi değiştirir.
            //Split
            Console.WriteLine(degisken.Split(' ')[2]);//Boşluklara göre bir dizi tanımlar ve ilgili indeksi getir.
            //Substring
            Console.WriteLine(degisken.Substring(4));//ilgili indeksten sonrasını getirir.
            Console.WriteLine(degisken.Substring(4,6));//ilgili indeksten diğer indekse kadar getirir.




        }   
    }
    
    
    

}
    
