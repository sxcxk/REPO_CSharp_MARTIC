using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Minesweeper.Logic;
using System.Reflection;
using System.IO;
using DBAccessLib;

namespace MinesweeperGUI
{
    public partial class frmGame : Form
    {
        #region Fields

        #region Manager & Co.
        private GameButton gb;
        private PlayGround pg;
        private ResourceManager rm;
        private DBManager dbManager;
        private int x;
        private int y;
        private int diff;
        private string[] playerDetails;
        #endregion

        #region integer
        private int countMethod = 0;
        private int time = 0;
        private int taggedFields = 0;
        private int trueTagged = 0;
        private int highscore = 0;
        #endregion

        #region Bitmaps
        private Bitmap _0;
        private Bitmap _1;
        private Bitmap _2;
        private Bitmap _3;
        private Bitmap _4;
        private Bitmap _5;

        private Bitmap field;
        private Bitmap flag;
        private Bitmap flag2;
        private Bitmap mine;
        private Bitmap mineNotFound;
        #endregion


        #endregion

        public frmGame()
        {
            InitializeComponent();
            rm = new ResourceManager("MinesweeperGUI.Properties.Resources", Assembly.GetExecutingAssembly());
            dbManager = new DBManager();
            _0 = (Bitmap)rm.GetObject("_0");
            _1 = (Bitmap)rm.GetObject("_1");
            _2 = (Bitmap)rm.GetObject("_2");
            _3 = (Bitmap)rm.GetObject("_3");
            _4 = (Bitmap)rm.GetObject("_4");
            _5 = (Bitmap)rm.GetObject("_5");

            field = (Bitmap)rm.GetObject("field");
            flag = (Bitmap)rm.GetObject("flag");
            flag2 = (Bitmap)rm.GetObject("flag2");
            mine = (Bitmap)rm.GetObject("mine");
            mineNotFound = (Bitmap)rm.GetObject("mineNotFound");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flpGamePanel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void GenerateGameButtons(int x, int y)
        {
            for (int i = 0; i < x; i++) 
            {
                for (int j = 0; j < y; j++)
                {
                    gb = new GameButton(i, j);
                    gb.MouseDown +=new MouseEventHandler(GameButtonClicked);
                    gb.BackgroundImageLayout = ImageLayout.Stretch;
                    gb.BackgroundImage = field;
                    flpGamePanel.Controls.Add(gb);
                }
            }
        }

    

        public void GameButtonClicked(object sender, MouseEventArgs e)
        {
            int index = 0;
            int difflength = diff * diff;
            GameButton clickedButton = (GameButton)sender;
          
            int x = clickedButton.X;
            int y = clickedButton.Y;

         

            if (e.Button == MouseButtons.Left)
            {
                pg.UncoverAllFields(x, y);
                countMethod++;
                if (x > -1 && x < diff && y > -1 && y < diff) 
                {

                    if (pg.FieldHasMine(x,y))
                    {
                        clickedButton.BackgroundImage = mine;
                        Solution(); 
                        timer.Stop();
                        MessageBox.Show("GAME OVER!");
                    }


                    for (int i = 0; i < diff; i++)
                    {
                        for (int j = 0; j < diff; j++)
                        {
                            if (index >= 0 && index < difflength)
                            {

                                if (pg.ShowUncoveredFields(i, j) == 0 && pg.FieldHasMine(i, j) == false) 
                                {
                                    flpGamePanel.Controls[index].BackgroundImage = _0;
                                }

                                if (pg.ShowUncoveredFields(i, j) == 1 && pg.FieldHasMine(i, j) == false) 
                                {
                                    flpGamePanel.Controls[index].BackgroundImage = _1;
                                }

                                if (pg.ShowUncoveredFields(i, j) == 2 && pg.FieldHasMine(i, j) == false) 
                                {
                                    flpGamePanel.Controls[index].BackgroundImage = _2;
                                }

                                if (pg.ShowUncoveredFields(i, j) == 3 && pg.FieldHasMine(i, j) == false) 
                                {
                                    flpGamePanel.Controls[index].BackgroundImage = _3;
                                }

                                if (pg.ShowUncoveredFields(i, j) == 4 && pg.FieldHasMine(i, j) == false) 
                                {
                                    flpGamePanel.Controls[index].BackgroundImage = _4;
                                }

                                if (pg.ShowUncoveredFields(i, j) == 5 && pg.FieldHasMine(i, j) == false) 
                                {
                                    flpGamePanel.Controls[index].BackgroundImage = _5;
                                }
                                index++;
                            }
                        }
                    }
                }
                
            }


            if (e.Button == MouseButtons.Right)
            {

                if (countMethod > 0)
                {
                    if (pg.CheckTurnedOver(x,y) == true)
                    {
                        return;
                    }
                }

                if (taggedFields < diff-1)
                {
                    if (pg.FieldTagged(x, y) == true)
                    {
                        tbxTagsCount.Text = (Convert.ToInt32(tbxTagsCount.Text) + 1).ToString();
                        pg.TagField(x, y);
                        clickedButton.BackgroundImage = field;
                        taggedFields--;
                        return;
                    }

                    if (pg.FieldTagged(x, y) == false)
                    {
                        tbxTagsCount.Text = (Convert.ToInt32(tbxTagsCount.Text) - 1).ToString();
                        pg.TagField(x, y);
                        clickedButton.BackgroundImage = flag;
                        taggedFields++;
                        return;
                    }
                }

                if (taggedFields == diff-1)
                {
                    if (CheckTaggedFields(x, y) == 0)
                    {
                        Solution();
                        timer.Stop();
                        highscore = Convert.ToInt32(tbxTimer.Text);
                        if (highscore < Convert.ToInt32(tbxHighscore.Text) || Convert.ToInt32(tbxHighscore.Text) == 0)
                        {
                            playerDetails[1] = tbxDiff.Text;
                            dbManager.UpdateDB(playerDetails[0], playerDetails[1], highscore, "Server=127.0.0.1;Uid=mineadmin;Pwd=szu123;Database=minesweeper;");
                            MessageBox.Show("YOU WIN !!!");
                            return;
                        }

                        MessageBox.Show("YOU WIN !!!");
                    }

                    if (CheckTaggedFields(x, y) == 1)
                    {
                        Solution();
                        timer.Stop();
                        MessageBox.Show("GAME OVER !!!");
                    }
                }
            }
        }

        private void Solution()
        {
            int index = 0;
            int diffLength = diff*diff;
            for (int x = 0; x < diff; x++)
            {
                for (int y = 0; y < diff; y++)
                {
                    if (index >= 0 && index < diffLength)
                    {
                        if (pg.FieldHasMine(x, y))
                        {
                            flpGamePanel.Controls[index].BackgroundImage = mine;
                        }

                        if (pg.SurroundingMines(x, y) == 1 && pg.FieldHasMine(x, y) == false)
                        {
                            flpGamePanel.Controls[index].BackgroundImage = _1;
                        }

                        if (pg.SurroundingMines(x, y) == 2 && pg.FieldHasMine(x, y) == false)
                        {
                            flpGamePanel.Controls[index].BackgroundImage = _2;
                        }

                        if (pg.SurroundingMines(x, y) == 3 && pg.FieldHasMine(x, y) == false)
                        {
                            flpGamePanel.Controls[index].BackgroundImage = _3;
                        }

                        if (pg.SurroundingMines(x, y) == 4 && pg.FieldHasMine(x, y) == false)
                        {
                            flpGamePanel.Controls[index].BackgroundImage = _4;
                        }

                        if (pg.SurroundingMines(x, y) == 5 && pg.FieldHasMine(x, y) == false)
                        {
                            flpGamePanel.Controls[index].BackgroundImage = _5;
                        }

                        if (pg.SurroundingMines(x, y) == 0 && pg.FieldHasMine(x, y) == false)
                        {
                            flpGamePanel.Controls[index].BackgroundImage = _0;
                        }

                        index++;
                    }
                }
            }
        }

        private int CheckTaggedFields(int x, int y)
        {
            if (pg.FieldHasMine(x,y) == pg.FieldTagged(x,y) && trueTagged < diff-1)
            {
                trueTagged++;
                return 1;
            }

            if (trueTagged == diff-1)
            {
                return 0;
            }
            return -1;
        }

        private void btnReveal_Click(object sender, EventArgs e)
        {
            Solution();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tbxTimer.Text = time.ToString() + " " + "Seconds";
            time++;
        }

        private void tbxTimer_TextChanged(object sender, EventArgs e)
        {

        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flpGamePanel.Size = new Size(370, 370);

            x = 10;
            y = 10;
            pg = new PlayGround("easy");
            tbxDiff.Text = "Easy";

            diff = pg.FieldLength();
            GenerateGameButtons(x,y);
            tbxTagsCount.Text = diff.ToString();
            timer.Start();


        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flpGamePanel.Size = new Size(740, 740);
            x = 20;
            y = 20;
            pg = new PlayGround("medium");
            tbxDiff.Text = "Medium";

            diff = pg.FieldLength();
            GenerateGameButtons(x, y);
            tbxTagsCount.Text = diff.ToString();
            timer.Start();

        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flpGamePanel.Size = new Size(1100, 1100);
            x = 30;
            y = 30;
            pg = new PlayGround("hard");
            tbxDiff.Text = "Hard";

            diff = pg.FieldLength();
            GenerateGameButtons(x, y);
            tbxTagsCount.Text = diff.ToString();
            timer.Start();

        }

        private void schwierigkeitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tbxHighscore_TextChanged(object sender, EventArgs e)
        {

        }

        public string[] PlayerDetails(string[] loginDetails)
        {
            this.playerDetails = loginDetails;
            string highscore = playerDetails[2].ToString();
            tbxHighscore.Text = highscore;
            return this.playerDetails;

        }
    }
}
