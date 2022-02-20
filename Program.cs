using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace dotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine(Gunler.Pazar);
             Console.WriteLine((int)Gunler.Cuma);
            
             Console.Write("Hava Kaç Derece?: ");
             int sicak = int.Parse(Console.ReadLine());
             if(sicak <= (int)HavaDurumu.Normal) 
             {
                 Console.WriteLine("Dışarıya çıkmak için biraz daha ısınsın."); 
             }
             else if (sicak>=(int)HavaDurumu.Sicak)
             {
                 Console.WriteLine("Dışarıya çıkmak için sıcak bir gün");
             }
             else if ( sicak>=(int)HavaDurumu.Normal && sicak<(int)HavaDurumu.CokSicak)
                Console.WriteLine("Hadi Dışarı Çıkalım");
        }  

    }  

    enum Gunler
    {
        Pazartesi=1, Salı, Çarşamba, Perşembe, Cuma, Cumartesi, Pazar
    }

    enum HavaDurumu
    {
        Soguk=5,Normal=20,Sicak=25,CokSicak=30
    }
    
}
    
