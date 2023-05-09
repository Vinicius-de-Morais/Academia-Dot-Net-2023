using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula15
{
    internal class Aluno2
    {

        private string _nome;
        private float nota1, nota2, nota3;

        public string Nome { get => _nome; set => _nome = value; }
        public float Nota1 { get => nota1; set => nota1 = value; }
        public float Nota2 { get => nota2; set => nota2 = value; }
        public float Nota3 { get => nota3; set => nota3 = value; }

        public bool media()
        {
            float media = (nota1 + nota2 + nota3) / 3;
            if (media >= 6)
                return true;
            else
                return false;
        }
    }
}
