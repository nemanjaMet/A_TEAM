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
    public partial class FBrisanje_Razvoja : Form
    {

        public GraphClient client;

        public FBrisanje_Razvoja()
        {
            InitializeComponent();
        }
    }
}
