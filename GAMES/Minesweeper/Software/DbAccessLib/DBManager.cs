using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccessLib
{
    public class DBManager
    {
        #region Fields and Properties
        private List<Player> players;
        #endregion

        #region Methods
        public List<Player> FindPlayer(string connect, string name)
        {
            this.players.Clear();
            try
            {
                MySqlConnection connection = new MySqlConnection(@connect);
                MySqlCommand readCommand = new MySqlCommand("SELECT * FROM player", connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(readCommand);
                DataTable playertable = new DataTable();
                adapter.Fill(playertable);

                for (int i = 0; i < playertable.Rows.Count; i++)
                {
                    object[] player = playertable.Rows[i].ItemArray;
                    if ((string)player[1] == name)
                    {
                        if (player[3].ToString() == "")
                        {
                            this.players.Add(new Player((int)player[0],(string)player[1], (string)player[2], 0, player[4].ToString()));
                        }
                        else
                        {
                            this.players.Add(new Player((int)player[0], (string)player[1], (string)player[2], (int)player[3], player[4].ToString()));
                        }
                    }
                }
                connection.Close();
                return this.players;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

          return this.players;
        }

        public void UpdateDB(string name, string level, int highscore, string connect)
        {
            MySqlConnection connection = new MySqlConnection(@connect);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;

            cmd.CommandText = "INSERT INTO player (Name,Level,Highscore) VALUES(@Name,@Level,@Highscore)";
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Level", level);
            cmd.Parameters.AddWithValue("@Highscore", highscore);

            cmd.ExecuteNonQuery();
            connection.Close();

        }


        #endregion

        #region Constructors
        public DBManager()
        {
            this.players = new List<Player>();
        }
        #endregion
    }
}
