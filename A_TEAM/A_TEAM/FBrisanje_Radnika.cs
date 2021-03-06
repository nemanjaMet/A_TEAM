﻿using System;
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
    public partial class FBrisanje_Radnika : Form
    {

        public GraphClient client;

        public FBrisanje_Radnika()
        {
            InitializeComponent();
        }


        // --- Popunjavanje listView podacima iz baze ---
        private void FBrisanje_Radnika_Shown(object sender, EventArgs e)
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

                   LvSpisakRadnika.Items.Add(lv1);
               }

               LvSpisakRadnika.Enabled = true;
                
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        // --- Brisanje radnika iz baze ---
        private void BtnIzbrisiRadnika_Click(object sender, EventArgs e)
        {
            // --- Provera da li je nesto seletovano u listi ---
            if (LvSpisakRadnika.SelectedItems.Count != 0)
            {
                string idRadnika = LvSpisakRadnika.SelectedItems[0].SubItems[0].Text;
                try
                {
                    
                    // --- Brisanje radnika iz baze i svih njegovih veza |*DetachDelete*| ---
                     client.Cypher
                    .Match("(radnik:Radnik)")
                    .Where((Radnik radnik) => radnik.id == idRadnika)
                    .DetachDelete("radnik")
                    .ExecuteWithoutResults();

                     LvSpisakRadnika.SelectedItems[0].Remove();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.ToString());
                }               
            }
            else
            {
                MessageBox.Show("Selektuj nekog radnika!");
            }
        }


    }
}
