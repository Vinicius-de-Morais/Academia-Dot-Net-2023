using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula15
{
    internal class Carro
    {
        private string _nome;
        private Marca _marca;
        private Motor _motor;
        private int _ano;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public Marca Marca {
            get { return _marca; }
            set { _marca = value; }
        }

        public Motor Motor {
            get { return _motor; }
            set { _motor = value; }
        }

        private int Ano {
            get { return _ano; }
            set { _ano = value; }
        }

    }
}
