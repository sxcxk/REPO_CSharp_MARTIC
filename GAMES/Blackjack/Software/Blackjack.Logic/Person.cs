using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Logic
{
    /// <summary>
    /// Das ist die Superklasse für die Player- und Dealer-Klasse. 
    /// Die Klasse selbst ist dazu da, 
    /// um die vorgegeben Methoden zu verwenden(die beide brauchen) 
    /// und um so wenig wie möglich Programmcode zu schreiben.
    /// </summary>
    public abstract class Person
    {
        #region Fields and Properties
        private Card card;
        private Hand h;

        //Hier wird die Eigenschaft initialisiert
        public Card Card
        {
            get
            {
                return this.card;
            }
        }

        #endregion

        #region Methods
        /// <summary>
        /// Diese Methode liefert nichts zurück, hat aber eine Karte als Parameter. 
        /// In dieser Methode bekommt die jeweilige Person(Dealer, Player) eine Karte in seine Hand (mit der Methode, 
        /// die sich in der Hand- Klasse befindet „TakeCard“).
        /// Also der Dealer nimmt sich eine Karte vom Stack(diese befindet sich zuerst im Parameter) 
        /// und gibt sie auf seine Hand. 
        /// Der Player bekommt vom Dealer die Karte(befindet sich zuerst im Parameter) 
        /// und gibt sie in seine Hand.
        /// </summary>
        /// <param name="c"></param>
        public void TakeCard(Card c)
        {
            h.TakeCard((BlackjackCard)c);
        }

        /// <summary>
        /// Mit dieser Methode bekommt man den Hand-Wert 
        /// der jeweiligen Person(mit der Eigenschaft, 
        /// die sich in der Hand-Klasse „Points“) befindet. 
        /// </summary>
        /// <returns>Diese Methode liefert den Datentyp int zurück.</returns>
        public int GetPoints()
        {
            return h.Points;
        }


        /// <summary>
        /// Diese Methode liefert den Datentyp void zurück.
        /// Mit dieser Methode wird der Wert der Hand, der jeweiligen Person, zurückgesetzt.
        /// Dies geschieht mit der Methode “ClearHand“, 
        /// die sich in der Hand-Klasse befindet.
        /// </summary>
        public void ClearHand()
        {
            h.ClearHand();
        }

        /// <summary>
        /// Bei dieser Methode wird die Eigenschaft
        /// „CompleteHand“(befindet sich in der Hand-Klasse) verwendet, 
        /// damit man alle Karten, die sich in der jeweiligen Hand befinden, 
        /// bekommen kann. 
        /// </summary>
        /// <returns>Diese Methode liefert eine Liste von Karten zurück.</returns>
        public List<Card> GetCards()
        {
            return h.CompleteHand;
        }

        #endregion

        #region Constructors
        /// <summary>
        /// Dies ist ein Konstruktor. In diesem wird nur eine neue Hand erstellt.
        /// </summary>
        public Person()
        {
           this.h = new Hand();
        }
        #endregion
    }
}
