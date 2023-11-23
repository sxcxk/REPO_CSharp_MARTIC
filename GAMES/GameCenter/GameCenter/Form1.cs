using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarvelClicker;
using CatchTheMouse;

namespace GameCenter
{
    public partial class frmGameCenter : Form
    {
        public frmGameCenter()
        {
            InitializeComponent();
        }

        private void btnMarvel_Click(object sender, EventArgs e)
        {
            frmMarvelClicker marvelForm = new frmMarvelClicker(this);
            marvelForm.Show();
            this.Hide();
            
        }

        private void frmGameCenter_Load(object sender, EventArgs e)
        {

        }

        private void btnCTM_Click(object sender, EventArgs e)
        {
            frmCTM ctm = new frmCTM(this);
            ctm.Show();
            this.Hide();
        }
    }
}
