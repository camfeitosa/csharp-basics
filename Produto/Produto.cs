using System;
using System.Globalization;

namespace ProjetoProduto
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        // mesmo nome da classe
        // atribuir cada parametro que irá receber no atributo existente
        // dado que chegou pelo construtor

        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco= preco;
            Quantidade = 0; // linha dispensável, pois quando é nulo o zero é padrão
        }


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) // parametro de entrada de função letra minuscula
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString() // override indica que operação veio de outra classe
        {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
