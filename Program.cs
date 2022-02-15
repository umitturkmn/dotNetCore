﻿using System;
using System.Linq;

namespace dotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort
            //sırasız liste
            int[] dizi = {23,12,33,44,55,3,7};
            foreach (var i in dizi)
                Console.WriteLine(i);
        //Sıralı Liste
        Console.WriteLine("-----------------------");
        Array.Sort(dizi);
        foreach (var i in dizi)
        {
            Console.Write(i + "-");
        }
        //Clear ilgili indexleri sıfırlar
        Console.WriteLine("-----------------------");
        Array.Clear(dizi,2,2);
        foreach (var i in dizi)
        {
            Console.Write(i + "-");
        }
        Console.WriteLine("-----------------------");
        //Reverse
        Array.Reverse(dizi);
        foreach (var i in dizi)
        {
            Console.Write(i + "-");
        }
        Console.WriteLine("-----------------------");
        //IndexOf
        Console.WriteLine(Array.IndexOf(dizi,23));
        Console.WriteLine("-----------------------");
        //Resize
        Array.Resize<int>(ref dizi,9);
        dizi[8] = 46;
        foreach (var i in dizi)
        {
            Console.Write(i + "-");
        }



        }
    }
}
    
