using System;

namespace Course
{
    internal class Triangulo
    {
        // atributos podem ser acessados em outro arquivo

        public double A;
        public double B;
        public double C;

        // método da classe Triangulo -> função
        // sem parametros pq os dados estão dentro da classe 
        public double Area()
        {
            double p = (A + B + C) / 2;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;

        }
    }
}

