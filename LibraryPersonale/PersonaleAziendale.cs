using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPersonale
{
    public class PersonaleAziendale : Persona
    {
        public string Tipologia { get; set; }
        public string Qualifica { get; set; }
        public string Area { get; set; }

        public PersonaleAziendale(string nome, string cognome, string codice, string tipologia) : base(nome, cognome, codice)
        {
            Tipologia = tipologia;
        }
    }
}
