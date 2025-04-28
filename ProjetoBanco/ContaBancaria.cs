using System;
using System.Globalization;

namespace ProjetoBanco
{
    internal class ContaBancaria
    {
        public int NumeroConta { get ; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

 
        public ContaBancaria(int numeroConta, string nome )
        {
            NumeroConta = numeroConta;
            Nome = nome;
        }

        public ContaBancaria(int numeroConta, string nome, double depositoInicial) : this(numeroConta, nome)
        {
            Depositar(depositoInicial); //  a lógica de deposito está dentro do método, chamar método direto no construtor
        }


        public void Depositar(double quantia)
        {
            Saldo += quantia;
        }

        public void Sacar(double quantia)
        {
            double taxaSaque = quantia + 5.00;

            Saldo -= taxaSaque;

        }

        public override string ToString()
        {
            return "Conta " + NumeroConta + ", Titular: " + Nome + ", Saldo: " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
