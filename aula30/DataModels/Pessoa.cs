using Castle.Components.DictionaryAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace aula30.DataModels
{
    public class Pessoa
    {
        public int id { get; set; }
        public string name { get; set; }
        public virtual ICollection<Email> Emails { get; set; }

        private string emailsString()
        {
            string str = "";

            foreach(Email email in Emails)
            {
                str += email.email + "; ";
            }

            return str;
        }

        public override string? ToString()
        {
            return id + " " + name + " emails: " + emailsString();
        }
    }
}