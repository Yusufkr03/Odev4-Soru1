// See https://aka.ms/new-console-template for more information

using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System;


namespace odev
{
    class metod
    {
        public static double alan()
        {
            double taban, yukseklik, alan;
            
            Console.WriteLine("Taban uzunluğunu giriniz");
            taban = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Yüksekliği giriniz");
            yukseklik = Convert.ToDouble(Console.ReadLine());
            alan = taban * yukseklik / 2;
            Console.WriteLine("--Üçgenin Alanı--");


            return alan;

        }

        static void Main()
        {
            Console.WriteLine(metod.alan());


        }




    }



}

