using System;
using System.Globalization;

namespace MembrosEstaticos
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // chama direto pela classe, sem precisar ser instanciada em um obj
            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume);
            Console.WriteLine("Valor de Pi: " + Calculadora.Pi);

        }

        // static para poder ser chamado em outra função static
        // funções auxiliares dentro da classe principal


    }
}