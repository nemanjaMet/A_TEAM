using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_TEAM.DomainModel
{
    public class Projekat
    {
        public String Ime { get; set; }
        public String Rok_zavrsetka { get; set; }
        public String Potrebno_iskustvo { get; set; }
        public String Potrebni_ljudi_iz_razvoja { get; set; }
        public String Radnici_angazovani_na_projektu { get; set; }

        public Projekat()
        {
            this.Ime = "";
            this.Rok_zavrsetka = "";
            this.Potrebno_iskustvo = "";
            this.Potrebni_ljudi_iz_razvoja = "";
            this.Radnici_angazovani_na_projektu ="";
        }
        public Projekat(string im, string rok_zav, string potr_isk, string potrebni_ljudi,string radnici_angazovani)
        {
            this.Ime = im;
            this.Rok_zavrsetka = rok_zav;
            this.Potrebno_iskustvo = potr_isk;
            this.Potrebni_ljudi_iz_razvoja = potrebni_ljudi;
            this.Radnici_angazovani_na_projektu = radnici_angazovani;
        }
    }
}
