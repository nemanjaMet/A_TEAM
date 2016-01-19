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
    public partial class FBrisanje_Projekta : Form
    {
        public GraphClient client;

        public FBrisanje_Projekta()
        {
            InitializeComponent();
        }

        // --- Popunjavanje liste projektima ---
        private void FBrisanje_Projekta_Shown(object sender, EventArgs e)
        {
            try
            {
                IList<Projekat> listaProjekta = new List<Projekat>();

                listaProjekta = client.Cypher
                .Match("(projekat:Projekat)")
                .Return(projekat => projekat.As<Projekat>())
                .Results.ToList();

                foreach (Projekat p in listaProjekta)
                {
                    ListViewItem lv1 = new ListViewItem(p.Ime);
                    lv1.SubItems.Add(p.Rok_zavrsetka);
                    lv1.SubItems.Add(p.Potrebno_iskustvo);
                    lv1.SubItems.Add(p.Potrebni_ljudi_iz_razvoja);

                    // !!! Nije vise lista !!!
                    /*string potrebnoIskustvo = "";
                    foreach (string s in p.Potrebno_iskustvo)
                    {
                        potrebnoIskustvo += p + ", ";
                    }
                    potrebnoIskustvo = potrebnoIskustvo.Remove(potrebnoIskustvo.Length - 2);
                    lv1.SubItems.Add(potrebnoIskustvo);

                    string PotrebniLjudiIzRazvoja = "";
                    foreach (string s in p.Potrebni_ljudi_iz_razvoja)
                    {
                        PotrebniLjudiIzRazvoja += p + ", ";
                    }
                    PotrebniLjudiIzRazvoja = PotrebniLjudiIzRazvoja.Remove(PotrebniLjudiIzRazvoja.Length - 2);
                    lv1.SubItems.Add(potrebnoIskustvo);*/

                    LvSpisakProjekata.Items.Add(lv1);
                }

                LvSpisakProjekata.Enabled = true;

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        // --- Brisanje projekta iz baze ---
        private void BtnIzbrisiProjekat_Click(object sender, EventArgs e)
        {
            if (LvSpisakProjekata.SelectedItems.Count != 0)
            {
                string imeProjekta = LvSpisakProjekata.SelectedItems[0].SubItems[0].Text;
                try
                {                                     
                        // --- Brisanje radnika iz baze i svih njegovih veza |*DetachDelete*| ---
                        client.Cypher
                       .Match("(projekat:Projekat)")
                       .Where((Projekat projekat) => projekat.Ime == imeProjekta)
                       .DetachDelete("projekat")
                       .ExecuteWithoutResults();

                        LvSpisakProjekata.SelectedItems[0].Remove();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.ToString());
                }
            }
            else
            {
                MessageBox.Show("Selektujte prvo projekat koji hocete da izbrisete!");
            }
        }
    }
}
