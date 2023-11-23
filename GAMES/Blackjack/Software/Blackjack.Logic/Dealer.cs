using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Logic
{
    /// <summary>
    /// Diese Klasse wird dazu verwendet, 
    /// um einen neuen Spieler zu erstellen, 
    /// damit man diesen in der Game-Klasse bzw. im GUI verwenden kann.
    /// Zusätzlich ist der Dealer dazu verantwortlich das Stack zu erstellen
    /// und verwalten, damit gespielt werden kann.
    /// </summary>
    public class Dealer : Person
    {
        #region Fields and Properties 
        private Stack s;
        #endregion

        #region Methods

        /// <summary>
        /// In dieser Methode nimmt der Dealer die oberste Karte vom Stack 
        /// (mit der GetCard-Methode, die sich in der Stack-Klasse befindet), 
        /// um sie später dem Spieler geben zu können.
        /// </summary>
        /// <returns>Diese Methode liefert eine Karte zurück.</returns>
        public Card TakeCardStack()
        {
            Card c = s.GetCard();
            return c;
        }

        /// <summary>
        /// Diese Methode liefert nichts zurück.
        /// In dieser Methode wird zuerst ein neues Deck erstellt, 
        /// damit dann ein neues Stack mit dem Deck erstellt werden kann.
        /// Am Ende wird das Stack nochmal gemischt (mit der Methode Shuffle, 
        /// die sich in der Stack-Klasse befindet).   
        /// </summary>
        public void CreateNewStack()
        {
            Deck deck = new Deck();
            this.s.AddDeck(deck);
            this.s.Shuffle();
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Dies ist keine Methode, sondern der Konstruktor. 
        /// Im Konstruktor wird ein neues Stack erstellt, 
        /// damit es dann mit den Methoden verbunden werden kann z.B Shuffle().
        /// </summary>
        public Dealer()
        {
            this.s = new Stack();
        }
        #endregion
    }
}
