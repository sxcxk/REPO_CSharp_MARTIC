using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Logic
{
    /// <summary>
    /// Diese Klasse wird verwendet, um eines neues mit der Klasse Card zu erstellen, 
    /// damit danach ein neues Stack für das Spiel erstellen kann.
    /// </summary>
    public class Deck
    {
        #region Fields and Properties  
        List<Card> deck;
        #endregion

        #region Methods
        /// <summary>
        /// In dieser Methode wird das Deck zurückgeliefert,
        /// besser gesagt, die Liste deck mit den vorhandenen Karten.
        /// </summary>
        /// <returns>Liefert die Karten als Liste zurück</returns>
        public List<Card> GetCards()
        {
            return deck;
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Dies ist der Konstruktor. Hier werden die ganzen Karten erstellt für das Deck.
        /// Das heißt, dass 2 for-Schleifen verwendet werden, 
        /// eine ist für die Erstellung der Art der Karten und die andere für die Werte. 
        /// Die erste ist für die Art und muss deswegen 4 durchlaufen, 
        /// wegen (Karo, Pik, Kreuz, Herz). 
        /// Die 2. muss 13 durchlaufen werden.
        /// </summary>
        public Deck()
        {
            deck = new List<Card>();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 14; j++)
                {
                    CardColor c = (CardColor)i;
                    CardValue v = (CardValue)j;
                    BlackjackCard bjc = new BlackjackCard(c,v);
                    deck.Add(bjc);
                   
                }
            }
        }
        #endregion
    }
}
