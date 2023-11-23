using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheMouse
{
    public class MouseMove
    {
        #region Felder
        public int deltaX;
        public int deltaY;
        #endregion

        #region Eigenschaften
        public int DeltaX
        {
            get
            {
                return this.deltaX;
            }

            set
            {
                this.deltaX = value;
            }
        }
        #endregion

        #region Konstruktoren
        public MouseMove(int deltaX, int deltaY)
        {
            this.deltaX = deltaX;
            this.deltaY = deltaY;
        }
        #endregion

    }
}
