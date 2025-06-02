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

        protected User(string l, string p, string fn, string ln) 
        {
            login = l;
            password = p;
            balance = 100;
            fName = fn;
            lName = ln;
            limit = 2500.00;
        }


        //Withdraw é sacar
        protected void withdraw(double wdv)
        {
            try
            {
                balance -= wdv;
            }
            catch(FormatException) 
            { 
                balance = balance;
            }
            
        }

        protected void deposit(double amount)
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


        protected void getBalance()
        {

        }

        protected void systemOut()
        {
            
        }

    }
}
