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
        public static bool tryTest(Projekat novi,GraphClient client)
        {

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
                    return false;
                }
                var range = Enumerable.Range(outInt,11-outInt).ToArray();
                var result = string.Join(" ", range);
                //.*[PHP C] [1 2 3 4 5 6].*
                query += "r.Iskustvo =~ \".*" + splited[0]+"."+"["+ result +"].*" + " or ";
            }
            query = query.TrimEnd("or ".ToCharArray());
            query += " return r";
            CypherQuery query1 = new CypherQuery(query, new Dictionary<string, object>(), CypherResultMode.Set);

            List<Radnik> listaRadnika = ((IRawGraphClient)client).ExecuteGetCypherResults<Radnik>(query1).ToList(); 
            //napokon imamo listu radnika sa znanjima

            return true;
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
