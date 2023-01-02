using Minesweeper.Classes;

namespace Minesweeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int id;
        public Form1(string s, int ident)
        {
            InitializeComponent();

            btnLogIn.Text = s;
            lblFirstName.Text ="NAME OF NEW PLAYER";
            label2.Text = "PASS FOR NEW PLAYER";
            id= ident;

        }

        public void Init1()
        {
            Player player = new Player();
           
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
      
            if(txtFirstName.Text.Length >=3  && txtPassword.Text.Length >= 3)
            {
                Player player = new Player();
                var player1 = player.GetPlayers().FirstOrDefault(p => p.Password.Contains(txtPassword.Text) && p.Name == txtFirstName.Text);

                if (btnLogIn.Text.Length < 7)
                {
                   // var bb = player.GetPlayers();

                   

                    if (player1 != null)
                    {
                        Game game = new Game(player1);


                        game.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Your pass is not OK, please try again.");
                    }
                }
                else
                {
                    bool isValid = true;
                    foreach(Player p in player.GetPlayers())
                    {
                        
                        if (p.Password.Contains(txtPassword.Text))
                        {
                            MessageBox.Show("Your pass isnot correct, try with newone");
                            txtPassword.Focus();
                            isValid = false;
                            break;
                        }
                    }
                    if (isValid)
                    {
                        bool validID = true;
                      foreach(Player p in player.GetPlayers())
                        {
                            if (id == p.Id)
                            {
                                validID = false;
                            }
                        }

                        if (validID)
                        {
                            player.InsertPlayer(id, txtFirstName.Text, txtPassword.Text);
                            MessageBox.Show("Succesful add new player named " + txtFirstName.Text);
                            this.Close();
                        }
                        else
                        {
                            player.InsertPlayer((1+id), txtFirstName.Text, txtPassword.Text);
                            MessageBox.Show("Succesful add new player named " + txtFirstName.Text);
                            this.Close();
                        }
                      
                        
                    }

                }
                
                                                            
                
            }
            else
            {
                MessageBox.Show("Try again");
            }
            
        }
    }
}