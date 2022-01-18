using System;

namespace TurkcellGelecegiYazanlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //indexOf()
            Console.Write("Bir Kelime Giriniz: ");
            string kelimeIndexOf = Console.ReadLine();

            Console.Write("Bir Harf Giriniz: ");
            string harfIndexOf = Console.ReadLine();

            if (kelimeIndexOf.IndexOf(harfIndexOf) < 0)
            {
                Console.WriteLine("Aradığınız Harf '{0}' Girdiğiniz Kelimede Bulunamadı.", harfIndexOf);
            }
            else
            {
                Console.WriteLine("{0} Harf {1}. Indexte", harfIndexOf, kelimeIndexOf.IndexOf(harfIndexOf));
            }

            Console.WriteLine("--------------------------------------------------");

            //Contains()
            Console.Write("Bir Cümle Girniz: ");
            string cumle = Console.ReadLine();

            Console.Write("Bir Kelime Giriniz: ");
            string kelimeConstains = Console.ReadLine();

            if (cumle.Contains(kelimeConstains))
            {
                Console.WriteLine("Cümlenin İçinde '{0}' Kelimesi Geçiyor.", kelimeConstains);
            }
            else
            {
                Console.WriteLine("Cümlenin İçinde '{0}' Kelimesi Geçmiyor.", kelimeConstains);
            }

            Console.WriteLine("--------------------------------------------------");


            //split()
            char[] ayrac = { '/', ' ', ':' };
            Console.Write("GÜN AY YIL Şekilinde Bir Tarih Giriniz: ");
            string tarih = Console.ReadLine();
            string[] tarihDizisi = tarih.Split(ayrac);
            Console.WriteLine("GÜN: {0}, AY: {1}, YIL: {2}", tarihDizisi[0], tarihDizisi[1], tarihDizisi[2]);
        }
    }
}
