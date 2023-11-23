using Blackjack.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackjackGUI
{
    public partial class FrmEinsatz : Form
    {
        private int money;
        public int balance;

        /// <summary>
        /// Ist der Konstruktor, falls man nochmal spielen möchte, d.h das gewonnene/verlorene Geld wird berücksichtigt. 
        /// </summary>
        /// <param name="balance"></param>
        public FrmEinsatz(int balance)
        {
            InitializeComponent();
            this.balance = balance;
            lblValue.Text = balance.ToString();

        }

        /// <summary>
        /// Ist der Konstruktor für das erste Einsetzen.
        /// </summary>
        public FrmEinsatz()
        {
            InitializeComponent();
            this.balance = 100;
            lblValue.Text = balance.ToString();

        }

        /// <summary>
        /// Eigenschaft für das eingesetzte Geld.
        /// </summary>
        public int Money
        {
            get
            {
                return this.money;
            }

            set
            {
                this.money = value;
            }
        }

        /// <summary>
        /// Ist die Eigenschaft, für den Betrag, der sich im Wallet befindet.
        /// </summary>
        public int Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                this.balance = value;
            }
        }
        private void FrmEinsatz_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Methode für das Bestätigen des gesetzten Geldbetrags.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            money = Convert.ToInt32(tbxEinsatz.Text);
            
            if (money > balance)
            {
                MessageBox.Show("Sie können nicht mehr als vorhanden ist, abheben!");
            }

            if (money < 0)
            {
                MessageBox.Show("Die Eingabe ist ungültig!");
            }

            if (money <= balance && money > 0)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        /// <summary>
        /// Methode für das Abbrechen eines Einsatzes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lblValue_Click(object sender, EventArgs e)
        {

        }
    }
}
