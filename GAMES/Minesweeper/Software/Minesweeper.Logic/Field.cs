using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Logic
{
   public class Field
    {
        #region Fields and Properties
        private bool isTagged;
        private bool hasBomb;
        private int surroundingMines;
        private bool turnedOver;


        public bool TurnedOver
        {
            get
            {
                return this.turnedOver;
            }

            set
            {
                this.turnedOver = value;
            }
        }

        public int SurroundingMines
        {
            get 
            {
                return this.surroundingMines;
            }

            set
            {
                this.surroundingMines = value;
            }
        }

        public bool IsTagged
        {
            get
            {
                return this.isTagged;
            }

            set
            {
                this.isTagged = value;
            }
        }

        public bool HasBomb
        {
            get
            {
                return this.hasBomb;
            }

            set
            {
                this.hasBomb = value;
            }
        }
        #endregion

        #region Methods

        #endregion

        #region Constructors
        public Field()
        {
            this.hasBomb = false;
            this.turnedOver = false;
            this.isTagged = false;
            this.surroundingMines = 0;
        }
        #endregion
    }
}
