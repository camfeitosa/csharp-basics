//using System;
//using System.Globalization;


//namespace Course.Logica
//{
//    internal class Concat
//    {
//        public Concat() {

//            char genero = 'F';
//            int idade = 32;
//            double saldo = 10.35784;
//            string nome = "Maria";

//            Console.Write("Bom dia!");
//            Console.WriteLine("Boa tarde!");
//            Console.WriteLine("-----------------------------");
//            Console.WriteLine(genero);
//            Console.WriteLine(idade);
//            Console.WriteLine(saldo);
//            Console.WriteLine(saldo.ToString("F2")); // delimita o número de casas decimais
//            Console.WriteLine(saldo.ToString("F4"));
//            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); // troca a vírgula por ponto

//            // placeholders
//            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

//            // interpolação
//            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

//            // concatenação
//            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo + " reais" );

//        }
//    }
//}
