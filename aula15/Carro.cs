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
        private int _velocidade;

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

        public int Velocidade { get => _velocidade; set => _velocidade = value; }

        private int Ano {
            get { return _ano; }
            set { _ano = value; }
        }

        public void acelerar()
        {
            this.Velocidade += 10;
        }

        public void frear()
        {
            if(this.Velocidade - 10 < 0)
            {
                this.Velocidade = 0;
            }else
                this.Velocidade -= 10;
        }
    }
}
