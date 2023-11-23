using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CatchTheMouse
{
    public class GameButton : System.Windows.Forms.Button
    {
        #region Felder
        public int x;
        public int y;
        #endregion

        #region Eigenschaften
        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }
        #endregion

        #region Konstruktoren
        public GameButton(int x, int y)
        {
            this.x = x;
            this.y = y;

            this.Size = new System.Drawing.Size(40, 40);
        }

        
        #endregion
    }
}
