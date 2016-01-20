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
using System.Text.RegularExpressions; // Za preciscavanje teksta

namespace A_TEAM
{
    public partial class FDodavanje_Razvoja : Form
    {

        public GraphClient client;

        public FDodavanje_Razvoja()
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

            // --- Preciscavamo tekst ---
            ime = checkString(ime);
            opis = checkString(opis);

            Razvoj noviRazvoj = new Razvoj();
            noviRazvoj.Ime = ime;
            noviRazvoj.Opis = opis;

            try
            {
                // --- Ubacivanje Razvoja u bazi (pravi duplikate za isti razvoj) ---
                /*client.Cypher
                .Create("(razvoj:Razvoj {noviRazvoj})")
                .WithParam("noviRazvoj", noviRazvoj)
                .ExecuteWithoutResults();*/

                // --- Ubacivanje Razvoja u bazi, ukoliko isti ne postoji ---
                // NEMA FEEDBACK UKOLIKO ISTI RAZVOJ POSTOJI
               /* client.Cypher
                .Merge("(razvoj:Razvoj { Ime: {Ime} })")
                .OnCreate()
                .Set("razvoj = {noviRazvoj}")
                .WithParams(new
                {
                    Ime = noviRazvoj.Ime,
                    noviRazvoj
                })
                .ExecuteWithoutResults();*/               
            
                Razvoj rez = client.Cypher
                .Merge("(razvoj:Razvoj { Ime: {Ime} })")
                .OnCreate()
                .Set("razvoj = {noviRazvoj}")
                .WithParams(new
                {
                    Ime = noviRazvoj.Ime,
                    noviRazvoj
                })
                .Return(razvoj => razvoj.As<Razvoj>())
                .Results.Single();

                if (noviRazvoj.Ime == rez.Ime && noviRazvoj.Opis == rez.Opis)
                {
                    MessageBox.Show("Uspesno kreiran razvoj!");
                }
                else
                {
                    MessageBox.Show("Takav razvoj vec postoji!");
                    return;
                }

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }

            // Zatvaranje forme
            this.Dispose();
        }

        // --- Funkcija za preciscavanje teksta ---
        private string checkString(string stringToCheck)
        {
            stringToCheck = Regex.Replace(stringToCheck, @"\t|\r", " ");
            stringToCheck = Regex.Replace(stringToCheck, @"( \n){2,}", "\n");
            stringToCheck = Regex.Replace(stringToCheck, " {2,}", " ");

            stringToCheck = stringToCheck.Trim();

            return stringToCheck;
        }
    }
}
