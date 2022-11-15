using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PromiKlausur
{
    public class Spende
    {

               
       public static void SpendeHinzufuegen(string Spender, long Betrag)
       {
            if (!Datenbankverbindung.Oeffnen())
            {
                return;
            }

            MySqlCommand cmd = Datenbankverbindung.conn.CreateCommand();

            cmd.CommandText = "insert into spenden(spender,betrag) values(@Spender, @Betrag)";
            cmd.Parameters.AddWithValue("Spender", Spender);
            cmd.Parameters.AddWithValue("Betrag", Betrag);

            cmd.Prepare();

            cmd.ExecuteNonQuery();

            Datenbankverbindung.Schliessen();

        }

        public long id;
        string Name;
        public long Betrag;

        public Spende(long id, string Name, long Betrag)
        {
            this.id = id;
            this.Name = Name;
            this.Betrag = Betrag;
        }

 

        public override string ToString()
        {
            return Name;
        }
    }
}
