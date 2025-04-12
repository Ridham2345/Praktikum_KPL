using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul8_2211104016
{
    class Program
    {
        static void Main(string[] args)
        {
            string configPath = "bank_transfer_config.json";
            var config = BankTransferConfig.LoadConfig(configPath);

            // Step i
            if (config.lang == "id")
                Console.WriteLine("Masukkan jumlah uang yang akan di-transfer:");
            else
                Console.WriteLine("Please insert the amount of money to transfer:");

            int amount = int.Parse(Console.ReadLine());

            // Step ii
            int fee = amount <= config.transfer.threshold ? config.transfer.low_fee : config.transfer.high_fee;
            int total = amount + fee;

            if (config.lang == "id")
            {
                Console.WriteLine($"Biaya transfer = {fee}");
                Console.WriteLine($"Total biaya = {total}");
            }
            else
            {
                Console.WriteLine($"Transfer fee = {fee}");
                Console.WriteLine($"Total amount = {total}");
            }

            // Step iii
            if (config.lang == "id")
                Console.WriteLine("Pilih metode transfer:");
            else
                Console.WriteLine("Select transfer method:");

            // Step iv
            for (int i = 0; i < config.methods.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {config.methods[i]}");
            }

            Console.ReadLine(); 

            
            if (config.lang == "id")
                Console.WriteLine($"Ketik \"{config.confirmation.id}\" untuk mengkonfirmasi transaksi:");
            else
                Console.WriteLine($"Please type \"{config.confirmation.en}\" to confirm the transaction:");

            string confirmationInput = Console.ReadLine();

            
            bool isConfirmed = (config.lang == "id" && confirmationInput == config.confirmation.id) ||
                               (config.lang == "en" && confirmationInput == config.confirmation.en);

            if (isConfirmed)
            {
                if (config.lang == "id")
                    Console.WriteLine("Proses transfer berhasil");
                else
                    Console.WriteLine("The transfer is completed");
            }
            else
            {
                if (config.lang == "id")
                    Console.WriteLine("Transfer dibatalkan");
                else
                    Console.WriteLine("Transfer is cancelled");
            }
        }
    }
    }