using System;

namespace POO1
{
    internal class Retangulo
    {
        public int largura, altura;

        public double Area()
        {
            double area = largura * altura;
            return area;
        }

        public double Perimetro()
        {
            double perimetro = 2 * (largura + altura);
            return perimetro;
        }



    }
}
