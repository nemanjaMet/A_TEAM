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
    public partial class FBrisanje_Razvoja : Form
    {

        public GraphClient client;

        public FBrisanje_Razvoja()
        {
            InitializeComponent();
        }

        // --- Brisanje Razvoja iz baze ---
        private void BtnIzbrisiRazvoj_Click(object sender, EventArgs e)
        {
            // --- Provera da li je selektovano nesto u listView ---
            if (LvSpisakRazvoja.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selektujte neki razvoj!");
                return;
            }

            try
            {
                string imeRazvoja = LvSpisakRazvoja.SelectedItems[0].Text;

                // --- Brisanje razvoja iz baze i svih njegovih veza |*DetachDelete*| ---
                    client.Cypher
                    .Match("(razvoj:Razvoj)")
                    .Where((Razvoj razvoj) => razvoj.Ime == imeRazvoja)
                    .DetachDelete("razvoj")
                    .ExecuteWithoutResults();

                // --- Brisanje iz listView ----
                LvSpisakRazvoja.SelectedItems[0].Remove();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        // --- Popunjavanje listView Razvojima ---
        private void FBrisanje_Razvoja_Shown(object sender, EventArgs e)
        {
            try
            {
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
