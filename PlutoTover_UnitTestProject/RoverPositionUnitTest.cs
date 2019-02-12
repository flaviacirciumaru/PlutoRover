using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PlutoTover_UnitTestProject
{
    [TestClass]
    public class RoverPositionUnitTest
    {
        [TestMethod]
        public void Move_Forward_NoEdge()
        {
            /* planet info*/
            /* the position of the obstacles is not important at this point*/
            List<KeyValuePair<int, int>> obstaclesPostion = null;
            Grid grid = new Grid(3, 3, obstaclesPostion);

            /* rover info */
            Position initialPosition = new Position(0, 0, 'N');
            Rover rover = new Rover(initialPosition, grid);
            rover.Move('F');

            Position currentPositon = rover.CurrentPosition;
            Position expectedPosition = new Position(0, 1, 'N');

            Assert.AreEqual(expectedPosition, currentPositon);
        }
    }
}
