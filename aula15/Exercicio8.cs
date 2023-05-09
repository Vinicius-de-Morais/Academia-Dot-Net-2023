using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula15
{
    internal class Livro
    {
        private Autor _autor;
        private string _titulo;

        public Autor Autor {
            get
            {
                return this._autor;
            }
            set { 
                if(value != null || !String.IsNullOrEmpty(value.Nome))
                {
                    this._autor = value;
                }
                else
                    throw new Exception("O Autor nao pode ser null ou invalido");
            } 
        }

        public string Titulo {
            get {
                return this._titulo;
            }
            set {
                if (!String.IsNullOrEmpty(value))
                    this._titulo = value;
                else
                    throw new Exception("O titulo nao pode ser null ou invalido");
            }
        }
    }

    internal class Autor
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
