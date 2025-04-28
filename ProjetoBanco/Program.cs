using System;
using System.Globalization;

namespace ProjetoBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Entre o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.WriteLine("Haverá deposito inicial?");
            char depositoInicio = char.Parse(Console.ReadLine());

            ContaBancaria conta1;

            if (depositoInicio == 's')
            {
                Console.WriteLine("Entre o valor de depósito inicial: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
                conta1 = new ContaBancaria(numConta, titular, deposito);
            } else
            {
                conta1 = new ContaBancaria(numConta, titular);
            }

            Console.WriteLine(conta1);

            Console.WriteLine("Entre um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta1.Depositar(valorDeposito);

            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta1);

            Console.WriteLine("Entre um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta1.Sacar(valorSaque);

            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta1);
        }
    }
}