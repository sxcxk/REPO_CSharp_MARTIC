using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Logic
{
    /// <summary>
    /// Diese Klasse wird dazu verwendet,
    /// damit der Kartenwert ausgegeben werden kann(Dealer, Player). 
    /// </summary>
    public class Hand
    {
        #region Fields and Properties
        private int points;
        private List<Card> bjcs;

        /// <summary>
        /// Hier wird geprüft, ob der Dealer/Player über den Wert 21 sind, 
        /// falls dies so ist, dann wird nach der Karte "Ass" 
        /// und 10 Punkte von dem aktuellen Kartenwert abgezogen.
        /// </summary>
        public int Points
        {
            get
            {
                this.points = 0;
                for (int i = 0; i < bjcs.Count; i++)
                {
                    
                    this.points +=((BlackjackCard) bjcs[i]).Value;
                    if (this.points > 21)
                    {
                        if (((BlackjackCard)bjcs[i]).Value == 11)
                        {
                            this.points += -10;
                        }
                    }
                }
                return this.points;
            }
        }

        /// <summary>
        /// Hier wird nur die Hand also die Karten, 
        /// die der Player/Dealer besitzt, zurückgeliefert. 
        /// </summary>
        public List<Card> CompleteHand
        {
            get
            {
                return this.bjcs;
            }
        }

        #endregion

        #region Method
        /// <summary>
        /// Die Methode liefert nichts zurück hat aber wohl einen Parameter. 
        /// Im Parameter ist eine Karte der Klasse BlackjackCard. 
        /// In dieser Methode wird eine übergebene BlackjackCard in die Liste bjcs hinzugefügt.
        /// </summary>
        /// <param name="card"></param>
        public void TakeCard(BlackjackCard card)
        {
            bjcs.Add(card);
        }


        /// <summary>
        /// Diese Methode liefert void zurück. 
        /// In dieser Methode werden die Karten, die sich auf der Hand gelöscht,
        /// besser gesagt die Liste bjcs wird geleert.
        /// </summary>
        public void ClearHand()
        {
            this.bjcs.Clear();
        }
        #endregion

        #region Constructors

        /// <summary>
        /// Das ist der Konstruktor der Klasse. Hier wird die Liste bjcs erstellt.
        /// </summary>
        public Hand()
        {
            bjcs = new List<Card>();
        }
        #endregion
    }
}
