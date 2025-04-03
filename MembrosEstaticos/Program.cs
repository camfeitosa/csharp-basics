﻿using System;
using System.Globalization;

namespace MembrosEstaticos
{
    internal class Program
    {
        static double Pi = 3.14

        static void Main(string[] args)
        {
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);

            Console.WriteLine("Circunferencia: " + circ);

        }

        static double Circunferencia(double r)
        {
            return 2 * Pi * r
        }
    }
}