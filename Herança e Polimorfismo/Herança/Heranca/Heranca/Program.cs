using System;
using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Upcasting e Downcasting
            //Account acc = new Account(1001, "Alex", 0.0);
            //BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500);

            ////UPCASTING
            ////Account como ela é uma superclasse ela pode receber qualquer valor de suas subclasses
            //Account acc1 = bacc; 
            //Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            //Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            ////DOWNCASTING
            ////Converte uma superclasse em subclasse
            //BusinessAccount acc4 = (BusinessAccount)acc2;
            //acc4.Loan(100.0);

            //// Não funciona a conversão pois só é possivel converter Account pois ele é uma superclasse, e aqui esta tentando converter de outra subclasse
            ////BusinessAccount acc5 = (BusinessAccount)acc3;  

            //if (acc3 is BusinessAccount)  //fail
            //{
            //    //BusinessAccount acc5 = (BusinessAccount)acc3;
            //    BusinessAccount acc5 = acc3 as BusinessAccount; //Outra forma de fazer o casting com "as"
            //    acc5.Loan(200.0);
            //    Console.WriteLine("Loan!");
            //}

            //if (acc3 is SavingsAccount) //sucess
            //{
            //    //SavingsAccount acc5 = (SavingsAccount)acc3;
            //    SavingsAccount acc5 = acc3 as SavingsAccount;
            //    acc5.UpdateBalance();
            //    Console.WriteLine("Update");
            //}
            #endregion

            #region Sobrepossição, Palavras Virtual, Override e Base
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
            #endregion
        }
    }
}
