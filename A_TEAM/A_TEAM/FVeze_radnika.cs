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
    public partial class FVeze_radnika : Form
    {

        public GraphClient client;

        public FVeze_radnika()
        {
            InitializeComponent();
        }

        // --- Dodavanje veze izmedju radnika ---
        private void BtnDodajVezu_Click(object sender, EventArgs e)
        {
            // Provera validnosti podataka
            if (Convert.ToInt32(comboBox1.SelectedIndex) == -1)
            {
                MessageBox.Show("Izaberite vezu izmedju radnika!");
                return;
            }
            else if (LvOsobe1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selektujte osobu 1!");
                return;
            }
            else if (LvOsobe2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selektujte osobu 2!");
                return;
            }
            else if (LvOsobe1.SelectedItems[0].SubItems[1].Text == LvOsobe2.SelectedItems[0].SubItems[1].Text)
            {
                MessageBox.Show("Veza izmedju dve iste osobe nije moguca!");
                return;
            }


            string veza = comboBox1.SelectedItem.ToString();
            string osoba1 = LvOsobe1.SelectedItems[0].SubItems[1].Text;
            string osoba2 = LvOsobe2.SelectedItems[0].SubItems[1].Text;
            
            // --- Kreiranje veze u bazi izmedju radnika ---
            try
            {
                // --- Upit za dodavanje veze ---
                client.Cypher.Match("(radnik1:Radnik)", "(radnik2:Radnik)")
                .Where((Radnik radnik1) => radnik1.Ime == osoba1)
                .AndWhere((Radnik radnik2) => radnik2.Ime == osoba2)
                .CreateUnique("radnik1-[:" + veza + "]->radnik2")
                .ExecuteWithoutResults();



                MessageBox.Show("Uspesno kreirana veza!");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }           

        }

        // --- Popunjavanje listi radnicima ---
        private void FVeze_radnika_Shown(object sender, EventArgs e)
        {
            try
            {
                IList<Radnik> listaRadnika = new List<Radnik>();

                // --- Upit za vracanje radnika ---
                listaRadnika = client.Cypher
                .Match("(radnik:Radnik)")
                .Return(radnik => radnik.As<Radnik>())
                .Results.ToList();

                foreach (Radnik r in listaRadnika)
                {
                    ListViewItem lv1 = new ListViewItem(r.id);
                    lv1.SubItems.Add(r.Ime);
                    lv1.SubItems.Add(r.Prezime);

                    ListViewItem lv2 = new ListViewItem(r.id);
                    lv2.SubItems.Add(r.Ime);
                    lv2.SubItems.Add(r.Prezime);

                    LvOsobe1.Items.Add(lv1);
                    LvOsobe2.Items.Add(lv2);
                }

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }
    }
}
