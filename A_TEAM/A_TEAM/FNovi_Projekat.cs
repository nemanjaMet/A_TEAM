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

        private void BtnSubmitDataPoject_Click(object sender, EventArgs e)
        {
            string imeProjekta = this.TbImeProjekta.Text;
            string rokZavrsetka = this.DatePicker.Text;

            // --- Izvlacimo podatke iz listView-a ----
            List<string> lista = new List<string>();
            foreach (ListViewItem lvi in LvPJezikZnanje.Items)
            {
                lista.Add(lvi.Text + " " + lvi.SubItems[1].Text);
            }

            if (String.IsNullOrWhiteSpace(imeProjekta))
            {
                MessageBox.Show("Napisite ime projekta!");
            }
            else if (String.IsNullOrWhiteSpace(rokZavrsetka))
            {
                MessageBox.Show("Datum kraja roka nije korektan!");
            }
            else if (lista.Count < 1)
            {
                MessageBox.Show("Lista potrebnih ljudi sa iskustvom je prazna!");
            }

            Projekat noviProjekat = new Projekat();
            noviProjekat.Ime = imeProjekta;
            noviProjekat.Rok_zavrsetka = rokZavrsetka;
            noviProjekat.Potrebno_iskustvo = lista;

            try
            {
                client.Cypher
               .Create("(projekat:Projekat {noviProjekat})")
               .WithParam("noviProjekat", noviProjekat)
               .ExecuteWithoutResults();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }

            MessageBox.Show("Uspesno kreiran projekat!");
            
        }

        private void BtnIzbrisiRadnika_Click(object sender, EventArgs e)
        {
            FBrisanje_Radnika fbr = new FBrisanje_Radnika();
            fbr.client = client;
            fbr.ShowDialog();
        }

        private void BtnIzbrisiRazvoj_Click(object sender, EventArgs e)
        {
            FBrisanje_Razvoja fbr = new FBrisanje_Razvoja();
            fbr.client = client;
            fbr.ShowDialog();
        }

        private void BtnVeze_Click(object sender, EventArgs e)
        {
            FVeze_radnika fvr = new FVeze_radnika();
            fvr.client = client;
            fvr.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {        

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where has(n.id) return max(n.id)",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);

            String maxId = ((IRawGraphClient)client).ExecuteGetCypherResults<String>(query).ToList().FirstOrDefault();

           /* client.Cypher
                .Start("(radnik:Radnik {noviRadnik})")
                .Where("noviRadnik", noviRadnik)
                .ExecuteWithoutResults();*/

           /* string test = client.Cypher
            .Match("(radnik:Radnik)")
            .Where(((Radnik radnik) => radnik)
            .Return(radnik => radnik)
            .Results();*/

            string rez = "";

            try
            {
                int mId = Int32.Parse(maxId);
                rez = (mId++).ToString();
            }
            catch (Exception exception)
            {
               rez = "";
            }


           // ap.ShowDialog();
        }
    }
}
