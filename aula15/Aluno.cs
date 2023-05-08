using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula15
{
    internal class Aluno
    {
        private string _nome;
        private int _matricula;

        public string Nome {
            get => _nome;
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _nome = value;
                }
                else
                {
                    throw new Exception("O nome não pode ser vazio");
                }
            }
        }
        public int Matricula { 
            get => _matricula; 
            set {
                if(value > 0)
                {
                    _matricula = value;
                }
                else
                {
                    throw new Exception("A matricula deve ser maior que 0");
                }
            } 
        }
    }
}
