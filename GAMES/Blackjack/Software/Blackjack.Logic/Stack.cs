using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Logic
{
    /// <summary>
    /// Diese Klasse wird dazu verwendet, damit eine neues Stack erstellt werden kann.
    /// </summary>
    public class Stack
    {
        #region Fields and Properties  
        List<Card> stack;
        public int count;

        /*In dieser Eigenschaft wird die Anzahl der Karten, 
        die sich im Stack befindet, zurückgeliefert.*/
        public int Value
        {
            get
            {
                return this.stack.Count;
            }
        }
        #endregion

        #region Method  
        /// <summary>
        /// Diese Methode liefert nichts zurück und hat einen Parameter
        /// (dort befindet sich eine Instanz, der Klasse Deck). 
        /// Bei dieser Methode wird mithilfe der Methode der Klasse Deck
        /// („GetCards“) ein neues Deck in das Stack gegeben. 
        /// </summary>
        /// <param name="d"></param>
        public void AddDeck(Deck d)
        {
           stack = d.GetCards();
        }


        /// <summary>
        /// Bei dieser Methode wird eine Karte von der obersten Stelle genommen. 
        /// Diese Methode wird in der Methode „TakeCardStack“ verwendet, 
        /// damit der Dealer eine Karte nehmen kann. 
        /// </summary>
        /// <returns>Diese Methode liefert eine Karte zurück</returns>
        public Card GetCard()
        {
            int index = stack.Count;
            if (index <= 0 && index > stack.Count)
            {
                return null;
            }
            Card c = (Card)stack[index - 1];
            stack.RemoveAt(index - 1);
            return c;
        }


        /// <summary>
        /// In dieser Methode werden die Karten, 
        /// die sich im Stack befinden, vermischt. 
        /// Dies passiert mithilfe der Random-Klasse. 
        /// Shuffle wird in der Dealer- Klasse verwendet(„CreateNewStack“). 
        /// </summary>
        public void Shuffle()
        {
            Random rnd = new Random();
            for (int i = 0; i < stack.Count; i++)
            {
                int rndIndex = rnd.Next(stack.Count);
                Card temp = stack[i];
                stack[i] = stack[rndIndex];
                stack[rndIndex] = temp;
            }
        }
        #endregion

        #region Constructors  
        /// <summary>
        /// Das ist der Konstruktor.
        /// Im Konstruktor wird eine neue Liste von Karten erstellt für das Stack.
        /// </summary>
        public Stack()
        {
            stack = new List<Card>();
        }
        #endregion
    }
}
