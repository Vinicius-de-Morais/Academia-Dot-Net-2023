using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula19
{
    internal abstract class Veiculo
    {
        public string modelo;
        public string marca;

        protected Veiculo(string modelo, string marca)
        {
            this.modelo = modelo;
            this.marca = marca;
        }

        public virtual void dirigindo()
        {
            Console.WriteLine($"Dirigindo o {this.marca} {this.modelo}");
        }
    }

    internal class Carro : Veiculo
    {
        public int portas;
        public Carro(string modelo, string marca, int portas) : base(modelo, marca)
        {
            this.portas = portas;
        }

        public override void dirigindo()
        {
            Console.WriteLine($"Dirigindo o {this.marca} {this.modelo} com {this.portas} portas");
        }
    }

    internal class Moto : Veiculo
    {
        public int cilindradas;
        public Moto(string modelo, string marca, int cilindradas) : base(modelo, marca)
        {
            this.cilindradas = cilindradas;
        }
        public override void dirigindo()
        {
            Console.WriteLine("Dirigindo o " + this.marca + " " + this.modelo);
        }
    }
}
