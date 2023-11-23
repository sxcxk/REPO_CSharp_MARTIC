using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper.Logic
{
    public class PlayGround
    {
        #region Fields and Properties
        private Field[,] fields;
        private Random rnd;
        private int count = 0;
        private string difficulty;
        public int diff;
        #endregion

       
        #region Methods
        private void PlaceMines()
        {

            rnd = new Random();
            int x = 0;
            int y = 0;
            int placedBombs = 0;

            if (diff == 10)
            {
                do
                {
                    x = rnd.Next(diff);
                    y = rnd.Next(diff);

                    if (FieldHasMine(x, y) == false)
                    {
                        fields[x, y].HasBomb = true;
                        placedBombs += 1;
                    }
                } while (placedBombs < diff);
            }

            if (diff == 20)
            {
                do
                {
                    x = rnd.Next(diff);
                    y = rnd.Next(diff);

                    if (FieldHasMine(x, y) == false)
                    {
                        fields[x, y].HasBomb = true;
                        placedBombs += 1;
                    }
                } while (placedBombs < diff*2);
            }

            if (diff == 30)
            {
                do
                {
                    x = rnd.Next(diff);
                    y = rnd.Next(diff);

                    if (FieldHasMine(x, y) == false)
                    {
                        fields[x, y].HasBomb = true;
                        placedBombs += 1;
                    }
                } while (placedBombs < diff*3);
            }
        }

        private void CalculateSurroundingMines()
        {
            for (int x = 0; x < diff; x++)
            {
                for (int y = 0; y < diff; y++)
                {
                    Field f = (Field)fields[x, y];

                    if (FieldHasMine(x-1, y+1))
                    {
                        f.SurroundingMines += 1;
                    }

                    if (FieldHasMine(x, y+1))
                    {
                        f.SurroundingMines += 1;
                    }

                    if (FieldHasMine(x+1,y+1))
                    {
                        f.SurroundingMines += 1;
                    }

                    if (FieldHasMine(x-1, y))
                    {
                        f.SurroundingMines += 1;
                    }

                    if (FieldHasMine(x+1,y))
                    {
                        f.SurroundingMines += 1;
                    }

                    if (FieldHasMine(x+1, y-1))
                    {
                        f.SurroundingMines += 1;
                    }

                    if (FieldHasMine(x, y-1))
                    {
                        f.SurroundingMines += 1;
                    }

                    if (FieldHasMine(x -1, y -1))
                    {
                        f.SurroundingMines += 1;
                    }
                }
            }
        }


        public int FieldLength()
        {
            return this.diff;
        }
        public void TagField(int x, int y)
        {
            if (FieldTagged(x,y) == true) 
            {
                fields[x, y].IsTagged = false;
                return;
            }

            if (FieldTagged(x,y) == false)
            {
                fields[x, y].IsTagged = true;
                return;
            }
        }

        public bool FieldTagged(int x, int y)
        {
            return fields[x, y].IsTagged;
        }

        public int SurroundingMines(int x, int y)
        {
            return fields[x, y].SurroundingMines;
        }

        public bool FieldHasMine(int x, int y)
        {
            if (x > -1 && x < diff && y > -1 && y < diff) 
            {
                return fields[x, y].HasBomb;
            }
            return false;
        }

        public int TurnOverField(int x, int y)
        {
            if (fields[x,y].TurnedOver == true)
            {
                fields[x, y].TurnedOver = false;
                return 0;
            }

            if (fields[x,y].TurnedOver == false)
            {
                fields[x, y].TurnedOver = true;
                return 1;
            }
            return -1;
        }

        public void UncoverAllFields(int x, int y)
        {

            if (x > -1 && x < diff && y > -1 && y < diff) 
            {
                if (SurroundingMines(x, y) == 0 && fields[x, y].TurnedOver == false && FieldHasMine(x, y) == false) 
                {
                    fields[x, y].TurnedOver = true;
                    UncoverAllFields(x + 1, y);
                    UncoverAllFields(x - 1, y);
                    UncoverAllFields(x + 1, y + 1);
                    UncoverAllFields(x - 1, y + 1);
                    UncoverAllFields(x, y + 1);
                    UncoverAllFields(x, y - 1);
                    UncoverAllFields(x + 1, y - 1);
                    UncoverAllFields(x - 1, y - 1);
                    return;

                }


                if (SurroundingMines(x, y) > 0 && fields[x, y].TurnedOver == false && FieldHasMine(x, y) == false) 
                {
                    fields[x, y].TurnedOver = true;
                    return;
                }
            }
            return;
        }

        public int ShowUncoveredFields(int x, int y)
        {
            if (fields[x, y].TurnedOver == true && fields[x, y].SurroundingMines > 0)
            {
                return fields[x, y].SurroundingMines;
            }
            if (fields[x, y].TurnedOver == true && fields[x, y].SurroundingMines == 0)
            {
                return 0;
            }

            return -1;
        }
        #endregion


        public bool CheckTurnedOver(int x, int y)
        {
            if (fields[x,y].TurnedOver == true)
            {
                return true;
            }
            return false;
        }

        
        #region Constructors
        public PlayGround(string dif)
        {
            this.difficulty = dif;

            if (difficulty == "easy")
            {
                this.diff = 10;
            }

            if (difficulty == "medium")
            {
                this.diff = 20;
            }

            if (difficulty == "hard")
            {
                this.diff = 30;
            }

            this.fields = new Field[diff, diff];
            for (int x = 0; x < diff; x++)
            {
                for (int y = 0; y < diff; y++)
                {
                    this.fields[x, y] = new Field();
                }
            }
            PlaceMines();
            CalculateSurroundingMines();
        }
    }
        #endregion
}

