using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula19
{
    internal interface Forma
    {
        public abstract float CalcularArea();
        public abstract float CalcularPerimetro();

    }

    internal class Retangulo : Forma
    {
        float altura;
        float largura;

        float Forma.CalcularArea()
        {
            return this.largura * this.altura;
        }

        float Forma.CalcularPerimetro()
        {
            return (2 * this.largura) + (2 * this.altura);
        }
    }
}
