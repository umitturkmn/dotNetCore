﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace dotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikortgen dg = new Dikortgen();
            dg.KisaKenar=13;
            dg.UzunKenar=24;
            Console.WriteLine("Class Alan Hesabı: {0}", dg.AlanHesaplama());

            Dikortgen_Struct dg_struct; //structların bir farkı newlemeden yazılabilmesidir.
            dg_struct.KisaKenar = 34;
            dg_struct.UzunKenar = 44;
            Console.WriteLine("Class Alan Hesabı: {0}", dg_struct.AlanHesaplama());


        
        }  

    }  

    class Dikortgen
    {
        public int KisaKenar;
        public int UzunKenar;

        public long AlanHesaplama()
        {
            return this.KisaKenar * this.UzunKenar;
        }

    }
    struct Dikortgen_Struct
    {
        public int KisaKenar;
        public int UzunKenar;

        public long AlanHesaplama()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }
}
    
