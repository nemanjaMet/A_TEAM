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
    public partial class FDevelopment : Form
    {

        public GraphClient client;

        public FDevelopment()
        {
            InitializeComponent();
        }

        // --- Slanje podataka ---
        private void BtnSubmitData_Click(object sender, EventArgs e)
        {
            string ime = this.TbDevelopmentName.Text;
            string opis = this.TbOpis.Text;

            // --- Provera da li su uneti podaci ---
            if (String.IsNullOrWhiteSpace(ime))
            {
                MessageBox.Show("Unesite ime development-a!");
                return;
            }
            else if (String.IsNullOrWhiteSpace(opis))
            {
                MessageBox.Show("Unesite opis development-a!");
                return;
            }

            // Zatvaranje forme
            this.Dispose();
        }
    }
}
