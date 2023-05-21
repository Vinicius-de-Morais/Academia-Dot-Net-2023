using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula18
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string DataNascimento { get; set; }

        public Pessoa(string nome, string email, string dataNascimento)
        {
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
        }

        public Pessoa(string nome, string dataNascimento)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Email = gerarEmail();
        }

        public string gerarEmail()
        {
            try
            {
                string[] vetNome = this.Nome.Split(" ");
                string nameFormat = "";
                if (vetNome.Length > 1)
                {
                    nameFormat = vetNome[0] + "." + vetNome[vetNome.Length - 1];
                }
                else
                {
                    nameFormat = vetNome[0] + ".";
                }

                return nameFormat + this.DataNascimento.Replace("/", "")+"@dominio.com.br";
            }
            catch
            {
                throw new Exception("Nao foi possivel gerar um email com o nome fornecido");
            }
        }

        public override string ToString()
        {
            return Nome + "|" + Email + "|" + DataNascimento;
        }

        public override bool Equals(object? obj)
        {
            return obj is Pessoa pessoa &&
                   Email == pessoa.Email;
        }
    }
}
