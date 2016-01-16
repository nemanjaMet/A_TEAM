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
                    try
                    {
                        // --- UPITI ZA TRAZENJE VEZA ZA DATOG RADNIKA ---
                        
                        // ******** MESTA ZA PERU DA MOZE DA RADI :) **************

                        // --- Klirujemo listViews za nove podatke ---
                        LvSpisakSlazeSe.Items.Clear();
                        LvNeutralan.Items.Clear();
                        LvNeSlazeSe.Items.Clear();
                        LvSpisakRazvoja.Items.Clear();
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
                try
                {
                    // ************ MESTA ZA PERU **************
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
                try
                {
                    // ************ MESTA ZA PERU **************
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
                try
                {
                    // ************ MESTA ZA PERU **************
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
                try
                {
                    // ************ MESTA ZA PERU **************
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

                    string iskustvo = "";
                    foreach (string s in r.Iskustvo)
                    {
                        iskustvo += s + ", ";
                    }
                    iskustvo = iskustvo.Remove(iskustvo.Length - 2);
                    lv1.SubItems.Add(iskustvo);

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
