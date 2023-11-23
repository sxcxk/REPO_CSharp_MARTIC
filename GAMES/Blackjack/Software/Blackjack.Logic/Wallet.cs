using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Logic
{
    /// <summary>
    /// Die Wallet-Klasse ist dazu zuständig, 
    /// damit der Spieler seine Wette setzen kann, 
    /// bzw. seinen Gewinn auszahlen kann.
    /// </summary>
    public class Wallet
    {
        #region Fields and Properties
        private int balance;
        
        /* Hier wird die Eigenschaft intialisiert, 
           damit Geld setzen und abrufen kann(vom Wallet).*/
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
        #endregion

        #region Methods

        /// <summary>
        /// Diese Methode liefert nichts zurück. 
        /// Jedoch besitzt diese Klasse einen Parameter 
        /// -im Parameter wird ein int-Wert mitgegeben-. Diese Methode dient dazu, 
        /// um Geld in die Wallet einzuzahlen, d.h, 
        /// wenn der Spieler seinen Gewinn einzahlen möchte.
        /// Zudem wird diese Methode in der Klasse Player benutzt(TakeMoney).
        /// </summary>
        /// <param name="amount"></param>
        public void Deposit(int amount)
        {
            balance += amount;
        }

        /// <summary>
        /// Diese Methode liefert nichts zurück.
        /// Die Methode beinhaltet einen Parameter mit einem int-Wert.
        /// Sie wird benutzt, um Geld abzuheben(vom Wallet),
        /// damit der Spieler seine Wette setzen kann.
        /// Die Methode wird in der Player-Klasse verwendet.
        /// </summary>
        /// <param name="amount"></param>
        public void WithDraw(int amount)
        {
            if (balance > 0 && amount <= balance)
            {
                balance -= amount;
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Dies ist keine Methode, sondern der Konstruktor. 
        /// Hier sind 2 Konstruktoren enthalten, 
        /// wobei ein Konstruktor einen Parameter
        /// mit dem Datentyp int übergeben bekommt. Wird kein Wert mitgegeben, 
        /// so bekommt das Wallet einen fixen Startwert von 100$, 
        /// ansonsten wird der mitgegebene Wert eingetragen.
        /// </summary>
        public Wallet(int balance)
        {
            this.balance = balance;
        }

        public Wallet()
        {
            this.balance = 100;
        }
        #endregion
    }
}
