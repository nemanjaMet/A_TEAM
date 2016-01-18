using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_TEAM.DomainModel
{
    class Projekat
    {
        public String Ime { get; set; }
        public String Rok_zavrsetka { get; set; }
        public List<string> Potrebno_iskustvo { get; set; }
        public List<string> Potrebni_ljudi_iz_razvoja { get; set; }
    }
}
