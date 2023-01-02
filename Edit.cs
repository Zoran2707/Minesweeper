using Minesweeper.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        public Edit(Player player)
        {
            InitializeComponent();

            lblIDValue.Text=player.Id.ToString();
            lblIDValue.Enabled=false;
            txtPlayerName.Text=player.Name;
            txtPlayerPass.Text = player.Password;
            numPlayerScore.Value=player.Score;
            numPlayerGames.Value = player.NumberOfGames;
            cbIsPlayerAdmin.Checked = player.isAdmin;
        }


 

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id;
            bool isvalid = false;
            if (cbIsPlayerAdmin.Checked == true)
            {
                isvalid = true;
            }
            Int32.TryParse(lblIDValue.Text, out id); 
            Player player = new Player(id, txtPlayerName.Text, txtPlayerPass.Text, (int)numPlayerScore.Value, (int)numPlayerGames.Value, isvalid);
            Player player1 = player.GetPlayers().FirstOrDefault(p => p.Id == id);
            player1.EditPlayer(player);
            MessageBox.Show("Well done!!!", "Edit player", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void txtPlayerName_Leave(object sender, EventArgs e)
        {
      

            if (txtPlayerName.Text.Length < 3)
            {
                txtPlayerName.Focus();
                txtPlayerName.BackColor = Color.Pink;
            }
        }

        private void txtPlayerPass_Leave(object sender, EventArgs e)
        {


            if (txtPlayerPass.Text.Length < 3)
            {
                txtPlayerPass.Focus();
                txtPlayerPass.BackColor = Color.Pink;
            }
        }
    }
}
