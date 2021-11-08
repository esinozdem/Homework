using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev2
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "";
            string password = "";
            do
            {
                Console.Write("Lütfen Kullanıcı Adınızı Giriniz:");
                username = Console.ReadLine();
                Console.Write("Lüten Şifreyi Giriniz:");
                password = Console.ReadLine();
                Console.Clear();
            }
            while (username != "admin" || password != "123");
            
                Console.WriteLine("Kullanıcı Adı ve Şifreniz Doğru:..");
                Console.ReadKey();
            


        }
    }
}
