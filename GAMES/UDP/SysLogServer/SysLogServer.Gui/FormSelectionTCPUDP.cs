using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysLogServer.Gui
{
    public partial class FormSelectionTCPUDP : Form
    {
        public FormSelectionTCPUDP()
        {
            InitializeComponent();
        }

        private void SelectionTCPUDP_Load(object sender, EventArgs e)
        {
        }

       

        private void rbtnUDP_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbtnTCP_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (rbtnTCP.Checked == false && rbtnUDP.Checked == false) 
            {
                MessageBox.Show("Select a server type!");
            }

            if (rbtnUDP.Checked)
            {
                FormSysLog formSysLog = new FormSysLog("Udp",this);
                formSysLog.Show();
                this.Hide();
            }

            if (rbtnTCP.Checked)
            {
                FormSysLog formSysLog = new FormSysLog("Tcp",this);
                formSysLog.Show();
                this.Hide();    
            }
        }
    }
}
