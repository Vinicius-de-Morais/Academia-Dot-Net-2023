using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula15
{
    internal class ContaBancaria
    {

        public string NumeroConta { get; set; }
        public string Titular { get; set; }
        public double Limite { get; set; }
        public double Saldo { get; set; }

        public void Depositar(double value)
        {
            this.Saldo += value;
        }

        public void Sacar(double value)
        {
            if(value < this.Saldo)
            {
                this.Saldo -= value;
            }
            else
            {
                throw new Exception("Saldo insuficiente para operacao");
            }
        }
    }
}
