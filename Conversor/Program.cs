using System;

namespace Conversor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação do dólar? ");
            double dolar = double.Parse(Console.ReadLine()); 

            Console.WriteLine("Quantos dólares voce vai comprar? ");
            double valor = double.Parse(Console.ReadLine());

            double resultado = ConversorDeMoeda.Converter(dolar, valor);

            Console.WriteLine(resultado);


        }
    }
}