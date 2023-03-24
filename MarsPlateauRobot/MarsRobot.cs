using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsPlateauRobot
{
    public class MarsRobot
    {
        #region Direction Enum
        /// <summary>
        /// Enum of Directions
        /// </summary>
        public enum Directions
        {
            North,
            South,
            East,
            West
        }
        #endregion

        #region Class properties
        public Directions Direction { get; private set; }
        public int xLimit { get; private set; }
        public int yLimit { get; private set; }
        public int x { get; private set; }
        public int y { get; private set; }

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor to initialize the mars robot
        /// </summary>
        /// <param name="init_Direction"></param>
        /// <param name="GridSize"></param>
        public MarsRobot(Directions init_Direction, string GridSize)
        {
            Direction=init_Direction;
            xLimit = Convert.ToInt32(GridSize.Split("x")[0]);
            yLimit = Convert.ToInt32(GridSize.Split("x")[1]);
            x = 1;
            y = 1;
        }
        #endregion

        #region ToString
        /// <summary>
        /// Override of ToString of the class to display position
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return x.ToString() + "," + y.ToString() + "," + Direction.ToString();
        }
        #endregion

        #region Robot functions

        /// <summary>
        /// Method to navigate the robot taking each instructions
        /// </summary>
        /// <param name="Nav_Instruction"></param>
        public void NavigateRobot(string Nav_Instruction)
        {
            try
            {
                foreach (char direction in Nav_Instruction)
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
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Method to Move Robot to right
        /// </summary>
        public void GoRight()
        {
            try
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
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Method to move robot to left
        /// </summary>
        public void GoLeft()
        {
            try
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
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Method to move robot forward to facing direction
        /// </summary>
        public void GoForward()
        {
            try
            {
                switch (Direction)
                {
                    case Directions.East:
                        if (x < xLimit)
                            x++;
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
            catch(Exception ex)
            {
                throw;
            }
        }

        #endregion
    }
}
