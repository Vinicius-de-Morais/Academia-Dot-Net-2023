using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula30.DataModels
{
    public class Email
    {

        public int id { get; set; }
        public virtual Pessoa pessoa { get; set; }
        public string email { get; set; }

    }
}
