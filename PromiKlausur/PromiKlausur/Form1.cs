using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PromiKlausur
{
    public partial class Form1 : Form
    {

        List<Spende> alleSpender = new List<Spende>();
        private MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
           
            
            //Fortschrittsbalken aktualisieren
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT SUM(Betrag) AS Summe FROM spenden";
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int summe = reader.GetInt32(0);
                pbFortschrittsbalken.Value = summe;
                
            }
            reader.Close();

            //Liste aktualisieren
            alleSpender.Clear();
            lbSpender.Items.Clear();
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id, Spender, Betrag FROM `spenden` order by id desc limit 0,5";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                long id = reader.GetInt64(0);
                string Spender = reader.GetString(1);
                long Betrag = reader.GetInt64(0);

                Spende s = new Spende(id, Spender, Betrag);
                alleSpender.Add(s);
                lbSpender.Items.Add(s.ToString());

            }
            reader.Close();
    
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            timer1.Enabled = false;
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection("Server=localhost;Uid=root;Pwd=;Database=PromiKlausur;");
            conn.Open();

            
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            string Spender = tbAnrufer.Text;
            if (Spender.Length == 0)
            {
                MessageBox.Show("Bitte fügen Aufgaben hinzu!");
                return;
            }
            decimal Betrag = nudBetrag.Value;
            //TODO prüfen, dass der Betrag nicht 0 ist

            Spende.SpendeHinzufuegen(Spender, (long)Betrag);

            tbAnrufer.Text = "";
        }
    }
}
