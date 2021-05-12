using System;

namespace TransactionApp.Classes
{
    public class Transaction
    {
        public void Atm(int pin, int customerPin)
        {
            if (customerPin == pin)
            {
                Console.WriteLine("Press 1 for Withdrawer, or 2 for Transfer, 3 to buy Airtime");
                var transactionType = Console.ReadLine();
                if (transactionType == "1")
                {
                    Console.WriteLine("Enter Amount to withdraw");
                    var amountToWithdraw = decimal.Parse(Console.ReadLine());
                    Console.WriteLine($"Please take your cash and comfirm it is {amountToWithdraw}");
                }
                else if (transactionType == "2")
                {
                    Console.WriteLine("Enter Amount to Transfer");
                    var amountToTransfer = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Account Number");
                    var accountNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Account Name");
                    var accountName = Console.ReadLine();
                    Console.WriteLine($"The transfer of {amountToTransfer} to {accountName} with account name of {accountName} was successful");
                }
                else if (transactionType == "3")
                {
                    Console.WriteLine("Enter Amount to recharge");
                    var rechargeAmount = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Phone Number");
                    var phoneNumber = Console.ReadLine();
                    Console.WriteLine($"Your Reacharge of {rechargeAmount} to phone number {phoneNumber} was successful");
                }
                else
                {
                    Console.WriteLine("We cannot Process your request");
                }
            }
            else
            {
                Console.WriteLine("You have entered a wrong pin");
            }

        }
    }
}
    