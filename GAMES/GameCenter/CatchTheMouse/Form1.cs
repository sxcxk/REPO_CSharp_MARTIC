using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;

namespace CatchTheMouse
{
    public partial class frmCTM : Form
    {
        private Form gameCenter;
        private CatchGame cg;
        private ResourceManager rm;
        public frmCTM()
        {
            InitializeComponent();
        }

        public frmCTM(Form gameCenter)
        {
            InitializeComponent();
            this.gameCenter = gameCenter;
            rm = new ResourceManager("CatchTheMouse.Properties.Resources", Assembly.GetExecutingAssembly());
            this.cg = new CatchGame();
            InitGame();

        }

        private void frmCTM_Load(object sender, EventArgs e)
        {

        }
        private void InitGame()
        {
            this.cg = new CatchGame();
            int[] coords=new int[2];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    cg.buttons[i, j].Click += new System.EventHandler(this.btnGame_Click);
                    pnlGame.Controls.Add(cg.buttons[i, j]);
                    coords[0] = i;
                    coords[1] = j;
                    DisplayPlayer(coords, "Quake_icon");

                    coords[0] = cg.catPos[0];
                    coords[1] = cg.catPos[1];
                    DisplayPlayer(coords, "tom");

                }
            }

        }

        private void DisplayPlayer(int[] coords, string pic)
        {
            int x = coords[0];
            int y = coords[1];
            cg.buttons[x, y].BackgroundImage = (Bitmap)rm.GetObject(pic);
            cg.buttons[x, y].BackgroundImageLayout = ImageLayout.Stretch;
        }
        public void btnGame_Click(object sender, EventArgs e)
        {
            int[] coords = new int[2];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    coords[0] = i;
                    coords[1] = j;
                    DisplayPlayer(coords, "Quake_icon");
                }
            }

            GameButton clickedButton = (GameButton)sender;

            coords[0] = clickedButton.x;
            coords[1] = clickedButton.y;
          
            DisplayPlayer(coords, "tom");
            MoveTheMouse(cg.FindMouseMove());

            if (coords[0] == cg.mousePos[0] && coords[1] == cg.mousePos[1])
            {
                cg.buttons[coords[0], coords[1]].BackgroundImage = (Bitmap)rm.GetObject("tomcatchesjerry");
                MessageBox.Show("Du hast gewonnen!!!");
            }

        }

        private MouseMove MoveTheMouse(MouseMove m)
        {
            m = cg.FindMouseMove();
            int[] coords = new int[2];
            coords[0] = cg.mousePos[0];
            coords[1] = cg.mousePos[1];


            DisplayPlayer(coords, "jerry1");
            return m;
        }
        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlGame_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameCenter.Show();
            this.Dispose();
        }

        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            int[] coordsReset = new int[2];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    cg.buttons[i, j].BackgroundImage = (Bitmap)rm.GetObject("Quake_icon");
                    cg.buttons[i, j].BackgroundImageLayout = ImageLayout.Stretch;

                    cg.catPos[0] = 0;
                    cg.catPos[1] = 9;
                    coordsReset[0] = cg.catPos[0];
                    coordsReset[1] = cg.catPos[1];
                    DisplayPlayer(coordsReset, "tom");

                    cg.mousePos[0] = 5;
                    cg.mousePos[1] = 5;
                    coordsReset[0] = cg.mousePos[0];
                    coordsReset[1] = cg.mousePos[1];
                    DisplayPlayer(coordsReset, "Quake_icon");

                }
            }
        }
    }
}