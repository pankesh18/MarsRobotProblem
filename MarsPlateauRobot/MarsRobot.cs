using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsPlateauRobot
{
    internal class MarsRobot
    {
        public enum Directions
        {
            North,
            South,
            East,
            West
        }
        internal Directions Direction { get; private set; }
        internal int xLimit { get; private set; }
        internal int yLimit { get; private set; }
        internal int x { get; private set; }
        internal int y { get; private set; }
     
        

        public MarsRobot(Directions init_Direction, int init_XLimit, int init_YLimit)
        {
            Direction=init_Direction;
            xLimit=init_XLimit;
            yLimit= init_YLimit;
            x = 1;
            y = 1;
        }


        internal void GoRight()
        {
            switch (Direction)
            {
                case Directions.North:
                    Direction = Directions.East;
                    break;
                case Directions.South:
                    Direction = Directions.West;
                    break;
                case Directions.East:
                    Direction = Directions.South;
                    break;
                case Directions.West:
                    Direction = Directions.North;
                    break;
            }
        }

        internal void GoLeft()
        {
            switch (Direction)
            {
                case Directions.North:
                    Direction = Directions.West;
                    break;
                case Directions.South:
                    Direction = Directions.East;
                    break;
                case Directions.East:
                    Direction = Directions.North;
                    break;
                case Directions.West:
                    Direction = Directions.South;
                    break;
            }
        }

        internal void GoForward()
        {
            switch (Direction)
            {
                case Directions.East:
                    if(x < xLimit)  x++;
                    break;
                case Directions.West:
                    if (x < xLimit) x--;
                    break;
                case Directions.North:
                    if (y < yLimit) y++;
                    break;
                case Directions.South:
                    if (y < yLimit) y++;
                    break;
            }
        }
    }
}
