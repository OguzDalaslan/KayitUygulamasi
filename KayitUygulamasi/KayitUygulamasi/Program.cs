using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KayitUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // || veya Demek Biri sağlanırsa if bloguna girer , adres=="" boş mu bırakıldı demek
            string ad, soyad, adres, ogrencino;
            Console.WriteLine("Adınızı Giriniz:");
            ad=Console.ReadLine();
            Console.WriteLine("Soyadınızı Giriniz:");
            soyad=Console.ReadLine();
            Console.WriteLine("Adresinizi Giriniz:");
            adres=Console.ReadLine();
            Console.WriteLine("Ögrenci Numaranızı Giriniz");
            ogrencino=Console.ReadLine();
            if (ad == "" || soyad == "" || adres == "" || soyad == "")
                Console.WriteLine("Bilgiler eksik girildi");
            else
                Console.WriteLine("Giriş başaralı");
            Console.ReadKey();
        }
    }
}
