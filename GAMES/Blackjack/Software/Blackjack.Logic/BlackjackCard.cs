using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Logic
{
    /// <summary>
    /// Diese Klasse wird dazu verwendet, um die Kartenwerte so umzuwandeln, 
    /// dass es für das spätere Spiel richtig gezählt werden kann.
    /// Dazu erbt diese Klasse von der Super-Klasse Card.
    /// </summary>
    public class BlackjackCard : Card
    {
        #region Fields and Properties

        /// <summary>
        /// Das ist eine Eigenschaft und liefert den Datentyp int zurück.
        /// Hier werden die Karten so umgewandelt, dass die Karten im späteren Spiel richtig gezählt werden können. Wenn die Karte z.B ein Ass, dann wird der Wert 11 für die Karte gespeichert.
        /// Und alle Bildkarten werden mit dem Wert 10 gezählt
        /// </summary>
        ///<returns>Liefert den umgewandelten Wert der Karte zurück</returns>
        public int Value
        {
            get
            {
                if (value == CardValue.Ass)
                {
                    return 11;
                }
                if (value >= CardValue.Bube)
                {
                    return 10;
                }
                return (int)value; 
            }
        }
        #endregion

        #region Method  

        #endregion

        #region Constructors  

        /// <summary>
        /// Das ist der Konstruktor der Klasse, der sämtliche Parameter, 
        /// aufgrund der zur erbenden Klasse Card, enthält.
        /// Hier wird nur die Instanz „value“
        /// (befindet sich eigentlich in der Klasse Card) 
        /// ein gerechter Startwert zugeordnet.
        /// </summary>
        /// <param name="color"></param>
        /// <param name="value"></param>
        public BlackjackCard(CardColor color, CardValue value) : base(color, value)
        {
            this.value = value;
        }
        #endregion
    }
}
