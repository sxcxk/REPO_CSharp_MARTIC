using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarvelClicker
{
    public partial class frmMarvelClicker : Form
    {
        Form gameCenter;
        public frmMarvelClicker()
        {
            InitializeComponent();
        }

        public frmMarvelClicker(Form gameCenter)
        {
            InitializeComponent();
            this.gameCenter = gameCenter;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }

        private void MtbxScore_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int score = Convert.ToInt32(mtbxScore.Text);

            if (button1.BackgroundImage != btnCap.BackgroundImage && button1.BackgroundImage != btnSpidy.BackgroundImage && button1.BackgroundImage != btnHulk.BackgroundImage && button1.BackgroundImage != btnIronMan.BackgroundImage )
            {
                score = score - 1;
            }



            if (score <= 9990)
            {
                btnIronMan.Enabled = true;
                btnIronMan.BackColor = Color.Green;
            }

            if (button1.BackgroundImage == btnIronMan.BackgroundImage)
            {
                score = score - 10;
            }



            if (score <= 9950)
            {
                btnHulk.Enabled = true;
                btnHulk.BackColor = Color.Green;  
            }

            if (button1.BackgroundImage == btnHulk.BackgroundImage)
            {
                score = score - 50;
            }



            if (score <= 9900)
            {
                btnSpidy.Enabled = true;
                btnSpidy.BackColor = Color.Green;
            }

            if (button1.BackgroundImage == btnSpidy.BackgroundImage)
            {
                score = score - 100;
            }


            if (score <= 9000)
            {
                btnCap.Enabled = true;
                btnCap.BackColor = Color.Green;
            }

            if (button1.BackgroundImage == btnCap.BackgroundImage)
            {
                score = score - 1000;
            }

            if (score <= 0)
            {
                button1.BackgroundImage = button1.BackgroundImage;
                pnlThanos.Visible = true;
                lblGameOver.Visible = true;
                lblGameOver2.Visible = true;
            }


            mtbxScore.Text = score.ToString();




        }

        private void btnIronMan_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = btnIronMan.BackgroundImage;
        }

        private void frmMarvelClicker_Load(object sender, EventArgs e)
        {

        }

        private void btnHulk_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = btnHulk.BackgroundImage;
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            gameCenter.Show();
            this.Hide();
            this.Dispose();
        }

        private void btnSpidy_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = btnSpidy.BackgroundImage;
        }

        private void btnCap_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = btnCap.BackgroundImage;

        }

        private void NeuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnIronMan.Enabled = false;
            btnHulk.Enabled = false;
            btnSpidy.Enabled = false;
            btnCap.Enabled = false;
            pnlThanos.Visible = false;

            btnCap.BackColor = Color.DarkRed;
            btnHulk.BackColor = Color.DarkRed;
            btnSpidy.BackColor = Color.DarkRed;
            btnIronMan.BackColor = Color.DarkRed;

            button1.BackgroundImage = Properties.Resources.avengers;
            mtbxScore.Text = 10000.ToString();
           

        }

        private void EndeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameCenter.Show();
            this.Dispose();
        }

        private void pnlThanos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
