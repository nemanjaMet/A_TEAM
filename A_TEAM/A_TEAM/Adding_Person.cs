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
    public partial class Adding_Person : Form
    {

        public GraphClient client;

        public Adding_Person()
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

        private void BtnSubmitData_Click(object sender, EventArgs e)
        {
            string ime = this.TbIme.Text;
            string prezime = this.TbPrezime.Text;
            string adresa = this.TbAdresa.Text;
            string datumRodjenja = this.DatePicker.Text;

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

            // --- Preciscavanje blanko znaka ----
            ime = ime.Trim();
            prezime = prezime.Trim();
            adresa = adresa.Trim();


            // --- Izvlacimo podatke iz listView-a ----
            List<string> lista = new List<string>();
            foreach (ListViewItem lvi in LvPJ_Z.Items)
            {
                lista.Add(lvi.Text + " " + lvi.SubItems[1].Text);
            }

            // ---- Rad sa bazom (ubacivanje podataka) ---
            try
            {
                Worker worker = new Worker();

                // ********* NECEMO OVAKO ********* //
                string maxId = getMaxId();
                try
                {
                    int mId = Int32.Parse(maxId);
                    worker.id = (mId++).ToString();
                }
                catch (Exception exception)
                {
                    worker.id = "";
                }
                // **************************** //

                worker.ime = ime;
                worker.prezime = prezime;
                worker.adresa = adresa;
                worker.datumRodjenja = datumRodjenja;
                worker.jeziciZnanje = lista;

                /* var jsonWorker = Newtonsoft.Json.JsonConvert.SerializeObject(worker);
                 client.Cypher
                     .Create("(worker:Worker {jsonWorker})")
                     .WithParam("jsonWorker", jsonWorker)
                     .ExecuteWithoutResults();*/

                Dictionary<string, object> queryDict = new Dictionary<string, object>();
                queryDict.Add("Ime", worker.ime);
                queryDict.Add("Prezime", worker.prezime);
                queryDict.Add("Adresa", worker.adresa);
                queryDict.Add("Datum_rodjenja", worker.datumRodjenja);
                queryDict.Add("Programski_jezici_Znanje", worker.jeziciZnanje);

                var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Worker {id:'" + worker.id + "', Ime:'" + worker.ime
                                                            + "', Prezime:'" + worker.prezime + "', Adresa:'" + worker.adresa

                                                            + "', Programski_jezici_Znanje:'" + Newtonsoft.Json.JsonConvert.SerializeObject(worker.jeziciZnanje) + "', Datum_rodjenja:'" + worker.datumRodjenja + "'}) return n",
                                                            queryDict, CypherResultMode.Set);
                
                // --- Execute Cypher without feedback ---
                ((IRawGraphClient)client).ExecuteCypher(query);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }

            // Zatvaranje forme
            this.Dispose();
        }


        // !!! COPY PASTO BOGDANOVIC !!! NE ZNAM KAKO RADI !!!
        private String getMaxId()
        {
            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where has(n.id) return max(n.id)",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);

            String maxId = ((IRawGraphClient)client).ExecuteGetCypherResults<String>(query).ToList().FirstOrDefault();

            return maxId;
        }


    }
}
