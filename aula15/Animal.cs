using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula15
{
    internal class Animal
    {

        private string _nome;
        private string _especie;
        private int _idade;
        private string _som;

        public string Nome { get => _nome; set => _nome = value; }
        public string Especie1 { get => _especie; set => _especie = value; }
        public int Idade { get => _idade; set => _idade = value; }

        public void EmitirSom()
        {
            Console.WriteLine(this._som);
        }
    }
}
