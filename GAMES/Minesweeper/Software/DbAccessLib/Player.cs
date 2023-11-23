using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccessLib
{
    public class Player
    {

        #region Fields and Properties
        private int id;
        private string name;
        private string level;
        private int highscore;
        private string scoredate;


        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Level
        {
            get { return this.level; }
            set { this.level = value; }
        }

        public int Highscore
        {
            get { return this.highscore; }
            set { this.highscore = value; }
        }

        public string Scoredate
        {
            get { return this.scoredate; }
            set { this.scoredate = value; }
        }
        #endregion

        #region Constructors
        public Player(int id, string name, string level, int highscore, string scoredate)
        {
            this.id = id;
            this.name = name;
            this.level = level;
            this.highscore = highscore;
            this.scoredate = scoredate;
        }
        #endregion

        #region Methods

        #endregion
    }
}
