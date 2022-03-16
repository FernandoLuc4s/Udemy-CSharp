using System;
using UpcastingEDownscasting.Entities;

namespace UpcastingEDownscasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);

            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //  UPCASTING = CONVERSÃO DE SUBCLASSE PARA SUPERCLASSE  

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

            // DOWNCASTIGN = CONVERSÃO DA SUPERCLASSE PARA SUBCLASSE

            BusinessAccount acc4 = (BusinessAccount)acc2; // casting conversão
            acc4.Loan(100.0);

            // BusinessAccount acc5 = (BusinessAccount)acc3;
            if (acc3 is BusinessAccount) { // se a variavel fou uma conversão de Business account
                                           //   BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount; // outra fosma de fazer o casting
                acc5.Loan(200.0);
                Console.WriteLine("Loan");
            }
            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update");
            }
        }
    }
}
