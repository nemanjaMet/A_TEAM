using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neo4jClient;
using Neo4jClient.Cypher;
using A_TEAM.DomainModel;
using System.Text.RegularExpressions; // Za preciscavanje teksta

namespace A_TEAM
{
    public partial class FDodavanje_Radnika : Form
    {

        public GraphClient client;

        public FDodavanje_Radnika()
        {
            InitializeComponent();
        }

        // --- Dodavanje iz ComboBoxova ---
        private void BtnSubmitPJ_Click(object sender, EventArgs e)
        {
            // --- Provera da li je nesto selektovano u ComboBoxovima ---
            if (Convert.ToInt32(CbProgrammingLanguages.SelectedIndex) != -1 && Convert.ToInt32(CbZnanjePJ.SelectedIndex) != -1)
            {
                bool postoji = false;
                string programskiJezik = CbProgrammingLanguages.SelectedItem.ToString();
                string znanjePJ = CbZnanjePJ.SelectedItem.ToString();
                // --- Proveravamo da li taj jezik vec postoji u listi ---
                foreach (ListViewItem Item in LvPJ_Z.Items)
                {
                    if (Item.Text == programskiJezik)
                    {
                        postoji = true;
                    }
                }
                // --- Ako ne postoji, ubacujemo jezik i znanje jezika(1-10) u listView ---
                if (!postoji)
                {
                    ListViewItem lv1 = new ListViewItem(programskiJezik);
                    lv1.SubItems.Add(znanjePJ);
                    LvPJ_Z.Items.Add(lv1);

                    CbProgrammingLanguages.SelectedItem = null;
                    CbZnanjePJ.SelectedItem = null;
                    CbProgrammingLanguages.Text = "Programski jezik";
                    CbZnanjePJ.Text = "Znanje";
                }
                else
                {
                    MessageBox.Show("Programski jezik '" + programskiJezik + "' je vec dodat.");
                }
            }
            else
            {
                MessageBox.Show("Izaberite programski jezik i znanje programskog jezika!");
            }
        }

        // --- Brisanje selektovanog elementa iz listView-a ---
        private void BtnDeletePJFromList_Click(object sender, EventArgs e)
        {
            if (LvPJ_Z.SelectedItems.Count != 0)
            {
                LvPJ_Z.SelectedItems[0].Remove();
            }
        }

        // --- Ubacivanje Radnika u bazi ---
        private void BtnSubmitData_Click(object sender, EventArgs e)
        {
            string ime = this.TbIme.Text;
            string prezime = this.TbPrezime.Text;
            string adresa = this.TbAdresa.Text;
            string datumRodjenja = "";
            datumRodjenja += this.DatePicker.Value.Date.Day.ToString() + '.'
                + this.DatePicker.Value.Date.Month.ToString() + '.' + this.DatePicker.Value.Date.Year.ToString();
            
            string obrazovanje = this.TbObrazovanje.Text;

            // --- Provera da li postoje prazni textBoxovi
            if (String.IsNullOrWhiteSpace(ime))
            {
                MessageBox.Show("Unesi ime!");
                return;
            }
            else if (String.IsNullOrWhiteSpace(prezime))
            {
                MessageBox.Show("Unesi prezime!");
                return;
            }
            else if (String.IsNullOrWhiteSpace(adresa))
            {
                MessageBox.Show("Unesi adresu!");
            }
            else if (String.IsNullOrWhiteSpace(obrazovanje))
            {
                MessageBox.Show("Unesi obrazovanje!");
            }

            // --- Preciscavanje blanko znaka ----
            ime = checkString(ime);
            prezime = checkString(prezime);
            adresa = checkString(adresa);


            // --- Izvlacimo podatke iz listView-a ----
            string iskustvo = "";
            foreach (ListViewItem lvi in LvPJ_Z.Items)
            {
                iskustvo += lvi.Text + " " + lvi.SubItems[1].Text + ",";
            }
            iskustvo = iskustvo.TrimEnd(',');
            // ---- Rad sa bazom (ubacivanje podataka) ---
            try
            {
                // --- Kreiramo ID za radnika ----
                string idRadnika = getMaxId();
                if (idRadnika == "null")
                {
                    return;
                }

                Radnik noviRadnik = new Radnik();
                //noviRadnik.id = idRadnika;
                noviRadnik.id = idRadnika;
                noviRadnik.Ime = ime;
                noviRadnik.Prezime = prezime;
                noviRadnik.Adresa = adresa;
                noviRadnik.Datum_Rodjenja = datumRodjenja;
                noviRadnik.Iskustvo = iskustvo;
                noviRadnik.Obrazovanje = obrazovanje;

                // --- Kreiranje radnika u bazi (za isti ID, pravi duplikate) ---
                /*client.Cypher
                .Create("(radnik:Radnik {noviRadnik})")
                .WithParam("noviRadnik", noviRadnik)
                .ExecuteWithoutResults();*/

                // --- Kreiranje radnika ukoliko isti ne postoji u bazi ---
                // NEMA FEEDBACK UKOLIKO ISTI ID POSTOJI
                client.Cypher
                .Merge("(radnik:Radnik { id: {id} })")
                .OnCreate()
                .Set("radnik = {noviRadnik}")
                .WithParams(new
                {
                    id = noviRadnik.id,
                    noviRadnik
                })
                .ExecuteWithoutResults();

                MessageBox.Show("Uspesno kreiran radnik!");

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }

            // Zatvaranje forme
            this.Dispose();
        }

        // --- Vraca najveci ID Radnika ---
        private String getMaxId()
        {
            string maxId = "";
            try
            {
                // --- Upit za poslednji ID Radnika ubacen u bazi ---
                 maxId = client.Cypher
                .Match("(n:Radnik)")
                .Return(() => Return.As<string>("max(n.id)"))
                .Results
                .Single();

                // --- Ukoliko ne postoji ni jedan radnik u bazi ---
                 if (String.IsNullOrWhiteSpace(maxId))
                 {
                     maxId = "0";

                     // --- + Upiti koji se samo jednom izvrsavaju + ---
                     // --- Aktivni, Zavrseni i Projekti Na_cekanju
                     string[] statusi = { "Aktivan", "Zavrsen", "Na_cekanju" };
                     Status_projekta sp = new Status_projekta();
                     foreach (string s in statusi)
                     {
                         sp.Ime = s;
                         client.Cypher
                        .Merge("(status_projekta:Status_projekta { Ime: {Ime} })")
                        .OnCreate()
                        .Set("status_projekta = {sp}")
                        .WithParams(new
                        {
                            Ime = sp.Ime,
                            sp
                        })
                        .ExecuteWithoutResults();
                     }
                 }

                 maxId = (Convert.ToInt64(maxId) + 1).ToString();
                 return maxId;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
                return maxId = "null";
            }
        }

        // --- Funkcija za preciscavanje teksta ---
        private string checkString(string stringToCheck)
        {
            stringToCheck = Regex.Replace(stringToCheck, @"\t|\r", " ");
            stringToCheck = Regex.Replace(stringToCheck, @"( \n){2,}", "\n");
            stringToCheck = Regex.Replace(stringToCheck, " {2,}", " ");

            stringToCheck = stringToCheck.Trim();

            return stringToCheck;
        }


    }
}
