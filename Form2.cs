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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        int id;
       

        public frmAdmin(Player player)
        {
            InitializeComponent();

           

            

            dgwPlayers.DataSource = player.GetPlayers();

            

        }

 

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Player player = new Player();
            var play = player.GetPlayers().LastOrDefault(p => p.Id > 0);
            if (play.Id != null)
            {
                id = play.Id;
            }

            Form1 form1 = new Form1("Adding new player!!!", (id+1));
            Init1();
            form1.ShowDialog();
        }

        private void Init1(object sender, EventArgs e)
        {
            Player player = new Player();
            dgwPlayers.DataSource = player.GetPlayers().OrderBy(p => p.Id).ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string idString = dgwPlayers.CurrentRow.Cells[0].Value.ToString();
            int idInt;
            Int32.TryParse(idString, out idInt);

            Player player = new Player();
            MessageBox.Show("DELETED");
            
            
            player.DeletePlayerById(idInt);
            Init1();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string idString = dgwPlayers.CurrentRow.Cells[0].Value.ToString();
            int idInt;
            Int32.TryParse(idString, out idInt);

            Player player = new Player();
            Player player1=player.GetPlayers().FirstOrDefault(p=>p.Id==idInt);

            Edit edit=new Edit(player1);
            edit.ShowDialog();
        }

        private void Init1()
        {
            Player player = new Player();
            dgwPlayers.DataSource = player.GetPlayers().OrderBy(p => p.Id).ToList();
        }
    }
}
