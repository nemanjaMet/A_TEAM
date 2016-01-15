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
                Radnik noviRadnik = new Radnik();

                // ********* NECEMO OVAKO ********* //
                string maxId = getMaxId();
                try
                {
                    int mId = Int32.Parse(maxId);
                    noviRadnik.id = (mId++).ToString();
                }
                catch (Exception exception)
                {
                    noviRadnik.id = "";
                }
                // **************************** //

                noviRadnik.Ime = ime;
                noviRadnik.Prezime = prezime;
                noviRadnik.Adresa = adresa;
                noviRadnik.Datum_Rodjenja = datumRodjenja;
                noviRadnik.Iskustvo = lista;
                noviRadnik.Obrazovanje = obrazovanje;

                client.Cypher
                .Create("(radnik:Radnik {noviRadnik})")
                .WithParam("noviRadnik", noviRadnik)
                .ExecuteWithoutResults();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }

            // Zatvaranje forme
            this.Dispose();
        }


        // !!! COPY PASTO BOGDANOVIC !!! NE ZNAM KAKO RADI !!!
        public String getMaxId()
        {
            var query = new Neo4jClient.Cypher.CypherQuery("start n=Radnik(*) where has(n.id) return max(n.id)",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);
            
            String maxId = ((IRawGraphClient)client).ExecuteGetCypherResults<String>(query).ToList().FirstOrDefault();

            return maxId;
        }


    }
}
