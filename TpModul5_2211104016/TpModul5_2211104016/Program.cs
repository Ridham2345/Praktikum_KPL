using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpModul5_2211104016
{
    class Penjumlahan
    {
        public T JumlahTigaAngka<T>(T a, T b, T c)
        {
            dynamic x = a;
            dynamic y = b;
            dynamic z = c;
            return (T)(x + y + z);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NIM saya 2211104016");
            Console.WriteLine("Penjumlahan tiga input angka dari 2 digit");

            Penjumlahan penjumlahan = new Penjumlahan();
            int hasil = penjumlahan.JumlahTigaAngka(22, 11, 16); 
            Console.WriteLine("Hasil penjumlahan: " + hasil);
            Console.ReadLine();
        }
    }
}