using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace dessida.Sql
{
    class mysql
    {
        //Liste des stored procédure
        private string A_emplacement = "A_Emplacement";

        public string Ajout_Emplacement
        {
            get { return A_emplacement; }
            set { A_emplacement = value; }
        }
    }
}
