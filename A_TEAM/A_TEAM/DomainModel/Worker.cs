using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_TEAM.DomainModel
{
    class Worker
    {
        public String id { get; set; }
        public String ime { get; set; }
        public String prezime { get; set; }
        public String adresa { get; set; }
        public String datumRodjenja { get; set; }
        public List<string> jeziciZnanje { get; set; } 
    }
}
