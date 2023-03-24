namespace MarsPlateauRobot
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                //Input Plateau size
                Console.WriteLine("Enter grid size of the Mars Plateau (Example 3x3):");
                string GridSize = Console.ReadLine();

                //Create Mars robot
                MarsRobot MR = new MarsRobot(MarsRobot.Directions.North, GridSize);

                //Input robot navigation instrcutions and move robot
                Console.WriteLine("Enter navigation instructions (Example RLRLFL)");
                MR.NavigateRobot(Console.ReadLine());

                // Print Robot Position
                Console.WriteLine(MR.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong!!!");
                Console.WriteLine($"Error: {ex.Message}");
            }
        }   
    }
}
