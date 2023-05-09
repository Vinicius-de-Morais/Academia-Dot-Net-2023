using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula15
{
    internal class Fabricante
    {
        private string _nome;

        public string Nome
        {
            get
            {
                return this._nome;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    this._nome = value;
                }
                else
                    throw new Exception("O nome nao pode ser null ou invalido");
            }
        }

        public string Endereco { get; set; }
        public string Cidade { get; set; }
    }

    internal class Produto
    {
        private string _nome;
        private Fabricante _fabricante;
        private int _preco;

        public string Nome
        {
            get
            {
                return this._nome;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    this._nome = value;
                }
                else
                    throw new Exception("O nome nao pode ser null ou invalido");
            }
        }

        public Fabricante Fabricante { 
            get => _fabricante; 
            set {
                if (value != null)
                {
                    _fabricante = value;
                }
                else
                    throw new Exception("A fabricante nao pode ser nula ou invalida");
            }
        }
        public int Preco {
            get => _preco; 
            set {
                if(value >= 0)
                {
                    _preco = value;
                }
                else
                {
                    throw new Exception("O preco nao pode ser negativo");
                }
            } 
        }
    }
}
