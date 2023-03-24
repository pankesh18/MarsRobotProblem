using MarsPlateauRobot;

namespace TestRobot
{
    public class Tests
    {
        
        [Test]
        public void TestMarsRobotExpected()
        {
            string plateauGrid = "5x5";
            string nav_path = "FFRFLFLF";
            string expected_result = "1,4,West";

            MarsRobot MR = new MarsRobot(MarsRobot.Directions.North, plateauGrid);
            MR.NavigateRobot(nav_path);
            Assert.AreEqual(expected_result, MR.ToString());

      
        }

        [Test]
        public void TestPositionZero()
        {
            string plateauGrid = "5x5";
            string nav_path = "FFRFLFLF";
            string expected_result = "1,4,West";

            MarsRobot MR = new MarsRobot(MarsRobot.Directions.North, plateauGrid);
            MR.NavigateRobot(nav_path);

            Assert.GreaterOrEqual(MR.x,1);
            Assert.GreaterOrEqual(MR.y,1);

        }

        [Test]
        public void TestPositionOutOfBound()
        {
            string plateauGrid = "5x5";
            string nav_path = "FFRFLFLF";
            string expected_result = "1,4,West";

            MarsRobot MR = new MarsRobot(MarsRobot.Directions.North, plateauGrid);
            MR.NavigateRobot(nav_path);
            int x_max = Convert.ToInt32(plateauGrid.Split("x")[0]);
            int y_max = Convert.ToInt32(plateauGrid.Split("x")[1]);

            Assert.IsTrue(MR.x <= x_max);
            Assert.IsTrue(MR.y <= y_max);

        }
    }
}