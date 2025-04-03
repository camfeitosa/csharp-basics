using System;

namespace POO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre a altura e a largura de um retangulo: ");

            retangulo.altura = int.Parse(Console.ReadLine());
            Console.WriteLine(retangulo.altura);
            retangulo.largura = int.Parse(Console.ReadLine());
            Console.WriteLine(retangulo.largura);

            double area = retangulo.Area();
            double perimetro = retangulo.Perimetro();

            Console.WriteLine($"Area: {area} ");
            Console.WriteLine($"Perimetro: {perimetro}");


        }
    }
}