using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Of_Dades___Projeto_2bimestre
{
    class Program
    {
        static void Main()
        {
            bool t = true;
            while (t)
            {
                Console.WriteLine("Olá, Bem vindo ao Bank Of Dades!");
                Console.WriteLine("1- ENTRAR");
                Console.WriteLine("2- CADASTRAR");
                Console.WriteLine("3- SAIR");
                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Digite seu login");
                        break;
                    case 2:
                        Console.WriteLine("");
                        break;
                    case 3:
                        t=false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        continue;
                }
                while

            }














            /*
            // Código
            do
            {
                Console.WriteLine("\nBem-vindo ao banco!");
                Console.WriteLine("1 - Ver saldo");
                Console.WriteLine("2 - Sacar dinheiro");
                Console.WriteLine("3 - Depositar dinheiro");
                Console.WriteLine("4 - Sair");
                Console.Write("Escolha uma opção: ");
                if (!int.TryParse(Console.ReadLine(), out acao))
                {
                    Console.WriteLine("Opção inválida, digite um número.");
                    continue;
                }
                switch (acao)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine($"Seu saldo é: R$ {saldo:F2}");
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine($"Seu saldo é: R$ {saldo:F2}. Quanto deseja sacar? (Cobramos uma taxa de 10%)");
                        saque = double.Parse(Console.ReadLine());

                        if (saque > saldo)

                        {
                            Console.WriteLine("Você não tem saldo suficiente!");
                        }
                        else
                        {
                            saque = saque * 1.1;
                            saldo -= saque;
                            Console.WriteLine($"Saque realizado! Seu novo saldo é: R$ {saldo:F2}");
                        }
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine($"Seu saldo atual é: R$ {saldo:F2}");
                        Console.Write("Quanto deseja depositar? ");
                        deposito = double.Parse(Console.ReadLine());

                        Console.Write("De onde veio esse dinheiro? (exemplo: vendas): ");
                        string origem = Console.ReadLine().ToLower();

                        if (origem == "vendas")
                        {
                            double valorFinal = deposito * 0.9; // 10% de imposto
                            double imposto = deposito - valorFinal;
                            Console.WriteLine($"Depósito aceito!");
                            Console.WriteLine($"Imposto descontado: R$ {imposto:F2}");
                            Console.WriteLine($"Valor líquido depositado: R$ {valorFinal:F2}");
                            Console.WriteLine($"Seu novo saldo é: R$ {valorFinal:F2}");
                            saldo = valorFinal;
                        }
                        else
                        {
                            Console.WriteLine("❌ Origem não aceita. Depósito cancelado.");
                        }
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Fechando programa...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
            while (acao != 4);

            Console.WriteLine("Programa encerrado.");
            Console.ReadKey();
        */
        }
    }
}
