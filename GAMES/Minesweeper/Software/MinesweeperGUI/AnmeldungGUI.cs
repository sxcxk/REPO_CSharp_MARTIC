using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBAccessLib;

namespace MinesweeperGUI
{

    public partial class frmLogin : Form
    {
        public string[] playerDetails;

        DBManager manager;
        public frmLogin()
        {
            InitializeComponent();
            this.manager = new DBManager();
            this.playerDetails = new string[5];
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            frmGame game = new frmGame();

            this.Hide();
            game.Show();
            game.PlayerDetails(this.playerDetails);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            btnLogin.Enabled = false;
            string user = tbxUser.Text;

            List<Player> foundPlayer = manager.FindPlayer("Server=127.0.0.1;Uid=mineadmin;Pwd=szu123;Database=minesweeper;", user);
            for (int i = 0; i < foundPlayer.Count; i++)
            {
                playerDetails[0] = foundPlayer[i].Name;
                playerDetails[1] = foundPlayer[i].Level;
                playerDetails[2] = foundPlayer[i].Highscore.ToString();
                playerDetails[3] = foundPlayer[i].Scoredate;
                playerDetails[4] = foundPlayer[i].ID.ToString();
                ListViewItem data = new ListViewItem(playerDetails);
                listViewPlayer.Items.Add(data);

            }

        }

        private void spielOhneAnmeldungFortsetzenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGame game = new frmGame();
            this.Hide();
            game.Show();
        }

        private void abbrechenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void listViewPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
