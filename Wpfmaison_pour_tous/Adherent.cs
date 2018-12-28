using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Wpfmaison_pour_tous
{
    public class Adherent
    {

        DataTable aadhff { get; set; }

        public DataTable afficher(DataTable adhff) {
            MySqlConnection toto = new MySqlConnection("SERVER=127.0.0.1 ; DATABASE=maisonpourtous ; UID=root ; pwd=");
            toto.Open();
            this.aadhff = adhff;
            string select = "SELECT numAdherent,nomAdherent,prenomAdherent FROM adherent";
            MySqlDataAdapter totselect = new MySqlDataAdapter(select, toto);
            totselect.Fill(aadhff);
            totselect.Dispose();
            toto.Close();
            return aadhff;
        }
    }
}
