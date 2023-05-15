using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula19
{
    internal abstract class Pessoa
    {
        public string nome;
        public int idade;

        protected Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public abstract void exibir();
    }

    internal class Aluno : Pessoa
    {
        public string matricula;
        public Aluno(string nome, int idade, string matricula) : base(nome, idade)
        {
            this.matricula = matricula;
        }

        public override void exibir()
        {
            Console.WriteLine("Nome: "+this.nome+" | Idade: "+this.idade+" | Matricula: "+this.matricula);
        }
    }

    internal class Professor : Pessoa
    {
        public string diciplina;
        public Professor(string nome, int idade, string diciplina) : base(nome, idade)
        {
            this.diciplina = diciplina;
        }

        public override void exibir()
        {
            Console.WriteLine("Nome: " + this.nome + " | Idade: " + this.idade + " | Matricula: " + this.diciplina);
        }
    }
}
