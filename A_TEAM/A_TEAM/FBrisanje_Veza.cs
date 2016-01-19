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

namespace A_TEAM.DomainModel
{
    public partial class FBrisanje_Veza : Form
    {
        public GraphClient client;
        string poslednjiSelektovani = "";
        public FBrisanje_Veza()
        {
            InitializeComponent();
        }

        // --- Prikazivanje svih veza selektovanog radnika ---
        private void BtnPogledajSelektovanogRadnika_Click(object sender, EventArgs e)
        {
            if (LvSpisakRadnika.SelectedItems.Count != 0)
            {
                string IDRadnika = LvSpisakRadnika.SelectedItems[0].SubItems[0].Text;
                // --- Provera da se ne pozivaju vise upita za istog radnika ---
                if (IDRadnika != poslednjiSelektovani)
                {
                    // --- Klirujemo listViews za nove podatke ---
                    LvSpisakSlazeSe.Items.Clear();
                    LvNeutralan.Items.Clear();
                    LvNeSlazeSe.Items.Clear();
                    LvSpisakRazvoja.Items.Clear();

                    try
                    {
                        // --- UPITI ZA TRAZENJE VEZA ZA SELEKTOVANOG RADNIKA ---                  
                        // --- Trazi veze izmedju radnika (SLAZE_SE, NEUTRALAN, NE_SLAZE_SE) ---
                        var query = client.Cypher
                        .Match("(n:Radnik)-[r]->(m:Radnik)")
                        .Where((Radnik n) => n.id == IDRadnika)
                        .Return((n, r, m) => new
                         {
                         N = n.As<Radnik>(),
                         M = m.As<Radnik>(),
                         R = r.As<RelationshipInstance<object>>()

                        });

                        // --- Popunjavamo liste za veze sa radnicima ---
                        var res = query.Results;
                        foreach (var item in res.ToList())
                        {
                            ListViewItem lv = new ListViewItem(item.M.id);
                            lv.SubItems.Add(item.M.Ime);
                            lv.SubItems.Add(item.M.Prezime);
                            var veza = item.R.TypeKey;

                            if (veza == "SLAZE_SE")
                            {
                                LvSpisakSlazeSe.Items.Add(lv);
                            }
                            else if (veza == "NEUTRALAN")
                            {
                                LvNeutralan.Items.Add(lv);
                            }
                            else if (veza == "NE_SLAZE_SE")
                            {
                                LvNeSlazeSe.Items.Add(lv);
                            }
                        }

                        // --- Upit za vracanje razvoja u kojem selektovani radnik radi ---
                        var query1 = client.Cypher
                       .Match("(n:Radnik)-[r]->(m:Razvoj)")
                       .Where((Radnik n) => n.id == IDRadnika)
                       .Return((n, r, m) => new
                       {
                           N = n.As<Radnik>(),
                           M = m.As<Razvoj>(),
                           R = r.As<RelationshipInstance<object>>()
                       });

                        // --- Popunjavamo listu za razvoj sa Razvojima ----
                        var res1 = query1.Results;
                        foreach (var item in res1.ToList())
                        {
                            ListViewItem lv = new ListViewItem(item.M.Ime);
                            lv.SubItems.Add(item.M.Opis);
                            var veza = item.R.TypeKey;
                            LvSpisakRazvoja.Items.Add(lv);
                        }

                        // --- Otkljucavamo liste (nema nikakvu svrhu, ali smo u mogucnosti :) ) ---
                        LvSpisakSlazeSe.Enabled = true;
                        LvNeutralan.Enabled = true;
                        LvNeSlazeSe.Enabled = true;
                        LvSpisakRazvoja.Enabled = true;
                        
                    }
                    catch (Exception ec)
                    {
                        MessageBox.Show(ec.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Taj radnik je trenutno i selektovan!");
                }
            }
            else
            {
                MessageBox.Show("Selektujte nekog radnika prvo!");
            }
        }

        // --- Brisanje veze 'Slaze se' ----
        private void BtnIzbrisiVezuSlazeSe_Click(object sender, EventArgs e)
        {
            if (LvSpisakSlazeSe.SelectedItems.Count != 0)
            {
                string IDRadnika = LvSpisakSlazeSe.SelectedItems[0].SubItems[0].Text;
                string IDRadnika1 = LvSpisakRadnika.SelectedItems[0].SubItems[0].Text;
                try
                {
                   
                    // --- Upit za brisanje veze ---
                    client.Cypher.Match("(radnik1:Radnik)-[r]->(radnik2:Radnik) ")
                        .Where((Radnik radnik1) => radnik1.id == IDRadnika1)
                        .AndWhere((Radnik radnik2) => radnik2.id == IDRadnika)
                        .Delete("r")
                        .ExecuteWithoutResults();

                    LvSpisakSlazeSe.SelectedItems[0].Remove();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.ToString());
                }
            }
            else
            {
                MessageBox.Show("Niste nikog selektovali iz spiska 'Slaze se'!");
            }
        }

        // --- Brisanje veze 'Neutralan' ----
        private void BtnIzbrisiVezuNeutralan_Click(object sender, EventArgs e)
        {
            if (LvNeutralan.SelectedItems.Count != 0)
            {
                string IDRadnika = LvNeutralan.SelectedItems[0].SubItems[0].Text;
                string IDRadnika1 = LvSpisakRadnika.SelectedItems[0].SubItems[0].Text;
                try
                {
                    // --- Upit za brisanje veze ---
                    client.Cypher.Match("(radnik1:Radnik)-[r]->(radnik2:Radnik) ")
                        .Where((Radnik radnik1) => radnik1.id == IDRadnika1)
                        .AndWhere((Radnik radnik2) => radnik2.id == IDRadnika)
                        .Delete("r")
                        .ExecuteWithoutResults();

                    LvNeutralan.SelectedItems[0].Remove();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.ToString());
                }
            }
            else
            {
                MessageBox.Show("Niste nikog selektovali iz spiska 'Neutralan'!");
            }
        }

