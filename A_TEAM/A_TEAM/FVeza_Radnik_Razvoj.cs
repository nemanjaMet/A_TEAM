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
    public partial class FVeza_Radnik_Razvoj : Form
    {
        public GraphClient client;

        public FVeza_Radnik_Razvoj()
        {
            InitializeComponent();
        }

        // --- Kreiraj vezi Radnik-Razvoj ---
        private void BtnKreirajVezu_Click(object sender, EventArgs e)
        {
            if (LvSpisakRadnika.SelectedItems.Count != 0 && LvSpisakRazvoja.SelectedItems.Count != 0)
            {
                string idRadnika = LvSpisakRadnika.SelectedItems[0].SubItems[0].Text;
                string imeRazvoja = LvSpisakRazvoja.SelectedItems[0].Text;

                try
                {
                    // --- Upit za kreiranje veze 'RADI_U' izmedju Radnika i Razvoja
                    client.Cypher.Match("(radnik1:Radnik)", "(razvoj1:Razvoj)")
                        .Where((Radnik radnik1) => radnik1.id == idRadnika)
                        .AndWhere((Razvoj razvoj1) => razvoj1.Ime == imeRazvoja)
                        .CreateUnique("radnik1-[:RADI_U]->razvoj1")
                        .ExecuteWithoutResults();

                    MessageBox.Show("Uspesno kreirana veza!");
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.ToString());
                }
            }
            else
            {
                MessageBox.Show("Selektujte prvo Razvoj i Radnika!");
            }
        }

        // --- Popunjavanje liste Radnicima i Razvojima ---
        private void FVeza_Radnik_Razvoj_Shown(object sender, EventArgs e)
        {
            try
            {
                // --- Radnici ---
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


                // --- Razvoji ---
                IList<Razvoj> listaRazvoja = new List<Razvoj>();

                listaRazvoja = client.Cypher
                .Match("(razvoj:Razvoj)")
                .Return(razvoj => razvoj.As<Razvoj>())
                .Results.ToList();

                foreach (Razvoj r in listaRazvoja)
                {
                    ListViewItem lv1 = new ListViewItem(r.Ime);
                    lv1.SubItems.Add(r.Opis);

                    LvSpisakRazvoja.Items.Add(lv1);
                }

                LvSpisakRazvoja.Enabled = true;

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }
    }
}
