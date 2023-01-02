using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Classes
{
    public  class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Score { get; set; }
        public int NumberOfGames { get; set; }
        public bool isAdmin { get; set; }


        public Player(int id, string name, string password, int score, int numberOfGames, bool isadmin)
        {
            Id = id;
            Name = name;
            Password = password;
            Score = score;
            NumberOfGames = numberOfGames;
            isAdmin = isadmin;
        }

        public Player() { }

        string conn = "Data Source=windows-8ufdtpu\\sqlexpress;Initial Catalog=Game;Integrated Security=true;TrustServerCertificate=True;";

        public IEnumerable<Player> GetPlayers()
        {
            List<Player> listOfPlayers = new List<Player>();


            using (SqlConnection sqlConnection = new SqlConnection(conn))
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Game_Minesweeper", sqlConnection);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    using (DataSet dataSet = new DataSet())
                    {
                        adapter.Fill(dataSet, "Game_Minesweeper");
                        foreach (DataRow row in dataSet.Tables["Game_Minesweeper"].Rows)
                        {
                            Player player = new Player();
                            player.Id = (int)row["ID"];
                            player.Name = (string)row["Player_name"];
                            player.Password = (string)row["Password"];
                            var score=row["Score"];
                            if (score.ToString()!="")
                            {
                                player.Score = (int)score;
                            }
                            else
                            {
                                player.Score = 0;
                            }
                            
                            var numberOfgames= row["Number_of_games"];
                            if (numberOfgames.ToString()!="")
                            {
                                player.NumberOfGames = (int)numberOfgames;
                            }
                            else
                            {
                                player.NumberOfGames = 0;
                            }

                            var isadmin = row["IsAdmin"];
                            

                            
                            if(isadmin.ToString()!="" &&   (bool)isadmin)
                            {
                                player.isAdmin = (bool)row["IsAdmin"]; 
                            }
                            else
                            {
                                player.isAdmin = false;
                            }
                            



                            listOfPlayers.Add(player);


                        }
                    }
                }

                sqlConnection.Close();
            }
            return listOfPlayers;
        }

        public void EditPlayer(Player player)
        {


            SqlConnection connection = new SqlConnection(conn);
            connection.Open();

            SqlCommand command = new SqlCommand("UPDATE Game_Minesweeper  SET ID=@id, Player_name=@Player_name, Password=@Password, Score=@scoreOfPlayer, Number_of_games=@Number_of_games, IsAdmin=@IsAdmin WHERE ID=@id", connection);

            /*
            SqlParameter @scoreOfPlayer = new SqlParameter("@scoreOfPlayer", SqlDbType.Int);
            @scoreOfPlayer.Value = this.Score;

            SqlParameter myIDParam = new SqlParameter("@id", SqlDbType.Int);
            myIDParam.Value = this.Id;
            */

            command.Parameters.AddWithValue("@scoreOfPlayer", player.Score);
            command.Parameters.AddWithValue("@id", player.Id);
            command.Parameters.AddWithValue("@Player_name", player.Name);
            command.Parameters.AddWithValue("@Password", player.Password);
            command.Parameters.AddWithValue("@Number_of_games", player.NumberOfGames);
            command.Parameters.AddWithValue("@IsAdmin", player.isAdmin);




            int rows = command.ExecuteNonQuery();

            connection.Close();
        }

        public void UpdatePlayerScore(int id, int newScore, int numberOfGames)
        {


            SqlConnection connection = new SqlConnection(conn);
            connection.Open();

            SqlCommand command = new SqlCommand("UPDATE Game_Minesweeper  SET Score=@scoreOfPlayer, Number_of_games=@numberOfGames WHERE ID=@id", connection);


            SqlParameter scoreOfPlayerParam = new SqlParameter("@scoreOfPlayer", SqlDbType.Int);
            scoreOfPlayerParam.Value = this.Score;

            SqlParameter numberOfGamesParam = new SqlParameter("@numberOfGames", SqlDbType.Int);
            numberOfGamesParam.Value = this.NumberOfGames;

            SqlParameter myIDParam = new SqlParameter("@id", SqlDbType.Int);
            myIDParam.Value = this.Id;




            command.Parameters.AddWithValue("@scoreOfPlayer", newScore);
            command.Parameters.AddWithValue("@numberOfGames", numberOfGames);
            command.Parameters.AddWithValue("@id", id);




            int rows = command.ExecuteNonQuery();

            connection.Close();
        }

        public void InsertPlayer(int id, string name, string pass)
        {

            SqlConnection sqlConnection = new SqlConnection(conn);
            sqlConnection.Open();
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Game_Minesweeper ( ID, Player_name, Password ) values ( @somePlayerID, @somePlayerName, @somePlayerPass)", sqlConnection))
            {
                cmd.Parameters.AddWithValue("@somePlayerID", id);
                cmd.Parameters.AddWithValue("@somePlayerName", name);
                cmd.Parameters.AddWithValue("@somePlayerPass", pass);


                cmd.ExecuteNonQuery();
            }

            sqlConnection.Close();
        }
        
        public void DeletePlayerById(int id)
        {

            SqlConnection connection = new SqlConnection(conn);
            connection.Open();

            SqlCommand command = new SqlCommand("DELETE FROM Game_Minesweeper WHERE ID=@id", connection);
            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();
            connection.Close();

        }
    }
}