        // --- Brisanje veze 'Ne slaze se' ----
        private void BtnIzbrisiVezuNeSlazeSe_Click(object sender, EventArgs e)
        {
            if (LvNeSlazeSe.SelectedItems.Count != 0)
            {
                string IDRadnika = LvNeSlazeSe.SelectedItems[0].SubItems[0].Text;
                string IDRadnika1 = LvSpisakRadnika.SelectedItems[0].SubItems[0].Text;
                try
                {
                    // --- Upit za brisanje veze ----
                    client.Cypher.Match("(radnik1:Radnik)-[r]->(radnik2:Radnik) ")
                         .Where((Radnik radnik1) => radnik1.id == IDRadnika1)
                         .AndWhere((Radnik radnik2) => radnik2.id == IDRadnika)
                         .Delete("r")
                         .ExecuteWithoutResults();

                    LvNeSlazeSe.SelectedItems[0].Remove();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.ToString());
                }
            }
            else
            {
                MessageBox.Show("Niste nikog selektovali iz spiska 'Ne slaze se'!");
            }
        }

        // --- Brisanje veze ka razvoju ---
        private void BtnIzbrisiVezuKaRazvoju_Click(object sender, EventArgs e)
        {
            if (LvSpisakRazvoja.SelectedItems.Count != 0)
            {
                string imeRazvoja = LvSpisakRazvoja.SelectedItems[0].SubItems[0].Text;
                string IDRadnika1 = LvSpisakRadnika.SelectedItems[0].SubItems[0].Text;
                try
                {
                    // --- Upit za brisanje veze ---
                    client.Cypher.Match("(radnik1:Radnik)-[r]->(razvoj1:Razvoj) ")
                        .Where((Radnik radnik1) => radnik1.id == IDRadnika1)
                        .AndWhere((Razvoj razvoj1) => razvoj1.Ime == imeRazvoja)
                        .Delete("r")
                        .ExecuteWithoutResults();

                    LvSpisakRazvoja.SelectedItems[0].Remove();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.ToString());
                }
            }
            else
            {
                MessageBox.Show("Niste nikog selektovali iz spiska ''!");
            }
        }

        // ---- Popunjavanje forme sa radnicima ----
        private void FBrisanje_Veza_Shown(object sender, EventArgs e)
        {
            try
            {
                IList<Radnik> listaRadnika = new List<Radnik>();

                listaRadnika = client.Cypher
                .Match("(radnik:Radnik)")
                .Return(radnik => radnik.As<Radnik>())
                .Results.ToList();

                foreach (Radnik r in listaRadnika)
                {
                    ListViewItem lv1 = new ListViewItem(r.id);
                    lv1.SubItems.Add(r.Ime);
                    lv1.SubItems.Add(r.Prezime);
                    lv1.SubItems.Add(r.Adresa);
                    lv1.SubItems.Add(r.Datum_Rodjenja);
                    lv1.SubItems.Add(r.Obrazovanje);
                    lv1.SubItems.Add(r.Iskustvo);

                    // !!! Nije vise lista !!!
                   /* string iskustvo = "";
                    foreach (string s in r.Iskustvo)
                    {
                        iskustvo += s + ", ";
                    }
                    iskustvo = iskustvo.Remove(iskustvo.Length - 2);
                    lv1.SubItems.Add(iskustvo);*/

                    LvSpisakRadnika.Items.Add(lv1);
                }

                LvSpisakRadnika.Enabled = true;

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }
    }
}
