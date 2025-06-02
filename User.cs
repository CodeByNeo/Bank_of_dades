using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Of_Dades___Projeto_2bimestre
{
    internal class User
    {
        protected string login;
        protected string password;
        protected double balance;
        protected string fName;
        protected string lName;
        protected double limit;
        protected double accountNum;

        public User(string l, string p, string fn, string ln, double b) 
        {
            login = l;
            password = p;
            balance = b;
            fName = fn;
            lName = ln;
            limit = 2500.00;
        }


        //Withdraw é sacar
        public virtual void withdraw(double wdv)
        {
            try
            {
                balance -= (wdv*SystemParameters.defaultInterestRate)+wdv;
            }
            catch(FormatException) 
            {
                Console.WriteLine("Apenas numeros permitidos, tente novamente");
                balance = balance;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Não pode retirar nada, forneça um valor.");
            }

        }

        public virtual void deposit(double amount)
        {
            try
            {
                balance += (amount * SystemParameters.defaultInterestRate) - amount;
            }
            catch (FormatException) 
            {
                Console.WriteLine("Valor inválido. Tente novamente");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Não pode depositar nada, forneça um valor.");
            }
        }


        public virtual double getBalance()
        {
            return balance;
        }

        public virtual void systemOut()
        {
            Environment.Exit(0);
        }

    }
}
