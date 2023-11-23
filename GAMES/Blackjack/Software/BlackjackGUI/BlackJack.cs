using Blackjack.Logic;
using System;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace BlackjackGUI
{
    public partial class BlackJack : Form
    {
        #region Fields
        private ResourceManager rm;
        private Game game;
        private FrmEinsatz einsatz;
        private List<Card> dealerCards;
        private List<Card> playerCards;
        private DialogResult answer;
        private int walletBalance;
        private EventArgs e;
        #endregion

        #region Constructor
        public BlackJack()
        {
            InitializeComponent();
            game = new Game();
            einsatz = new FrmEinsatz();
            rm = new ResourceManager("BlackjackGUI.Properties.Resources", Assembly.GetExecutingAssembly());
            lblValueWallet.Text = game.Balance().ToString();
            this.e = new EventArgs();
        }
        #endregion

        #region Methods

        #region Beenden
        /// <summary>
        /// Diese Methode liefert nix zurück.
        /// Hier wird das Programm geschlossen,
        /// falls auf diesen Button gedrückt wird.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region NeuesSpiel
        /// <summary>
        /// Diese Methode liefert nichts zurück. 
        /// In dieser Methode wird ein neues Spiel gestartet, 
        /// falls darauf gedrückt wird. Im ersten Schritt werden die Labels, 
        /// wo sich die Werte der Hände befinden,
        /// auf 0 und die vorhandenen Buttons auf false gesetzt. 
        /// Danach kommt ein neues Fenster auf, wo angefordert wird, 
        /// wie viel der Spieler setzen will (FrmEinsatz). 
        /// Hat der Spieler seine Wette getätigt, 
        /// wird seine Wallet-Balance und sein Einsatz angezeigt,
        /// wobei das Wallet entsprechend der Wette angezeigt werden muss.
        /// Im folgenden Schritt wird ein neues Spiel gestartet
        /// (mit entsprechender Methode aus der Game-Klasse). 
        /// Das FlowLayoutPanel des Dealers bzw. 
        /// Players wird mit jeweils 2 Pictureboxen befüllt und Karten,
        /// die sie bekommen haben, wobei die 1. Karte des Dealers verdeckt ist.
        /// Am Ende wird geprüft, ob einer der beiden Personen BlackJack hat, 
        /// ist dies der Fall wird der entsprechende Verlust/Gewinn dem Spiel 
        /// gutgeschrieben. Nach dem das passiert ist, wird mit der vorhandenen 
        /// Methode ControlStructures weiter abgefragt. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void neuesSpielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblHandValuePlayer.Text = "0";
            lblHandValueD.Text = "0";
            btnStay.Enabled = true;
            btnHit.Enabled = true;
            lblWallet.Visible = true;
            lblValueWallet.Visible = true;
            tbxMoneyStake.Enabled = false;


            DialogResult result = einsatz.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbxMoneyStake.Text = einsatz.Money.ToString();
                game.SetBet(einsatz.Money);
                lblValueWallet.Text = game.Balance().ToString();

                game.StartNewGame();

                dealerCards = game.GetDealerCards();
                playerCards = game.GetPlayerCards();

                flpPlayer.Controls.Clear();
                flpDealer.Controls.Clear();
                for (int i = 0; i < playerCards.Count; i++)
                {
                    PictureBox pbx = new PictureBox();
                    pbx.Image = (Bitmap)rm.GetObject(playerCards[i].ToString());
                    pbx.SizeMode = PictureBoxSizeMode.Zoom;
                    pbx.Width = 100;
                    pbx.Height = 120;
                    flpPlayer.Controls.Add(pbx);
                }

                PictureBox pbxD = new PictureBox();
                pbxD.Image = (Bitmap)rm.GetObject("CardSkin");
                pbxD.SizeMode = PictureBoxSizeMode.Zoom;
                pbxD.Width = 100;
                pbxD.Height = 120;
                flpDealer.Controls.Add(pbxD);

                pbxD = new PictureBox();
                pbxD.Image = (Bitmap)rm.GetObject(dealerCards[1].ToString());
                pbxD.SizeMode = PictureBoxSizeMode.Zoom;
                pbxD.Width = 100;
                pbxD.Height = 120;
                flpDealer.Controls.Add(pbxD);
                lblPlaced.Visible = true;

                if (game.GetPlayerPoints() == 21)
                {
                    lblPlaced.Visible = false;

                    MessageBox.Show("BLACKJACK!!!");
                    game.GetMoney(Convert.ToInt32(tbxMoneyStake.Text));
                    lblValueWallet.Text = game.Balance().ToString();

                    PictureBox pbx = (PictureBox)flpDealer.Controls[0];
                    pbx.SizeMode = PictureBoxSizeMode.Zoom;
                    pbx.Width = 100;
                    pbx.Height = 120;
                    pbx.Image = (Bitmap)rm.GetObject(dealerCards[0].ToString());
                    lblValueWallet.Text = game.Balance().ToString();
                    einsatz.Balance = game.Balance();
                    tbxMoneyStake.Text = "0";
                    btnStay.Enabled = false;
                    btnHit.Enabled = false;

                    walletBalance = game.Balance();

                    ControlStructures(answer);
                }

                if (game.GetDealerPoints() == 21)
                {
                    lblPlaced.Visible = false;

                    pbxD.Image = (Bitmap)rm.GetObject(dealerCards[0].ToString());
                    MessageBox.Show("Dealer hat ein Blackjack!");
                    lblValueWallet.Text = game.Balance().ToString();
                    einsatz.Balance = game.Balance();
                    tbxMoneyStake.Text = "0";

                    PictureBox pbx = (PictureBox)flpDealer.Controls[0];
                    pbx.SizeMode = PictureBoxSizeMode.Zoom;
                    pbx.Width = 100;
                    pbx.Height = 120;
                    pbx.Image = (Bitmap)rm.GetObject(dealerCards[0].ToString());

                    btnStay.Enabled = false;
                    btnHit.Enabled = false;

                    ControlStructures(answer);
                }
            }

            lblHandValuePlayer.Text = game.GetPlayerPoints().ToString();
            lblHandValueD.Text = "?";


        }
        #endregion

        #region Hit
        /// <summary>
        /// Diese Methode liefert nichts zurück. 
        /// Diese Methode gibt dem Spieler eine Karte in die Hand. 
        /// Zuerst wird eine PictureBox für die neue Karte erstellt,
        /// um danach die Karte in dieser PictureBox anzuzeigen 
        /// und in das FlowLayoutPanel des Spielers hinzuzufügen.
        /// Am Ende der Methode wird die Methode BustPlayer der Game-Klasse
        /// und die Methode ControlStructures() aufgerufen, 
        /// die sich im GUI befindet.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHit_Click(object sender, EventArgs e)
        {
            PictureBox pbx = new PictureBox();
            pbx.SizeMode = PictureBoxSizeMode.Zoom;
            pbx.Width = 100;
            pbx.Height = 120;
            game.Hit();
            playerCards = game.GetPlayerCards();

            pbx.Image = (Bitmap)rm.GetObject(playerCards[playerCards.Count - 1].ToString());
            flpPlayer.Controls.Add(pbx);
            lblHandValuePlayer.Text = game.GetPlayerPoints().ToString();

            if (game.BustPlayer())
            {
                lblPlaced.Visible = false;
                MessageBox.Show("Sie sind über 21!");
                btnStay.Enabled = false;
                btnHit.Enabled = false;

                pbx = (PictureBox)flpDealer.Controls[0];
                pbx.SizeMode = PictureBoxSizeMode.Zoom;
                pbx.Width = 100;
                pbx.Height = 120;

                pbx.Image = (Bitmap)rm.GetObject(dealerCards[0].ToString());
                lblValueWallet.Text = game.Balance().ToString();

                lblHandValueD.Text = game.GetDealerPoints().ToString();

                ControlStructures(answer);

            }

        }
        #endregion

        #region Stay

        /// <summary>
        /// Diese Methode liefert nichts zurück. 
        /// Diese Methode startet den Zug des Dealers. 
        /// Falls der Spieler zufrieden mit seinem Stand ist, 
        /// kann er den jeweiligen Button drücken, um diese Methode zu starten.
        /// Zuerst wird die erste Karte des Dealer aufgedeckt, 
        /// damit im Anschluss mit der entsprechenden Methode(„Stay“), 
        /// die sich in der Game-Klasse befindet, der Zug gestartet werden kann.
        /// Wenn der Dealer fertig mit seinem Zug ist werden seine Karten 
        /// mit der Methode „GetDealerCards“ aktualisiert,
        /// um sie dann durch eine for-Schleife aufzudecken und im
        /// FlowLayoutPanel anzuzeigen. Ist dies erledigt, wird abgefragt, 
        /// welche Person verloren, gewonnen oder über den Kartenwert 21 
        /// gekommen ist. Dies alles passiert, wieder durch die entsprechenden 
        /// Methoden aus der Game-Klasse. Wenn der Player gewonnen hat,
        /// bekommt er seinen Gewinn, ansonsten geht er leer aus.
        /// Es kann aber auch sein, dass ein Gleichstand der Kartenwerte besteht,
        /// also die Werte des Dealers/Players. 
        /// In diesem Fall bekommt der Spieler seinen Einsatz zurück. 
        /// Am Ende wird wieder Methode ControlStructures() ausgeführt. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStay_Click(object sender, EventArgs e)
        {
            PictureBox pbx = (PictureBox)flpDealer.Controls[0];
            pbx.SizeMode = PictureBoxSizeMode.Zoom;
            pbx.Width = 100;
            pbx.Height = 120;

            pbx.Image = (Bitmap)rm.GetObject(dealerCards[0].ToString());

            game.Stay();
            dealerCards = game.GetDealerCards();
            for (int i = 2; i < dealerCards.Count; i++)
            {
                pbx = new PictureBox();
                pbx.SizeMode = PictureBoxSizeMode.Zoom;
                pbx.Width = 100;
                pbx.Height = 120;
                pbx.Image = (Bitmap)rm.GetObject(dealerCards[i].ToString());
                flpDealer.Controls.Add(pbx);
            }
            lblHandValueD.Text = game.GetDealerPoints().ToString();

            if (game.WinLossDraw() == 1)
            {
                MessageBox.Show("Sie haben gewonnen!");
                game.GetMoney(Convert.ToInt32(tbxMoneyStake.Text));
                lblValueWallet.Text = game.Balance().ToString();
                einsatz.Balance = game.Balance();
                tbxMoneyStake.Text = "0";
                btnStay.Enabled = false;
                btnHit.Enabled = false;
            }

            if (game.WinLossDraw() == 2)
            {
                MessageBox.Show("Dealer hat gewonnen!");
                tbxMoneyStake.Text = "0";
                btnStay.Enabled = false;
                btnHit.Enabled = false;

            }
            if (game.WinLossDraw() == 0)
            {
                MessageBox.Show("Gleichstand!");
                game.GetMoney(Convert.ToInt32(tbxMoneyStake.Text) / 2);
                lblValueWallet.Text = game.Balance().ToString();
                einsatz.Balance = game.Balance();
                tbxMoneyStake.Text = "0";
                btnStay.Enabled = false;
                btnHit.Enabled = false;

            }

            if (game.BustDealer())
            {
                MessageBox.Show("Dealer ist über 21!");
                game.GetMoney(Convert.ToInt32(tbxMoneyStake.Text));
                lblValueWallet.Text = game.Balance().ToString();
                einsatz.Balance = game.Balance();
                tbxMoneyStake.Text = "0";
                btnStay.Enabled = false;
                btnHit.Enabled = false;
            }
            lblHandValueD.Text = game.GetDealerPoints().ToString();
            lblPlaced.Visible = false;

            ControlStructures(answer);
        }
        #endregion

        #region Kontrollstrukturen
        /// <summary>
        /// Diese Methode liefert nichts zurück. 
        /// Diese Methode ist dazu zuständig sämtliche abfragen auszuführen, 
        /// also ob der Spieler kein Geld mehr hat, noch spielen möchte oder auch nicht,
        /// nachdem er verloren/gewonnen hat.
        /// </summary>
        /// <param name="answer"></param>
        private void ControlStructures(DialogResult answer)
        {
            answer = MessageBox.Show("Möchten Sie erneut spielen?", "Neues Spiel", MessageBoxButtons.YesNo);

            if (game.Balance() == 0)
            {
                MessageBox.Show("Sie können nicht mehr weiterspielen, da sie kein Geld mehr haben!!", "Kein Geld");
                answer = MessageBox.Show("Möchten Sie von neu starten?", "Kein Geld", MessageBoxButtons.YesNo);

                if (answer == DialogResult.Yes)
                {
                    Application.Restart();
                }

                if (answer == DialogResult.No)
                {
                    MessageBox.Show("Sie können nicht weiterspielen!! Das Spiel wird geschlossen!!");
                    Application.Exit();
                }
            }

            walletBalance = game.Balance();
            if (answer == DialogResult.Yes)
            {
                einsatz = new FrmEinsatz(walletBalance);
                neuesSpielToolStripMenuItem_Click(answer, e);
            }

            if (answer == DialogResult.No)
            {
                Application.Exit();
            }
        }
        #endregion

        #region SpielstandSpeichern
        /// <summary>
        /// Diese Methode liefert nichts zurück. 
        /// Hier werden sämtliche Informationen, des Spiels in einer Datei gespeichert.
        /// (IST ABER NOCH IN ARBEIT)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void spielSpeichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.SaveGame(@"C:\Users\Petar\Desktop\Blackjack\Software\" + "game");
        }
        #endregion

        #region rest
        private void BlackJack_Load(object sender, EventArgs e)
        {

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void flpPlayer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDealer_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #endregion
    }
}
