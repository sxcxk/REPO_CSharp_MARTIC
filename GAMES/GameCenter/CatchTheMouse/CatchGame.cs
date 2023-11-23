using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheMouse
{
   public class CatchGame 
    {
        #region Felder
        private Random _rnd;
        public int[] catPos;
        public int[] mousePos;
        public MouseMove[] mouseMoves;
        public GameButton[,] buttons;
       

        #endregion
        #region Eigenschaften
        public Random _Rnd
        {
            get
            {
                return this._rnd;
            }

            set
            {
                this._rnd = value;
            }
        }

        public int[] CatPos
        {
            get
            {
                return this.catPos;
            }

            set
            {
                this.catPos = value;
            }
        }

        public int[] MousePos
        {
            get
            {
                return this.mousePos;
            }

            set
            {
                this.mousePos = value;
            }
        }

        #endregion

        #region methods

      public MouseMove FindMouseMove()
        {
            int index;
            int x = mousePos[0];
            int y = mousePos[1];

            do
            {
                index = _rnd.Next(8);
                x = mousePos[0] - mouseMoves[index].deltaX;
                y = mousePos[1] - mouseMoves[index].deltaY;
                this.mousePos[0] = x;
                this.mousePos[1] = y;

                if (mousePos[0] == 10 && mousePos[0] == 10)
                {
                    mousePos[0] = 9;
                    mousePos[1] = 9;
                }

                if (mousePos[0] == -1 && mousePos[1] == -1)
                {
                    mousePos[0] = 1;
                    mousePos[1] = 1;
                }

                if (x == 10 && y == 10)
                {
                    x = 9;
                    y = 9;
                }

                if (x == -1 && y == -1)
                {
                    x = 1;
                    y = 1;
                }


            } while (x == -1 || x == 10 || y == -1 || y == 10 || y == -1 && x == -1 || y == -1 && x == 10 || y == 10 && x == -1 || y == 10 && x == 10);

            MouseMove move = new MouseMove(x, y);
            return move;
        }


        #endregion

        #region Konstruktor
        public CatchGame()
        {
            this._rnd = new Random();
            this.buttons = new GameButton[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    buttons[i, j] = new GameButton(i, j);
                }
            }

            this.mouseMoves = new MouseMove[]
            {
                new MouseMove (-1,-1),
                new MouseMove (0,-1),
                new MouseMove (1,-1),
                new MouseMove (-1,0),
                new MouseMove (1,0),
                new MouseMove (-1,1),
                new MouseMove (0,1),
                new MouseMove (1,1),
            };


            this.catPos = new int[2];
            this.catPos[0] = 5;
            this.catPos[1] = 5;

            this.mousePos = new int[2];
            this.mousePos[0] = 0;
            this.mousePos[1] = 9;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                   
                }
            }

            this.catPos = new int[2];
            this.catPos[0] = 0;
            this.catPos[1] = 9;

            this.mousePos = new int[2];
            this.mousePos[0] = 5;
            this.mousePos[1] = 5;



        }
        #endregion


    }
}
