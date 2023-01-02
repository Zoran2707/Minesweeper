using Minesweeper.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace Minesweeper
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        Random random = new Random();
        int randomNumber;
        int numberOfTry = 0;
        Player playerPlayer;
       


        public Game(Player player)
        {
            InitializeComponent();

            Init1();

            txtPlayerName.Text = player.Name;  
            lblFullName.Text = player.Name + player.Password;
            lblPlayerID.Text = (player.Id).ToString();


            txtNumberOfGamesForThisPlayer.Text = (player.NumberOfGames).ToString();
            txtTotalScore.Text= (player.Score).ToString();
            playerPlayer=player;
            tableLayoutPanel1.Enabled = false;
            btnSettings.Enabled = false;
            if (player.isAdmin == true)
            {
                btnSettings.Enabled = true;
            }
                      
        }

        private void Init1()
        {


            int nameOfLabels1 = 1;
            foreach (Label l in tableLayoutPanel1.Controls)
            {
                l.Text = nameOfLabels1.ToString();
                         
                nameOfLabels1++;
            }
            tableLayoutPanel1.BackColor = Color.Turquoise;
            foreach(Label l in tableLayoutPanel1.Controls)
            {
                l.BackColor = Color.Yellow;
                l.Enabled = true;
            }
            int number = random.Next(1, 15);
            randomNumber = number;
            tableLayoutPanel1.Enabled = true;
            txtScoreInThisGame.Clear();
            numberOfTry = 0;
           

        }



        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Init1();
            int games;
            Int32.TryParse(txtNumberOfGamesForThisPlayer.Text, out games);
            games++;
            txtNumberOfGamesForThisPlayer.Text= games.ToString();
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

            numberOfTry++;
            if(numberOfTry == 10)
            {
                txtScoreInThisGame.Text = "0";
                MessageBox.Show("You spend all atempts, try new game please");
                tableLayoutPanel1.Enabled = true;
                btnNewGame.Focus();

            }

            if (sender is Label)
            {
                Label l = (Label)sender;
                
              
                
          
                    if (l.Text.Contains(randomNumber.ToString()))
                    {
                        l.Text = "Bingo";
                        l.BackColor= Color.AntiqueWhite;
                        tableLayoutPanel1.Enabled = false;
                        txtScoreInThisGame.Text=(10-numberOfTry).ToString();
                        Player player = new Player();

                        int id, totalPoints, pointInThisGame, numberGames;

                        Int32.TryParse(lblPlayerID.Text, out id);
                        Int32.TryParse(txtTotalScore.Text, out totalPoints);
                        Int32.TryParse(txtNumberOfGamesForThisPlayer.Text, out numberGames);
                        Int32.TryParse(txtScoreInThisGame.Text, out pointInThisGame);


                        player.UpdatePlayerScore(id, (totalPoints+pointInThisGame), (numberGames));
                        txtTotalScore.Text = (totalPoints + pointInThisGame).ToString();
                         

                    }
                    else
                    {
                        l.Text = "Keep trying";
                        l.Enabled = false;
                    }
                

               
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            //Form1 form1 = new Form1();
            this.Close();
            //form1.ShowDialog();
            
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmAdmin frmAdmin = new frmAdmin(playerPlayer);
            frmAdmin.ShowDialog();
        }
    }
}
