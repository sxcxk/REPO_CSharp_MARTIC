using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Logic
{
    public class Player : Person
    {
        #region Fields and Properties
        private Wallet w;
        #endregion

        #region Methods
        /// <summary>
        /// Diese Methode liefert nichts zurück. 
        /// Sie wird verwendet damit der Spieler einen Einsatz, 
        /// der im Parameter mitgegeben wird, tätigen kann.
        /// Zudem basiert diese Methode auf die Methode in der Wallet-Klasse,
        /// die sich WithDraw nennt.
        /// Die Methode Bet selbst wird in der Game-Klasse(SetBet) verwendet. 
        /// </summary>
        /// <param name="amount"></param>
        public void Bet(int amount)
        {
            w.WithDraw(amount);
        }

        /// <summary>
        /// Diese Methode liefert nichts zurück.
        /// Sie wird verwendet damit der Spieler seinen Gewinn entnimmt. 
        /// Zudem basiert diese Methode auf die Methode in der Wallet-Klasse, 
        /// die sich Deposit nennt.
        /// Die Methode TakeMoney-Methode wird in der Game-Klasse(GetMoney) verwendet. 
        /// </summary>
        /// <param name="amount"></param>
        public void TakeMoney(int amount)
        {
            w.Deposit(amount);
        }

        /// <summary>
        /// Sie wird verwendet damit der Spieler seinen aktuellen Wallet-Wert bekommt.
        /// Diese Methode verwendet dafür die Eigenschaft „Balance“, 
        /// die sich in der Wallet-Klasse befindet. 
        /// Die Methode selbst wird in der Game-Klasse (Balance) verwendet. 
        /// </summary>
        /// <returns>Diese Methode liefert einen int-Wert zurück.</returns>
        public int GetBalance()
        {
            return w.Balance;
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Dies ist ein Konstruktor. 
        /// Im Konstruktor wird ein Wallet erstellt 
        /// und mit einem Starbudget ausgestattet,
        /// welches in der Wallet-Klasse definiert wird. 
        /// </summary>
        public Player()
        {
            this.w = new Wallet();
        }
        #endregion
    }
}
