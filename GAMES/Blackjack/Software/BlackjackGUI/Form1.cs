using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Resources;
using Blackjack.Logic;

namespace BlackjackGUI
{
    public partial class Form1 : Form
    {
        private ResourceManager rm;
        private Stack s;
        private Deck d;
        private int click = 0;
        private Card toGive;
        private string toGiveCardName;
        private Hand h1;
        private Hand h2;
        private Hand h3; 
        private Hand h4;

        public Form1()
        {
            InitializeComponent();
            rm = new ResourceManager("BlackjackGUI.Properties.Resources", Assembly.GetExecutingAssembly());
            pbxPlayer1.Image = (Bitmap)rm.GetObject("CardSkin");
            pbxPlayer2.Image = (Bitmap)rm.GetObject("CardSkin");
            pbxPlayer3.Image = (Bitmap)rm.GetObject("CardSkin");
            pbxPlayer4.Image = (Bitmap)rm.GetObject("CardSkin");
            pbxStack.Image =   (Bitmap)rm.GetObject("CardSkin");
            d = new Deck();
            s = new Stack();
            h1 = new Hand();
            h2 = new Hand();
            h3 = new Hand();
            h4 = new Hand();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            pbxPlayer1.Image = (Bitmap)rm.GetObject("CardSkin");
            pbxPlayer2.Image = (Bitmap)rm.GetObject("CardSkin");
            pbxPlayer3.Image = (Bitmap)rm.GetObject("CardSkin");
            pbxPlayer4.Image = (Bitmap)rm.GetObject("CardSkin");
            pbxStack.Image = (Bitmap)rm.GetObject("CardSkin");

            d = new Deck();
            s = new Stack();

            h1 = new Hand();
            h2 = new Hand();
            h3 = new Hand();
            h4 = new Hand();

            s.AddDeck(d);
            s.Shuffle();
            lblStackCount.Text = s.Value.ToString();
            click = 0;

            lblValue1.Text = 0.ToString();
            lblValue2.Text = 0.ToString();
            lblValue3.Text = 0.ToString();
            lblValue4.Text = 0.ToString();

            lblPlayer2.Visible = false;
            lblPlayer1.Visible = false;
            lblPlayer3.Visible = false;
            lblPlayer4.Visible = false;
            

        }

        private void pbxStack_Click(object sender, EventArgs e)
        {
            try
            {
                //Prüft ob noch Karten im Stack vorhanden sind
                if (s.Value == 0)
                {
                    pbxStack.Image = (Bitmap)rm.GetObject("");
                    MessageBox.Show("Das Stack ist leer!!!");
                }

                //Am Anfang wird eine Karte vom Stack genommen und angezeigt
                if (click == 0)
                {
                    toGive = s.GetCard();
                    toGiveCardName = toGive.ToString();
                    pbxStack.Image = (Bitmap)rm.GetObject(toGiveCardName);
                    lblStackCount.Text = s.Value.ToString();
                }

                if (click == 1)
                {
                    //Anzeigen des 1.Spielers
                    lblPlayer1.Visible = true;
                    lblPlayer2.Visible = false;
                    lblPlayer3.Visible = false;
                    lblPlayer4.Visible = false;

                    //Die Karte, die zum Spieler gegeben wurde, wird hier angezeigt
                    pbxPlayer1.Image = (Bitmap)rm.GetObject(toGiveCardName);

                    //Die Karte, die der Spieler bekommen hat, wird zur Hand hinzugefügt und der Karten wird ausgerechnet 
                    h1.TakeCard((BlackjackCard)toGive);
                    lblValue1.Text = h1.Points.ToString();

                    //Es wird eine neue Karte vom Stack genommen und angezeigt
                    toGive = s.GetCard();
                    toGiveCardName = toGive.ToString();
                    pbxStack.Image = (Bitmap)rm.GetObject(toGiveCardName);
                    lblStackCount.Text = s.Value.ToString();

                }

                if (click == 2)
                {
                    //Anzeigen des 2.Spielers
                    lblPlayer2.Visible = true;
                    lblPlayer1.Visible = false;
                    lblPlayer3.Visible = false;
                    lblPlayer4.Visible = false;

                    //Die Karte, die zum Spieler gegeben wurde, wird hier angezeigt
                    pbxPlayer2.Image = (Bitmap)rm.GetObject(toGive.ToString());

                    //Die Karte, die der Spieler bekommen hat, wird zur Hand hinzugefügt und der Karten wird ausgerechnet 
                    h2.TakeCard((BlackjackCard)toGive);
                    lblValue2.Text = h2.Points.ToString();

                    //Es wird eine neue Karte vom Stack genommen und angezeigt
                    toGive = s.GetCard();
                    toGiveCardName = toGive.ToString();
                    pbxStack.Image = (Bitmap)rm.GetObject(toGiveCardName);
                    lblStackCount.Text = s.Value.ToString();
                }

                if (click == 3)
                {
                    //Anzeigen des 3.Spielers
                    lblPlayer2.Visible = false;
                    lblPlayer1.Visible = false;
                    lblPlayer3.Visible = true;
                    lblPlayer4.Visible = false;

                    //Die Karte, die zum Spieler gegeben wurde, wird hier angezeigt
                    pbxPlayer3.Image = (Bitmap)rm.GetObject(toGive.ToString());

                    h3.TakeCard((BlackjackCard)toGive);
                    lblValue3.Text = h3.Points.ToString();

                    toGive = s.GetCard();
                    toGiveCardName = toGive.ToString();
                    pbxStack.Image = (Bitmap)rm.GetObject(toGiveCardName);
                    lblStackCount.Text = s.Value.ToString();
                }

                if (click == 4)
                {
                    lblPlayer2.Visible = false;
                    lblPlayer1.Visible = false;
                    lblPlayer3.Visible = false;
                    lblPlayer4.Visible = true;

                    pbxPlayer4.Image = (Bitmap)rm.GetObject(toGive.ToString());

                    h4.TakeCard((BlackjackCard)toGive);
                    lblValue4.Text = h4.Points.ToString();

                    toGive = s.GetCard();
                    toGiveCardName = toGive.ToString();
                    pbxStack.Image = (Bitmap)rm.GetObject(toGiveCardName);
                    lblStackCount.Text = s.Value.ToString();

                    click = 0;
                }

                click++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbxPlayer1_Click(object sender, EventArgs e)
        {

        }

    }
}
