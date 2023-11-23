using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace Minesweeper.Logic
{
    public class GameButton : System.Windows.Forms.Button
    {
        #region Fields and Properties
        private int x;
        private int y;

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

        #region Constructors
        public GameButton(int x, int y)
        {
            this.x = x;
            this.y = y;

            this.Size = new System.Drawing.Size(30, 30);
        }
        #endregion

        #region Methods

        #endregion
    }
}
