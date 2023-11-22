using AlphabotLogic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabotLogic
{
    public class AlphabotInformation
    {
        private int _speed;
        private DriveControl _driveControl;
        private CollisionPrevention _collisionPrevention;

        public int Speed { get => _speed; set => _speed = value; }
        public DriveControl DriveControl { get => _driveControl; set => _driveControl = value; }
        public CollisionPrevention CollisionPrevention { get => _collisionPrevention; set => _collisionPrevention = value; }


        public AlphabotInformation(int speed,DriveControl driveControl, CollisionPrevention collisionPrevention)
        {
            _speed = speed;
            _driveControl = driveControl;
            _collisionPrevention = collisionPrevention;
        }

        public override string ToString()
        {
            string _byte1 = Convert.ToString((int)_collisionPrevention, 2)  + Convert.ToString((int)_driveControl, 2) + "11";
            string _byte2 = Convert.ToString(_speed, 2);

            int _numbyte1 = Convert.ToInt32(_byte1,2);
            int _numbyte2 = Convert.ToInt32(_byte2,2);
            return "Byte 1: " + _numbyte1 + ", " + _byte1 + "\n" + "Byte 2: " + _numbyte2 + ", " + _byte2 + "\n" + "Drive: " + _driveControl.GetType().Name + ", " + " Collision: " + _collisionPrevention.GetType().Name + ", " + "Speed: " + _speed + "%";
        }
    }
}
