using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Neo4jClient;
using Neo4jClient.Cypher;
using A_TEAM.DomainModel;

namespace A_TEAM
{
    class Proveri_aktivne_projekte
    {
        System.Windows.Forms.Timer timer;
        Thread newThread;

        private GraphClient client;

        // --- konstruktor koji radi sa tajmerom ---
        public Proveri_aktivne_projekte(int sati, GraphClient gc)
        {
            client = gc;
            setTimer(sati);
            newThread = new Thread(new ThreadStart(proveriProjekte));
            newThread.Start();
        }
        
        // --- Setujemo tajmer ----
        private void setTimer(int interval)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = interval * 1000 * 3600; // sati
            //timer.Interval = interval * 1000; // sekunde radi testiranja
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        // --- Funkcija koja se poziva kada timer istekne ---
        private void timer_Tick(object sender, EventArgs e)
        {
           
            // --- Ispitujemo da li je thread vec kreiran ---
             if (newThread != null)
             {
                 // --- Ispitujemo da li je thread aktivan ---
                 if (!newThread.IsAlive)
                 {
                     newThread = new Thread(new ThreadStart(proveriProjekte));
                     newThread.Start();
                 }
             }
             else
             {
                 newThread = new Thread(new ThreadStart(proveriProjekte));
                 newThread.Start();
             }

        }

        // --- Funkcija koja stopira tajmer ---
        public void stopTimer()
        {
            timer.Stop();
        }

        // --- Funkcija koja se izvrsava kao novi thread ---
        private void proveriProjekte()
        {            
            CypherQuery vratiAktivneProjekte = new CypherQuery("match (n:Projekat)-[r:STATUS]->(m:Status_projekta) where  m.Ime='Aktivan' return n", new Dictionary<string, object>(), CypherResultMode.Set);
            var listaAktivnaProjekata = ((IRawGraphClient)client).ExecuteGetCypherResults<Projekat>(vratiAktivneProjekte).ToList();

            foreach (Projekat p in listaAktivnaProjekata)
            {
                DateTime danasnjiDatum = DateTime.Now.Date;
                DateTime krajnjiRok = Convert.ToDateTime(p.Rok_zavrsetka);

                // --- Ako je istekao rok, stavi projekat u zavrsene ---
                if (danasnjiDatum > krajnjiRok)
                {
                    string radniciNaProjektu = "";

                    // --- Vrati mi radnike na projektu --- 
                    CypherQuery vratiRadnikeNaProjektu = new CypherQuery("match (n:Radnik)-[r:ANGAZOVAN_NA]->(m:Projekat) where  m.Ime='" + p.Ime + "' return n", new Dictionary<string, object>(), CypherResultMode.Set);
                    var listaRadnika = ((IRawGraphClient)client).ExecuteGetCypherResults<Radnik>(vratiRadnikeNaProjektu).ToList();

                    // --- Uzimamo ID, IME i PREZIME ---
                    foreach (Radnik r in listaRadnika)
                    {
                        radniciNaProjektu += r.id + " " + r.Ime + " " + r.Prezime + ", ";
                    }
                    radniciNaProjektu = radniciNaProjektu.TrimEnd(", ".ToCharArray());

                    // --- Updateovanje atributa na projektu, tj. dodavanje radnika koji su radili na projektu ---
                    client.Cypher
                   .Match("(projekat:Projekat)")
                   .Where((Projekat projekat) => projekat.Ime == p.Ime)
                   .Set("projekat.Radnici_angazovani_na_projektu = {ranp}")
                   .WithParam("ranp", radniciNaProjektu)
                   .ExecuteWithoutResults();

                    // --- Brisanje svih veza na projektu ---
                    client.Cypher.Match("(projekat:Projekat)-[r]-() ")
                    .Where((Projekat projekat) => projekat.Ime == p.Ime)
                    .Delete("r")
                    .ExecuteWithoutResults();

                    // --- Stavljanje projekta u zavrsene (pravi se veza Projekat-Zavrsen), tj. Updatovanje Statusa ---
                    client.Cypher.Match("(projekat:Projekat)", "(zavrsen:Status_projekta)")
                   .Where((Projekat projekat) => projekat.Ime == p.Ime)
                   .AndWhere((Status_projekta zavrsen) => zavrsen.Ime == "Zavrsen")
                   .CreateUnique("projekat-[:STATUS]->zavrsen")
                   .ExecuteWithoutResults();
                }
            }
        }


    }
}
