using System;
using System.Globalization;

namespace ProjetoProduto
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Entre os dados do produto: ");

            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p = new Produto(nome, preco);


            Console.WriteLine("Dados do produto: " + p); // aplica o ToString no Object
            Console.WriteLine();

            Console.WriteLine("Digite a quantidade de produtos a ser adicionado no estoque: ");

            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte); // passa como parametro a quantidade
            Console.WriteLine("Dados Atualizados: " + p);

            Console.WriteLine();

            Console.WriteLine("Digite a quantidade de produtos a ser removido no estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine("Dados Atualizados: " + p);
        }
    }
}