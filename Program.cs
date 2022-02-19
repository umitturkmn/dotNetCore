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
            //Söz Dizimi
            // class SinifAdi
            // {
            //      [Erişim Belirleyici] [Veri Tipi] ÖzellikAdi;
            //      [Erişim Belirleyici] [Geri Dönüş Tipi] MetodAdi([Parametre Listesi])
            //      {
            //       // Metot Komutları
            //      }
            // }
           
           //Erişiim Belirleyiciler
           // * Public heryerden erişilir
           // * Private sadece olduğu sınıftan erişilir
           // * Internal kendi bulunduğu projeden erişilir
           // * Protected sadece tanımlandığı sınıfta veya kalıtım alan diğer sınıflarda erişilir

        Calisan calisan1 = new Calisan();
        calisan1.Ad = "Ümit";
        calisan1.Soyad = "Türkmen";
        calisan1.No = 482;
        calisan1.Departman = "İK";
        calisan1.CalisanBilgileri();
        Calisan calisan2 = new Calisan();
        calisan2.Ad = "Mavera";
        calisan2.Soyad = "Türkmen";
        calisan2.No = 4552;
        calisan2.Departman = "Satın Alma";
        calisan2.CalisanBilgileri();

        }   
       
    }
    
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public String Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan adı:{0}",Ad);
            Console.WriteLine("Çalışan soyadı:{0}",Soyad);
            Console.WriteLine("Çalışan No:{0}",No);
            Console.WriteLine("Çalışan Departmanı:{0}",Departman);
        }
    }
    
    

}
    
