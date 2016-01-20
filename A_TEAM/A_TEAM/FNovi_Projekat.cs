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
    public partial class FNovi_Projekat : Form
    {
        public FNovi_Projekat()
        {
            InitializeComponent();
        }

        private GraphClient client;

        // --- Pozivanje forme za dodavanje osobe ---
        private void BtnAddPerson_Click(object sender, EventArgs e)
        {
            FDodavanje_Radnika ap = new FDodavanje_Radnika();
            ap.client = client;
            ap.ShowDialog();
        }

        // --- Pozivanje forme za dodavanje development-a ---
        private void button2_Click(object sender, EventArgs e)
        {
            FDodavanje_Razvoja fd = new FDodavanje_Razvoja();
            fd.client = client;
            fd.ShowDialog();
        }

        // --- Dodavanje iz ComboBoxova ---
        private void BtnSubmitToListView_Click(object sender, EventArgs e)
        { 
            // --- Provera da li je nesto selektovano u ComboBoxovima ---
            if (Convert.ToInt32(CbProgramskiJezik.SelectedIndex) != -1 && Convert.ToInt32(CbZnanje.SelectedIndex) != -1)
            {
                bool postoji = false;
                string programskiJezik = CbProgramskiJezik.SelectedItem.ToString();
                string znanjePJ = CbZnanje.SelectedItem.ToString();
                // --- Proveravamo da li taj jezik vec postoji u listi ---
                foreach (ListViewItem Item in LvPJezikZnanje.Items)
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
                    LvPJezikZnanje.Items.Add(lv1);

                    // --- Refresh comboBox ---
                    CbProgramskiJezik.SelectedItem = null;
                    CbZnanje.SelectedItem = null;
                    CbProgramskiJezik.Text = "Programski jezik";
                    CbZnanje.Text = "Znanje";
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

        // --- Brisanje elementa iz listView-a ---
        private void BtnRemoveFromListView_Click(object sender, EventArgs e)
        {
            if ( LvPJezikZnanje.SelectedItems.Count != 0)
            {
                LvPJezikZnanje.SelectedItems[0].Remove();
            }
        }

        // --- Povezivanje sa bazom |*RED OR BLUE PILL #NeoMatrix*| ---
        private void Form1_Load(object sender, EventArgs e)
        {
            client = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "edukacija");
            try
            {
                client.Connect();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        // --- Ubacivanje podataka o Projektu u bazi ---
        private void BtnSubmitDataPoject_Click(object sender, EventArgs e)
        {
            string imeProjekta = this.TbImeProjekta.Text;
            string rokZavrsetka = this.DatePicker.Text;

            // --- Izvlacimo podatke iz listView-a ----
            string lista = "";
            foreach (ListViewItem lvi in LvPJezikZnanje.Items)
            {
                lista += lvi.Text + " " + lvi.SubItems[1].Text + ",";
            }
            lista.TrimEnd(',');
            string listaRazvojaRadnika = "";
            foreach (ListViewItem lvi in LvRazvojBrojRadnika.Items)
            {
                listaRazvojaRadnika += lvi.Text + " " + lvi.SubItems[1].Text + ",";
            }
            listaRazvojaRadnika = listaRazvojaRadnika.TrimEnd(',');

            // --- Provera ispravnosti ---
            if (String.IsNullOrWhiteSpace(imeProjekta))
            {
                MessageBox.Show("Napisite ime projekta!");
                return;
            }
            else if (String.IsNullOrWhiteSpace(rokZavrsetka))
            {
                MessageBox.Show("Datum kraja roka nije korektan!");
                return;
            }
            else if (String.IsNullOrWhiteSpace(lista))
            {
                MessageBox.Show("Lista potrebnih ljudi sa iskustvom je prazna!");
                return;
            }
            else if (String.IsNullOrWhiteSpace(listaRazvojaRadnika))
            {
                MessageBox.Show("Lista potrebnih ljudi iz razvoja je prazna!");
                //return;
            }

            // --- Preciscavanje teksta ---
            imeProjekta = checkString(imeProjekta);

            Projekat noviProjekat = new Projekat();
            noviProjekat.Ime = imeProjekta;
            noviProjekat.Rok_zavrsetka = rokZavrsetka;
            noviProjekat.Potrebno_iskustvo = lista;
            noviProjekat.Potrebni_ljudi_iz_razvoja = listaRazvojaRadnika;
            //noviProjekat.Radnici_angazovani_na_projektu = "IDRadnika Ime Prezime, IDRadnika Ime Prezime,...."
            
            try
            {
                // --- Ubacivanje Projekta u bazi (pravi duplikate za isti projekat) ---
                /*client.Cypher
               .Create("(projekat:Projekat {noviProjekat})")
               .WithParam("noviProjekat", noviProjekat)
               .ExecuteWithoutResults();*/

                // --- Ubacivanje Razvoja u bazi, ukoliko isti ne postoji ---
                // NEMA FEEDBACK UKOLIKO ISTI RAZVOJ POSTOJI
                client.Cypher
                .Merge("(projekat:Projekat { Ime: {Ime} })")
                .OnCreate()
                .Set("projekat = {noviProjekat}")
                .WithParams(new
                {
                    Ime = noviProjekat.Ime,
                    noviProjekat
                })
                .ExecuteWithoutResults();

                this.TbImeProjekta.Text = "";

                MessageBox.Show("Uspesno kreiran novi Projekat!");

                // ************ ALGORITAM ************** //
              /*  IList<string> testLista = new List<string>();
                testLista = client.Cypher
                .Match("(radnik:Radnik)")
                .Where((Radnik radnik) => radnik.id == "")
                .Return(radnik => radnik.Labels())
                .Results;*/
                
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }

            MessageBox.Show("Uspesno kreiran projekat!");
            
        }

        // --- Pozivanje forme za brisanje Radnika ---
        private void BtnIzbrisiRadnika_Click(object sender, EventArgs e)
        {
            FBrisanje_Radnika fbr = new FBrisanje_Radnika();
            fbr.client = client;
            fbr.ShowDialog();
        }

        // --- pozivanje forme za brisanje Razvoja ---
        private void BtnIzbrisiRazvoj_Click(object sender, EventArgs e)
        {
            FBrisanje_Razvoja fbr = new FBrisanje_Razvoja();
            fbr.client = client;
            fbr.ShowDialog();
        }

        // --- Pozivanje forme za Veze Radnika ---
        private void BtnVeze_Click(object sender, EventArgs e)
        {
            FVeze_radnika fvr = new FVeze_radnika();
            fvr.client = client;
            fvr.ShowDialog();
        }

        // --- Popunjava se comboBox podacima iz baze ---
        private void CbRazvoj_MouseEnter(object sender, EventArgs e)
        {

            if (CbRazvoj.Items.Count < 1)
            {
                IList<Razvoj> listaRazvoja = new List<Razvoj>();

                try
                {
                    listaRazvoja = client.Cypher
                    .Match("(razvoj:Razvoj)")
                    .Return(razvoj => razvoj.As<Razvoj>())
                    .Results.ToList();


                    foreach (Razvoj razvoj in listaRazvoja)
                    {
                        CbRazvoj.Items.Add(razvoj.Ime);
                    }
                    //CbRazvoj.Items.AddRange(listaRazvoja.ToArray());

                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.ToString());
                }
            }
        }

        // --- Dodaje Razvoj i broj radnika iz listView ---
        private void BtnDodajRazvojUListu_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(CbRazvoj.SelectedIndex) != -1 && Convert.ToInt32(CbBrojRadnika.SelectedIndex) != -1)
            {
                string razvoj = CbRazvoj.SelectedItem.ToString();
                string brojRadnika = CbBrojRadnika.SelectedItem.ToString();
                
                ListViewItem lv1 = new ListViewItem(razvoj);
                lv1.SubItems.Add(brojRadnika);
                LvRazvojBrojRadnika.Items.Add(lv1);

                // --- Refresh comboBox ---
                CbRazvoj.SelectedItem = null;
                CbBrojRadnika.SelectedItem = null;
                CbRazvoj.Text = "Izaberi razvoj";
                CbBrojRadnika.Text = "Broj radnika";

                
            }
            else
            {
                MessageBox.Show("Izaberite razvoj i potreban broj radnika!");
            }
        }

        // --- Brise Razvoj i broj radnika iz listView ---
        private void BtnIzbrisiRazvojIzListe_Click(object sender, EventArgs e)
        {
            if (LvRazvojBrojRadnika.SelectedItems.Count != 0)
            {
                LvRazvojBrojRadnika.SelectedItems[0].Remove();
            }
        }

        // --- Pozivanje nove forme za brisanje veza ---
        private void BtnBrisanjeVeza_Click(object sender, EventArgs e)
        {
            FBrisanje_Veza fbv = new FBrisanje_Veza();
            fbv.client = client;
            fbv.ShowDialog();
        }

        // --- Pozivanje nove forme za prisanje projekata ---
        private void BtnBrisanjeProjekta_Click(object sender, EventArgs e)
        {
            FBrisanje_Projekta fbp = new FBrisanje_Projekta();
            fbp.client = client;
            fbp.ShowDialog();
        }

        // --- Pozivanje nove forme za dodavanje veza Radnik-Razvoj ---
        private void button1_Click(object sender, EventArgs e)
        {
            FVeza_Radnik_Razvoj fvrr = new FVeza_Radnik_Razvoj();
            fvrr.client = client;
            fvrr.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            try
            {
                //Radnik vraceniRadnik = new Radnik();

                // --- Vraca jedan element ---
                /*vraceniRadnik = client.Cypher
               .Match("(radnik:Radnik)")
               .Where((Radnik radnik) => radnik.id == "5")
               .Return(radnik => radnik.As<Radnik>())
               .Results.First();*/

                // --- 
                //CypherQuery query = new CypherQuery("MATCH (a:Radnik ) where not (a)-[:RADI_NA]->() RETURN a", new Dictionary<string, object>(), CypherResultMode.Set);
                //var radnici = ((IRawGraphClient)client).ExecuteGetCypherResults<Radnik>(query).ToList();              
                
                // --- Kreiranje veze STATUS za Projekat-Aktivan ---
                /*client.Cypher.Match("(projekat:Projekat)", "(aktivan:Aktivan)")
                       .Where((Projekat projekat) => projekat.Ime == "Projekat 1")            
                       .CreateUnique("projekat-[:STATUS]->aktivan")
                       .ExecuteWithoutResults();*/

                // --- Kreiranje veze ANGAZOVAN_NA Projekat-Radnik (Sve radnike vezuje za projekat) ---
                /*client.Cypher.Match("(projekat:Projekat)", "(radnik:Radnik)")
                       .Where((Projekat projekat) => projekat.Ime == "Projekat 1")
                       .CreateUnique("projekat-[:ANGAZOVAN_NA]->radnik")
                       .ExecuteWithoutResults();*/

                // --- Brisanje svih veza od projekta ka bilo cemu ---
                /*client.Cypher.Match("(projekat:Projekat)-[r]->() ")                      
                .Delete("r")
                .ExecuteWithoutResults();*/

                Projekat test = new Projekat("Test", "1/1/2056", "PHP 5,C 4", "", "");

                CSP.tryTest(test,client);
               
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
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

        // --- Ukljucivanje automatske provere aktivnih projekata (mozda je neki zavrsen) ---
        private void FNovi_Projekat_Shown(object sender, EventArgs e)
        {
            Proveri_aktivne_projekte pap = new Proveri_aktivne_projekte(600);
        }

        
    }
}
