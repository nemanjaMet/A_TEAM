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


namespace A_TEAM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private GraphClient client;

        // --- Pozivanje forme za dodavanje osobe ---
        private void BtnAddPerson_Click(object sender, EventArgs e)
        {
            Adding_Person ap = new Adding_Person();
            ap.ShowDialog();
        }

        // --- Pozivanje forme za dodavanje development-a ---
        private void button2_Click(object sender, EventArgs e)
        {
            FDevelopment fd = new FDevelopment();
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
    }
}
