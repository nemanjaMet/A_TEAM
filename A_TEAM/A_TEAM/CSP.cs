using A_TEAM.DomainModel;
using Neo4jClient;
using Neo4jClient.Cypher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_TEAM
{
    public  class CSP
    {
        public static List<Radnik> tryTest(Projekat novi,GraphClient client)
        {
            string[] razvojIbrojLjudi = novi.Potrebni_ljudi_iz_razvoja.Split(',');
            int ukupanBroj = 0;
            for(int i = 0 ; i < razvojIbrojLjudi.Length ; i++)
            {
                string[] split = razvojIbrojLjudi[i].Split(' ');
                int parsovanBroj = 0;
                bool done = Int32.TryParse(split[1], out parsovanBroj);
                if(done)
                {
                    ukupanBroj += parsovanBroj;
                }
            }
            if(ukupanBroj == 0)
            {
                return null;
            }

            string[] jezikIznanje = novi.Potrebno_iskustvo.Split(',');
            // ide r.Iskustvo =~ "splited[0] [splited[1]...10]" + or 
            string query = "match (r:Radnik) where ";

            foreach (string jezik in jezikIznanje)
            {
                //nulta lokacija jezik a na prvoj ocena 1-10
                int outInt=0;
                
                string[] splited = jezik.Split(' ');
                bool done = Int32.TryParse(splited[1] , out outInt);
                if(!done)
                {
                    return null;
                }
                string result = "";
                if(outInt == 10)
                {
                    result = "10";
                }
                else
                {
                    var range = Enumerable.Range(outInt, 10 - outInt).ToArray();
                    result = string.Join(" ", range);
                }
                
                //.*[PHP C] [1 2 3 4 5 6].*
                query += "r.Iskustvo =~ \".*" + splited[0]+"."+"["+ result +"].*\"" + " or ";
            }
            query = query.TrimEnd("or ".ToCharArray());
            query += " return r";

            CypherQuery query1 = new CypherQuery(query, new Dictionary<string, object>(), CypherResultMode.Set);
            CypherQuery query2 = new CypherQuery(query+".id", new Dictionary<string, object>(), CypherResultMode.Set);

            List<Radnik> listaRadnika = ((IRawGraphClient)client).ExecuteGetCypherResults<Radnik>(query1).ToList();
            int ukupnoRadnika = listaRadnika.Count;
            int trecina = ukupnoRadnika / 3;
            var IDs = ((IRawGraphClient)client).ExecuteGetCypherResults<string>(query2).ToList();
            string idPattern = "[" + string.Join(" ", IDs) + "]";

            List<Radnik> izabrani = new List<Radnik>();
            //napokon imamo listu radnika sa znanjima
            for (int i = listaRadnika.Count-1; i >= 0; i--)
            {
                string id = listaRadnika[i].id;
                
                query = "match (n:Radnik)-[r:NE_SLAZE_SE]->(m:Radnik) where n.id=~\"" + idPattern + "\"" + "and m.id=\"" + id + "\" return count(n)";
                CypherQuery query3 = new CypherQuery(query, new Dictionary<string, object>(), CypherResultMode.Set);
                int broj = ((IRawGraphClient)client).ExecuteGetCypherResults<int>(query3).Single();
                if (broj > trecina)
                {
                    listaRadnika.RemoveAt(i);
                }
                if(broj == 0)
                {
                    query = "match (n:Radnik)-[r:SLAZE_SE]->(m:Radnik) where n.id=~\"" + id + "\" return m";
                    CypherQuery query4 = new CypherQuery(query, new Dictionary<string, object>(), CypherResultMode.Set);
                    List<Radnik> friends = ((IRawGraphClient)client).ExecuteGetCypherResults<Radnik>(query4).ToList();
                    if (izabrani.Count + friends.Count < ukupanBroj)
                    {
                        izabrani.Add(listaRadnika[i]);
                        izabrani = izabrani.Concat<Radnik>(friends).ToList();
                    }
                    else
                    {
                        int koliko = ukupanBroj - izabrani.Count;
                        for(int j = 0 ; j < koliko-1; j ++)
                        {
                            izabrani.Add(friends[j]);
                        }
                    }
                }
                //client.Cypher.Match("(projekat:Projekat)", "(radnik:Radnik)")
                //       .Where((Projekat projekat) => projekat.Ime == novi.Ime)
                //       .AndWhere((Radnik radnik) => radnik.id == )
                //       .CreateUnique("projekat<-[:ANGAZOVAN_NA]-radnik")
                //       .ExecuteWithoutResults();
            }
            //
            //query = "match (n:Radnik)-[r:SLAZE_SE]->(m:Radnik) where n.id=~\"" + id + "\" return m";
            //CypherQuery query5 = new CypherQuery(query, new Dictionary<string, object>(), CypherResultMode.Set);

                return izabrani;
        }

        public static bool createTestData(GraphClient client)
        {
            //hardcodirano --- testing purposes ---
            string[] skillSet = { "C#", "JavaScript", "PHP", "C", "Java", "C++", "SQL" };
            string[] relations = { "NE_SLAZE_SE", "NEUTRALAN", "SLAZE_SE" };
            try
            {
                int idRadnika = 0;
                idRadnika = client.Cypher
                .Match("(n:Radnik)")
                .Return(() => Return.As<int>("max(n.id)"))
                .Results
                .Single();

                idRadnika++;
                for (int i = 0; i < 50; i++)
                {
                    Random integer = new Random();
                    int randIndex1 = integer.Next(skillSet.Length);
                    int randIndex3 = (randIndex1 + 1) % skillSet.Length;
                    int randIndex2 = (randIndex1 + 2) % skillSet.Length;

                    Radnik noviRadnik = new Radnik();
                    //noviRadnik.id = idRadnika;
                    noviRadnik.id = idRadnika.ToString();
                    noviRadnik.Ime = "Radnik" + i.ToString();
                    noviRadnik.Prezime = "Prezime";
                    noviRadnik.Adresa = "Nis";
                    noviRadnik.Datum_Rodjenja = "1/1/2008";
                    if (i % 2 == 0)
                    {
                        noviRadnik.Iskustvo = skillSet[randIndex1] + " " + (i % 10 + 1).ToString() + "," + skillSet[randIndex2] + " " + (10 - i % 10 + 1).ToString();
                    }
                    else
                    {
                        noviRadnik.Iskustvo = skillSet[randIndex1] + " " + (i % 10 + 1).ToString() + "," + skillSet[randIndex2] + " " + (10 - i % 10 + 1).ToString() + "," + skillSet[randIndex3] + " " + (randIndex3 + 3).ToString();
                    }

                    noviRadnik.Obrazovanje = "Osnovne akademske studije";
                    client.Cypher
                    .Merge("(radnik:Radnik { id: {id} })")
                    .OnCreate()
                    .Set("radnik = {noviRadnik}")
                    .WithParams(new
                    {
                        id = noviRadnik.id,
                        noviRadnik
                    })
                    .ExecuteWithoutResults();

                    idRadnika++;
                }
                //veze izmedju test Radnika
                //35 veza
                for (int i = 0; i < 50; i++)
                {
                    Random integer = new Random();
                    int randIndex1 = integer.Next(relations.Length);

                    int indexRadnika1 = integer.Next(50); //random indexi za radnike
                    int indexRadnika2 = integer.Next(50);

                    if (indexRadnika1 == indexRadnika2) //check da li su isti (ne smeju da budu)
                    {
                        if (++indexRadnika2 > 49) //granicni slucaj ako povecamo index radnika i on ispadne iz opsega
                        {
                            indexRadnika2 = 0; //onda ga vratimo na pocetak
                        }
                    }
                    string radnik1Name = "Radnik" + indexRadnika1.ToString();
                    string radnik2Name = "Radnik" + indexRadnika2.ToString();
                    client.Cypher.Match("(radnik1:Radnik)", "(radnik2:Radnik)")
                    .Where((Radnik radnik1) => radnik1.Ime == radnik1Name)
                    .AndWhere((Radnik radnik2) => radnik2.Ime == radnik2Name)
                    .CreateUnique("radnik1-[:" + relations[randIndex1] + "]->radnik2")
                    .ExecuteWithoutResults();


                }
                //trim query koji otklanja sve test Radnike koji nisu povezani ni sa jednim radnikom
                var query = new Neo4jClient.Cypher.CypherQuery("match (n:Radnik {Prezime:\"Prezime\"}) where not(n)--() delete n",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);

                ((IRawGraphClient)client).ExecuteCypher(query);


                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in CSP create data \n Exception msg:" + ex.Message + "\n InnerException msg:" + ex.InnerException.Message + "\n");
                return false;
            }
        }
    }
}
