using System;
using System.Collections.Generic;

namespace TpModul5_2211104016
{
    // Class Penjumlahan untuk menjumlahkan tiga angka
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

    // Class SimpleDataBase untuk menyimpan dan menampilkan data
    class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void AddNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.UtcNow);
        }

        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan pada waktu UTC: {inputDates[i]}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NIM saya 2211104016");
            Console.WriteLine("Penjumlahan tiga input angka dari 2 digit");

            // Menggunakan class Penjumlahan
            Penjumlahan penjumlahan = new Penjumlahan();
            int hasil = penjumlahan.JumlahTigaAngka(22, 11, 16);
            Console.WriteLine("Hasil penjumlahan: " + hasil);

            Console.WriteLine("\nMenyimpan dan menampilkan data dengan SimpleDataBase:");
            // Menggunakan class SimpleDataBase
            SimpleDataBase<int> database = new SimpleDataBase<int>();

            // Menambahkan tiga data dua-digit dari NIM
            database.AddNewData(12);
            database.AddNewData(34);
            database.AddNewData(56);

            // Menampilkan semua data
            database.PrintAllData();

            Console.ReadLine();
        }
    }
}