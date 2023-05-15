using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula19
{
    internal abstract class Conta
    {
        public double Saldo { get; set; }
        public int Numero { get; set; }

        public Conta(double saldo, int numero) 
        {
            this.Saldo = saldo;
            this.Numero = numero;
        }
    }

    internal class ContaCorrente: Conta
    {
        public ContaCorrente(double saldo, int numero, double taxaDeJuros) : base(saldo, numero)
        {
            this.LimiteDeCredito = taxaDeJuros;

        }

        public double LimiteDeCredito { get; set; }


    }

    internal class ContaPoupanca : Conta
    {
        public ContaPoupanca(double saldo, int numero, double taxaDeJuros) : base(saldo, numero)
        {
            this.TaxaDeJuros = taxaDeJuros;

        }

        public double TaxaDeJuros { get; set; }


    }
}
