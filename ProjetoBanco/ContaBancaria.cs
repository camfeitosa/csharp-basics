using System;

namespace ProjetoBanco
{
    internal class ContaBancaria
    {
        private double _depositoInicial;
        public int NumeroConta { get ; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

 
        public ContaBancaria(int numeroConta, string nome )
        {
            _depositoInicial = 0.00;
            NumeroConta = numeroConta;
            Nome = nome;
        }

        public ContaBancaria(int numeroConta, string nome, double depositoInicial) : this(numeroConta, nome)
        {
            _depositoInicial = depositoInicial;
        }

        public void Depositar()
        {

        }

        public void Sacar()
        {

        }

        public override string ToString()
        {
            return "Conta " + NumeroConta + ", Titular: " + Nome + ", Saldo: " + Saldo;
        }



    }
}
