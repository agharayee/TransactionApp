using System;
using TransactionApp.Classes;

namespace TransactionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int pin = 0000;
            Console.WriteLine("Welcome to Precious Bank Atm Machine");
            Console.WriteLine("Please Insert your Atm card");
            Console.WriteLine("Please enter your pin");
            var customerPin = int.Parse(Console.ReadLine());
            
            Transaction transaction = new Transaction();
            transaction.Atm(pin, customerPin);
        }
    }
}
