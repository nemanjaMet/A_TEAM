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
    }
}
