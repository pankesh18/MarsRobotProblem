using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsPlateauRobot
{
    public class MarsRobot
    {
        public enum Directions
        {
            North,
            South,
            East,
            West
        }
        public Directions Direction { get; private set; }
        public int xLimit { get; private set; }
        public int yLimit { get; private set; }
        public int x { get; private set; }
        public int y { get; private set; }
     
        

        public MarsRobot(Directions init_Direction, string GridSize)
        {
            Direction=init_Direction;
            xLimit = Convert.ToInt32(GridSize.Split("x")[0]);
            yLimit = Convert.ToInt32(GridSize.Split("x")[1]);
            x = 1;
            y = 1;
        }

        public override string ToString()
        {
            return x.ToString() + "," + y.ToString() + "," + Direction.ToString();
        }






        public void NavigateRobot(string Nav_Instruction)
        {
            foreach(char direction in Nav_Instruction)
            {
                if (Char.ToLower(direction) == 'l')
                {
                    GoLeft();
                }
                else if (Char.ToLower(direction) == 'r')
                {
                    GoRight();
                }
                else
                {
                    GoForward();
                }
            }
        }



        public void GoRight()
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

        public void GoLeft()
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

        public void GoForward()
        {
            switch (Direction)
            {
                case Directions.East:
                    if (x < xLimit)
                        x ++;
                    break;
                case Directions.West:
                    if (x > 1)
                        x--;
                    break;
                case Directions.North:
                    if (y < yLimit) y++;
                    break;
                case Directions.South:
                    if (y > 1) y--;
                    break;
                
            }
        }

    }
}
