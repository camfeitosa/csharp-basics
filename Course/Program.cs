using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("Informe o nome: ");
            pessoa1.Nome = Console.ReadLine();

            Console.WriteLine("Informe a idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());


            Console.WriteLine("Informe o segundo nome: ");
            pessoa2.Nome = Console.ReadLine();

            Console.WriteLine("Informe a idade: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            string mais = pessoa1.Idade > pessoa2.Idade ? $"Pessoa mais velha: {pessoa1.Nome}" : $"Pessoa mais velha: {pessoa2.Nome}";
            Console.WriteLine(mais);

        }
    }
}