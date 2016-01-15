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

                LvSpisakRazvoja.SelectedItems[0].Remove();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }
    }
}
