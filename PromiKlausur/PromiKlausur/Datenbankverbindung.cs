using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PromiKlausur
{
    internal class Datenbankverbindung
    {
        public static MySqlConnection conn = new MySqlConnection("Server=localhost;Uid=root;Pwd=;Database=PromiKlausur;");

        public static bool Oeffnen()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Fehler beim öffnen der DB: " + ex.ToString());
                return false;
            }
        }
        public static void Schliessen()
        {
            conn.Close();
        }
    }
}
