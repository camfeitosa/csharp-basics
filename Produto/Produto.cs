using System;
using System.Globalization;

namespace ProjetoProduto
{
    internal class Produto // por padrão é internal
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; } // impede que o usuario mude o valor de Quantidade

        // mesmo nome da classe
        // atribuir cada parametro que irá receber -> atributo existente
        // dado que chegou pelo construtor

        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // Propriedade
        // Nome possui uma lógica particular - sem auto properties
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value; // value -> representa o valor que chegaria como parametro
                }
            }
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
            return _nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
