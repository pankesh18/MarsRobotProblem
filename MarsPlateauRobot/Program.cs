namespace MarsPlateauRobot
{
    class Program
    {
        public static void Main(string[] args)
        {
            string GridSize;
            string Nav_Intruct;
            Console.WriteLine("Enter grid size of the Mars Plateau (Example 3x3):");
            GridSize= Console.ReadLine();

            

            MarsRobot MR = new MarsRobot(MarsRobot.Directions.North, GridSize);


            Console.WriteLine("Enter nagigation instructions (Example RLRLFL)");
           

            MR.NavigateRobot(Console.ReadLine());


            // Console.WriteLine(MR.x.ToString() + "," + MR.y.ToString() + "," + MR.Direction.ToString());

            Console.WriteLine(MR.ToString());
        }   
    }
}
