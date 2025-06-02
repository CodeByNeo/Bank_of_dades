using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Of_Dades___Projeto_2bimestre
{
    internal class GoldUser:User
    {
        public GoldUser(string l, string p, string fn, string ln, double b):base(l,p,fn,ln,b) 
        {
            limit = 5000.00;
        }

        public override void withdraw(double wdv)
        {
            try
            {
                balance -= (wdv * SystemParameters.defaultInterestRate) + wdv;
            }
            catch (FormatException)
            {
                Console.WriteLine("Apenas numeros permitidos, tente novamente");
                balance = balance;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Não pode retirar nada, forneça um valor.");
            }

        }

        public override void deposit(double amount)
        {
            try
            {
                balance += (amount * (SystemParameters.defaultInterestRate/2)) - amount;
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


        public override double getBalance()
        {
            return balance;
        }

        public override void systemOut()
        {
            Environment.Exit(0);
        }

    }
}
