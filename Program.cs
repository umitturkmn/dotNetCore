using System;
using System.Linq;

namespace dotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time <= 18)
            {
                Console.WriteLine("İyi ggünler!");
            } else
            {
                Console.WriteLine("İyi Akşamlar...");
            }


        }
    }
}
    
