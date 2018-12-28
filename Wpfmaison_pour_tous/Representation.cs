using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Wpfmaison_pour_tous
{
    public class Representation
    {
        DataTable aff { get; set; }

        public DataTable afficher(DataTable Aff) {
            MySqlConnection toto = new MySqlConnection("SERVER=127.0.0.1 ; DATABASE=maisonpourtous ; UID=root ; pwd=");
            toto.Open();
            this.aff = Aff;
            string select = "SELECT numRepresentation,DATE_FORMAT(dateRepresentation,'%d/%m/%Y'), tarif ,nomSpectacle FROM representation JOIN spectacle on representation.numSpectacle=spectacle.numSpectacle";
            MySqlDataAdapter totselect = new MySqlDataAdapter(select, toto);
            totselect.Fill(aff);
            totselect.Dispose();
            toto.Close();
            return aff;
        }
    }
}
