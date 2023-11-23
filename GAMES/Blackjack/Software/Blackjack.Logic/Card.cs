using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Logic
{
    /// <summary>
    /// Diese Klasse wird dazu verwendet, um eine Karte zu erstellen.
    /// Auch werden hier der richtige Wert bzw. das richtige Bild für die Karte zugewiesen. 
    /// Dazu ist diese Klasse die Super-Klasse für die Klasse BlackjackCard.
    /// </summary>
    public abstract class Card
    {
        #region Fields and Properties  
        protected string filename;
        protected CardColor color;
        protected CardValue value;

        #endregion

        #region Method  
        /// <summary>
        /// In dieser Methode wird mithilfe der Enums die Art der Karte
        /// als auch der Wert durch Trennung eines “_“ zusammengefügt.
        /// </summary>
        /// <returns>Hier wird der Name der Karte als string zurückgeliefert</returns>
        public override string ToString()
        {
            return color + "_" + Enum.GetName(typeof(CardValue), value);
        }
        #endregion

        #region Constructors  
        /// <summary>
        /// Das ist der Konstruktor der Klasse, 
        /// der die folgenden Parameter besitzt: Instanz des Enums CardColor und CardValue. 
        /// Im Konstruktor werden, die im Parameter vorhandenen Werten,
        /// den Instanzen, die sich in der Klasse selbst befinden, zugewiesen.  
        /// </summary>
        /// <param name="color"></param>
        /// <param name="value"></param>
        public Card(CardColor color, CardValue value)
        {
            this.value = value;
            this.color = color;
        }
        #endregion
    }
}
