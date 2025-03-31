//using System;
//using System.Globalization;


//namespace Course.Logica
//{
//    internal class ReadLine
//    {
//        public ReadLine() {

//            // array do tipo string
//            string s = Console.ReadLine();
//            string[] vet = s.Split(' '); // analisa a string original e reconheçe cada palavra separada por espaço em branco, adiciona no vetor cada palavra


//            string p1 = vet[0];
//            string p2 = vet[1];

//            Console.WriteLine(p1);
//            Console.WriteLine(p2);


//            // readLine le valores como string -> int.Parse para mudar para int
//            int n1 = int.Parse(Console.ReadLine());
//            char ch = char.Parse(Console.ReadLine());
//            // aceitar . e não ,
//            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//            // Adicionar as informações em uma linha com espaços
//            string[] vetor = Console.ReadLine().Split(' ');
//            string nome = vetor[0];
//            char sexo = char.Parse(vetor[1]);
//            int idade = int.Parse(vetor[2]);
//            double altura = double.Parse(vetor[3], CultureInfo.InvariantCulture);

//            Console.WriteLine("Voce digitou:");
//            Console.WriteLine(n1);
//            Console.WriteLine(ch);
//            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));



//            }
//        }
//    }
