﻿using System;
using System.Linq;

namespace dotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            //Expression
            switch (month)
            {
                case 1:
                Console.WriteLine("Ocak Ayındasınız.");
                break;
                case 2:
                Console.WriteLine("Şubat Ayındasınız.");
                break;
                case 3:
                Console.WriteLine("Mart Ayındasınız.");
                break;
                case 4:
                Console.WriteLine("Nisan Ayındasınız.");
                break;
                case 5:
                Console.WriteLine("Mayıs Ayındasınız.");
                break;
                case 6:
                Console.WriteLine("Haziran Ayındasınız.");
                break;
                case 7:
                Console.WriteLine("Temmuz Ayındasınız.");
                break;
                case 8:
                Console.WriteLine("Ağustos Ayındasınız.");
                break;
                case 9:
                Console.WriteLine("Eylül Ayındasınız.");
                break;
                case 10:
                Console.WriteLine("Ekim Ayındasınız.");
                break;
                case 11:
                Console.WriteLine("Kasım Ayındasınız.");
                break;
                case 12:
                Console.WriteLine("Aralık Ayındasınız.");
                break;
                default:
                break;
            }

            switch (month)
            {
                case 12:
                case 1: 
                case 2:
                Console.WriteLine("Kış ayındasınız.");
                break;
                default:
                break;
            }
        }
    }
}
    
