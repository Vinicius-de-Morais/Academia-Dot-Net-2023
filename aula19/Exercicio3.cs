using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula19
{
    internal abstract class Animal
    {
        private string nome;
        private int idade;

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }

        public Animal(string nome, int idade) 
        {
            this.nome = nome;
            this.idade = idade;
        }
    }

    internal class Cachorro : Animal
    {
        private string raca;
        public Cachorro(string nome, int idade, string raca) : base(nome, idade)
        {
            this.raca = raca;
        }

        public string Raca { get => raca; set => raca = value; }
    }

    internal class Gato : Animal
    {
        private string raca;
        public Gato(string nome, int idade, string raca) : base(nome, idade)
        {
            this.raca = raca;
        }

        public string Raca { get => raca; set => raca = value; }
    }
}
