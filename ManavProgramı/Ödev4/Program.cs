using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meyveler = { "{1}Elma", "{2}Armut", "{3}Çilek", "{4}Üzüm", "{5}Muz" };
            decimal[] fiyatlar = { 5m, 10m, 15m, 7.5m, 20m };
            decimal Toplam = 0;
            Console.WriteLine("Lütfen Meyve Seçiniz:");
            
            try
            {
                for(int i=0; i<meyveler.Length; i++)
                {
                    Console.WriteLine(meyveler[i]);
                }
                Console.Write("Lütfen Meyve Seçiniz:");
                int meyvesecim = Convert.ToInt32(Console.ReadLine());
                Console.Write("Kaç Kilogram ALacaksınız..?");
                int kilo = Convert.ToInt32(Console.ReadLine());
                Toplam += (fiyatlar[meyvesecim - 1] * kilo);
                Console.WriteLine("Ödeyeceğiniz miktar:" + Toplam);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadKey();
        }
    }
}
