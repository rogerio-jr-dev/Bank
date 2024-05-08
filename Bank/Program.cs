using System;
using System.Globalization;
using System.Collections.Generic;
using Bank.Entities;
using Bank.Entities.Excepitions;

namespace bank
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            List<Account> list = new List<Account>();

            try
            {
                Console.WriteLine("Enter account data:");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CI);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CI);
                //Instanciando as variaveis na lista Account
                list.Add(new Account(number, holder, balance, withdrawLimit));
                //Operações de saques
                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CI);

                foreach (Account acc in list)
                {
                    acc.Withdraw(amount);
                    Console.WriteLine("New balance: " + acc.Balance.ToString("F2", CI));
                }
            }
            catch (DomaineExceptions e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error in Format!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



        }
    }
}