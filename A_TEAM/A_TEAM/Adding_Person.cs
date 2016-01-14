using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_TEAM
{
    public partial class Adding_Person : Form
    {
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


            // Zatvaranje forme
            this.Dispose();
        }
    }
}
