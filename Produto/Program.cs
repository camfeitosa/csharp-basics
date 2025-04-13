using System;
using System.Globalization;

namespace ProjetoProduto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto("TV", 5000.00, 10);

            produto.Nome = ("T"); // não aceita -> printa o valor antigo

            Console.WriteLine(produto.Nome);
            Console.WriteLine(produto.Preco);
            Console.WriteLine(produto.Quantidade);

        }
    }
}