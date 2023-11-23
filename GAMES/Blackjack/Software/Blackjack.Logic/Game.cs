using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Blackjack.Logic
{

    /// <summary>
    /// Die Klasse dientnt zur Verwaltung des Spiels, die dazu mehrere Klassen beinhaltet.
    /// </summary>
    public class Game
    {
        #region Fields and Properties
        private Dealer d;
        private Player p;
        private Card c;
        private List<Card> pListCard;
        private List<Card> dListCard;
        #endregion

        #region Methods

        /// <summary>
        /// Die Hit-Methode bekommt eine Karte vom Dealer, 
        /// damit diese Karte im letzten Schritt dem Spieler übergeben werden kann,
        /// ( falls der Benutzer diese Methode mit einem Button auslöst).
        /// </summary>
        /// <returns>Liefert eine Karte zurück</returns>
        public Card Hit()
        {
            c = d.TakeCardStack();
            p.TakeCard(c);
            return c;
        }


        /// <summary>
        /// In dieser Methode wird der Wert der Hand des Spielers zurückgeliefert, 
        /// dabei wird eine Methode verwendet, die sich in der Klasse Person befindet, benutzt.
        /// Auf diese Methode wird in einem späteren Zeitpunkt Bezug genommen. 
        /// </summary>
        /// <returns>Liefert die Punkte des Spielers zurück</returns>
        public int GetPlayerPoints()
        {
            return p.GetPoints();
        }


        /// <summary>
        /// In dieser Methode wird der Wert der Hand des Dealers zurückgeliefert, 
        /// dabei wird eine Methode verwendet, die sich in der Klasse Person befindet, benutzt. 
        /// Auf diese Methode wird in einem späteren Zeitpunkt Bezug genommen. 
        /// </summary>
        /// <returns>Liefert die Punkte des Dealers</returns>
        public int GetDealerPoints()
        {
            return d.GetPoints();
        }


        /// <summary>
        /// Die Stay-Methode startet den Zug des Dealers. Der Dealer nimmt solange eine Karte, 
        /// bis er nicht auf den Kartenwert 17 oder höher kommt. 
        /// </summary>
        public void Stay()
        {

            while (GetDealerPoints() < 17)
            {
              c = d.TakeCardStack();
              d.TakeCard(c);
             
            }
        }


        /// <summary>
        /// In dieser Methode wird geprüft, ob der Dealer oder Spieler gewonnen hat, indem die Kartenwerte verglichen werden. 
        /// Also, wenn der Spieler einen höheren Kartenwert als der Dealer hat aber nicht über 21 liegt, 
        /// dann hat der Spieler gewonnen und es wird der int-Wert 1 zurückgeliefert. 
        /// Falls es umgekehrt ist, 
        /// wird der Wert 2 zurückgeliefert. 
        /// Wenn die beiden den gleichen Kartenwert haben, dann wird der Wert 0 zurückgegeben. 
        /// </summary>
        /// <returns>Liefert einen int Wert zurück (0,1,2 oder -1)</returns>
        public int WinLossDraw()
        {

            if (GetPlayerPoints() > GetDealerPoints() && GetPlayerPoints() <= 21)
            {
                return 1;
            }

            if ( GetPlayerPoints() < GetDealerPoints() && GetDealerPoints() <= 21)
            {
                return 2;
            }

            if (GetPlayerPoints() == GetDealerPoints())
            {
                return 0;
            }
            return -1;
        }


        /// <summary>
        /// Die Methode prüft, ob der Spieler über den Wert 21 gekommen ist,
        /// falls dies passiert, wird der Wert true zurückgegeben, ansonsten false. 
        /// Der Wert der Hand vom Spieler wird mit der Methode, 
        /// die sich in der Game-Klasse befindet, geholt(GetPlayerPoints).
        /// </summary>
        /// <returns>Liefert einen Bool zurück</returns>
        public bool BustPlayer()
        {

            if (GetPlayerPoints() > 21)
            {
                return true;
            }

            return false;
        }


        /// <summary>
        /// Die Methode prüft, ob der Dealer über den Wert 21 gekommen ist, 
        /// falls dies passiert, wird der Wert true zurückgegeben, ansonsten false. 
        /// Der Wert der Hand vom Dealer wird mit der Methode,
        /// die sich in der Game-Klasse befindet, geholt(GetDealerPoints).
        /// </summary>
        /// <returns>Liefert einen Bool zurück</returns>
        public bool BustDealer()
        {

            if (GetDealerPoints() > 21)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// In der Methode werden alle Karten gelöscht, die sich in den jeweiligen Listen befinden,
        /// das heißt die Liste des Dealers und Spielers, damit sie im Anschluss 
        /// wenn das neue Stack erstellt und vermischt wurde, mit jeweils 2 Karten befüllt werden.
        /// </summary>
        public void StartNewGame()
        {
            p.ClearHand();
            d.ClearHand();

            NewStack();

            p.TakeCard(d.TakeCardStack());
            p.TakeCard(d.TakeCardStack());

            d.TakeCard(d.TakeCardStack());
            d.TakeCard(d.TakeCardStack());
        }

        /// <summary>
        /// Bei dieser Methode erstellt der Dealer ein neues Stack für das neue Spiel.
        /// </summary>
        public void NewStack()
        {
            d.CreateNewStack();
        }

        /// <summary>
        /// Hier werden die ganzen Karten, die sich auf der Hand des Dealers befinden als Liste zurückgeliefert. 
        /// Dazu wird die Methode der Klasse Person verwendet, die später näher erklärt wird.
        /// </summary>
        /// <returns></returns>
        public List<Card> GetPlayerCards()
        {
            return p.GetCards();
        }

        /// <summary>
        /// Die Methode liefert den vorhandenen Geldbetrag, der sich im Wallet des Spielers befindet,
        /// zurück .Hier wird eine Methode benutzt, 
        /// die sich in der Klasse Player befindet, auf die aber später näher eingegangen wird.
        /// </summary>
        /// <returns>Liefert einen int-Wert</returns>
        public int Balance()
        {
            return p.GetBalance();
        }


        /// <summary>
        /// Hier werden die ganzen Karten, die sich auf der Hand des Spielers befinden als Liste zurückgeliefert. 
        /// Dazu wird die Methode der Klasse Person verwendet, die später näher erklärt wird.
        /// </summary>
        /// <returns>Liefert eine Liste von Karten</returns>
        public List<Card> GetDealerCards()
        {
           return d.GetCards();
        }


        /// <summary>
        /// In dieser Methode wird der Einsatz des Spielers getätigt.
        /// Dazu wird die Methode des Spielers verwendet, die später näher erklärt wird.
        /// </summary>
        /// <param name="amount"></param>
        public void SetBet(int amount)
        {
            p.Bet(amount);
        }


        /// <summary>
        /// Bei GetMoney wird dafür gesorgt, dass der Spieler seinen Gewinn bekommt.
        /// Dies geschieht mit einer Methode, die sich in der Player-Klasse befindet.
        /// Auf diese wird, wie bei den anderen Methoden, später Bezug genommen.
        /// </summary>
        /// <param name="amount"></param>
        public void GetMoney(int amount)
        {
            p.TakeMoney(amount*2);
        }


        /// <summary>
        /// Hier wird der Spielstand des aktuellen Spiels mit dem mitgegebenen File-Namen gespeichert, 
        /// indem zuerst die Karten,
        /// der Wert des Wallets und der Kartenwert des Spielers gespeichert werden. 
        /// Um danach die Karten und den Kartenwert des Dealers zu speichern. 
        /// Diese Daten werden in einer Datei hinzugefügt. 
        /// </summary>
        /// <param name="filename"></param>
        public void SaveGame(string filename)
        {
            try
            {
                FileStream fs = new FileStream(filename, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                

                sw.Write("Player;");

                for (int i = 0; i < GetPlayerCards().Count; i++)
                {
                    sw.Write((GetPlayerCards()[i].ToString()) + ";");
                }
                sw.Write((GetPlayerPoints().ToString()) + ";");
                sw.Write((Balance().ToString() +";"));

                sw.WriteLine("Dealer;");

                for (int i = 0; i < GetDealerCards().Count; i++)
                {
                    sw.Write((GetDealerCards()[i].ToString()) + ";");
                }
                sw.Write(GetDealerPoints().ToString());
               

                sw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadGame(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            string line;
            try
            {
                while ((line = sr.ReadLine())!=null)
                {
                    string[] data = line.Split(';');
                    for (int i = 0; i < data.Length; i++)
                    {
                        // In Arbeit
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Dies ist keine Methode, 
        /// sondern der Konstruktor der Klasse und besitzt deswegen an keinen Rückgabewert. 
        /// Der Konstruktor erstellt einen neuen Spieler beziehungsweise Dealer und 
        /// jeweils die Liste für den Dealer und Player.
        /// </summary>
        public Game()
        {
            this.p = new Player(); 
            this.d = new Dealer();
            this.pListCard = new List<Card>();
            this.dListCard = new List<Card>();
        }
        #endregion
    }
}
