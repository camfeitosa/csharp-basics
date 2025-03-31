//using Course.Logica;
//using System;

//namespace Course.Logica
//{
//    internal class TipoDados
//    {
//        public void Executar()
//        {
//            bool completo = false;

//            char genero = 'F'; // aspas simples para char
//            char letra = '\u0041'; // unicode para char

//            byte n1 = 255; // valor máximo aceito para byte
//            int n3 = 2147483647; // valor máximo aceito para int
//            long n4 = 2147483648L; // para long é necessário colocar o L no final do número

//            float n5 = 4.5f; // para float é necessário colocar o f no final do número
//            double n6 = 4.5; // double é o padrão para números decimais

//            string nome = "Maria"; //aspas duplas para string
//            nome = "Camila";

//            object obj1 = "Alex Brown"; // tipo genérico que aceita qualquer tipo de dado
//            object obj2 = 4.5f;

//            int n7 = int.MaxValue; // valor máximo aceito para int
//            int n8 = int.MinValue; // valor mínimo aceito para int

//            decimal n9 = decimal.MaxValue; // valor máximo aceito para decimal

//            Console.WriteLine(n9);
//            Console.WriteLine(n7);
//            Console.WriteLine(n8);
//            Console.WriteLine(nome);
//            Console.WriteLine(n5);
//            Console.WriteLine(n6);
//            Console.WriteLine(letra);
//            Console.WriteLine(genero);
//            Console.WriteLine(completo);
//            Console.WriteLine(n1);
//            Console.WriteLine(n3);
//            Console.WriteLine(n4);
//            Console.WriteLine(obj1);
//            Console.WriteLine(obj2);
//        }
//    }
//}