using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Of_Dades___Projeto_2bimestre
{
    internal static class SystemParameters
    {
        public static double defaultInterestRate = 0.05; // 5% de taxa de juros
        public static string wdLimit; // limite de saque
        public static string dpLimit; // limite de depósito
        public static string goldDpLimit;
        public static string goldWdLimit;
        public static double defaultLoanRate = 0.10; // 10% de taxa de juros para empréstimos
        public static double defaultOverdraftLimit = 1000.00; // Limite de cheque especial
        public static double serviceCharge = 2.50; // Taxa de serviço por transação
        public static int LimitPasswordAttempts = 3; // Tentativas de senha antes de bloquear a conta
        public static double minimalInitialDeposit = 50.00; // Depósito inicial mínimo para abrir uma conta
        public static double goldCashbackRate = 0.02; // 2% de cashback para clientes Gold
        public static double platinumCashbackRate = 0.03; // 3% de cashback para clientes Platinum
        public static string systemVersion = "1.0.0"; // Versão do sistema
        public static bool systemStatus = true; //true= active, false= inactive

        public static void showVersion()
        {
            Console.WriteLine($"Versão do sistema: {systemVersion}");
        }
        
        public static void showParameters()
        {
            Console.WriteLine($"Taxa de juros padrão: {defaultInterestRate}");
            Console.WriteLine($"Taxa de juros para empréstimos: {defaultLoanRate}");
            Console.WriteLine($"Limite de cheque especial: {defaultOverdraftLimit}");
            Console.WriteLine($"Depósito inicial mínimo: {minimalInitialDeposit}");
            Console.WriteLine($"´Limite de tentativas de senha: {LimitPasswordAttempts}");
            Console.WriteLine($"Cashback para clientes Gold: {goldCashbackRate}");
            Console.WriteLine($"Cashback para clientes Platinum: {platinumCashbackRate}");
            Console.WriteLine($"Taxa de serviço por transação: {serviceCharge}");
        }

        public static void showSystemInfo()
        {
            Console.WriteLine("Informações do Sistema:");
            showVersion();
            showParameters();
        }

        public static void updateSystemVersion(string newVersion)
        {
            systemVersion = newVersion;
            Console.WriteLine($"Versão do sistema atualizada para: {systemVersion}");
        }

        public static void updateParameter(string parameterName, string newValue)
        {
            try
            {
                switch (parameterName.ToLower())
                {
                    case "interest rate":
                        defaultInterestRate = double.Parse(newValue);
                        break;
                    case "loan rate":
                        defaultLoanRate = double.Parse(newValue);
                        break;
                    case "overdraft limit":
                        defaultOverdraftLimit = double.Parse(newValue);
                        break;
                    case "service charge":
                        serviceCharge = double.Parse(newValue);
                        break;
                    case "password attempts":
                        LimitPasswordAttempts = int.Parse(newValue);
                        break;
                    case "initial deposit":
                        minimalInitialDeposit = double.Parse(newValue);
                        break;
                    case "gold cashback":
                        goldCashbackRate = double.Parse(newValue);
                        break;
                    case "platinum cashback":
                        platinumCashbackRate = double.Parse(newValue);
                        break;
                    default:
                        Console.WriteLine("Parâmetro desconhecido.");
                        return;
                }
            }
            catch 
            {
                Console.WriteLine("Ocorreu um erro, tente novamente.");
            }
            Console.WriteLine($"Parâmetro '{parameterName}' atualizado para: {newValue}");
        }
    }
}
