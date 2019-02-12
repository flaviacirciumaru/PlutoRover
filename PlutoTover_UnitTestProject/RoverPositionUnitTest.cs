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

        [TestMethod]
        public void Move_RotateRight()
        {
            /* planet info*/
            /* the position of the obstacles is not important at this point*/
            List<KeyValuePair<int, int>> obstaclePositions = null;
            Grid grid = new Grid(3, 3, obstaclePositions);

            /* rover info */
            Position initialPosition = new Position(0, 0, 'N');
            Rover rover = new Rover(initialPosition, grid);
            rover.Move('R');

            Position currentPosition = rover.CurrentPosition;
            Position expectedPosition = new Position(0, 0, 'E');

            Assert.AreEqual(expectedPosition, currentPosition);
        }

        [TestMethod]
        public void Move_WrappingEdge()
        {
            /* planet info */
            /* the position of the obstacles is not important at this point*/
            List<KeyValuePair<int, int>> obstaclePositions = null;
            Grid grid = new Grid(3, 3, obstaclePositions);

            /* rover info */
            Position initialPosition = new Position(0, 0, 'S');
            Rover rover = new Rover(initialPosition, grid);

            rover.Move('F');

            Position currentPosition = rover.CurrentPosition;
            Position expectedPosition = new Position(0, 2, 'S');

            Assert.AreEqual(expectedPosition, currentPosition);
        }

        [TestMethod]
        public void Move_RetreatIfObstacleFound()
        {
            /* planet info */
            /* Obstacles are represented by pairs of coordinates.
             * The (x, y) of the obstacle whould be avoided by the
             * rover by retreating to the last valid position. */
            var obstaclesPosition = new List<KeyValuePair<int, int>>()
            {
                new KeyValuePair<int, int>(0, 1),
                new KeyValuePair<int, int>(2, 2),
            };
            Grid grid = new Grid(4, 4, obstaclesPosition);

            /* rover info*/
            Position initialPosition = new Position(0, 0, 'N');
            Rover rover = new Rover(initialPosition, grid);
            rover.Move('F');

            Position currentPosition = rover.CurrentPosition;
            Position expectedPosition = new Position(0, 0, 'N');
        }

        [TestMethod]
        public void Move_MultipleCommands_NoObstacles()
        {
            /* planet info */
            /* the position of the obstacles is not important at this point */
            List<KeyValuePair<int, int>> obstaclePositions = null;
            Grid grid = new Grid(3, 3, obstaclePositions);

            /* rover info */
            Position initialPosition = new Position(0, 0, 'N');
            Rover rover = new Rover(initialPosition, grid);

            String commands = "FFRFF";
            foreach (char command in commands)
            {
                rover.Move(command);
            }

            Position currentPosition = rover.CurrentPosition;
            Position expectedPosition = new Position(2, 2, 'E');

            Assert.AreEqual(expectedPosition, currentPosition);
        }

        [TestMethod]
        public void Move_MultipleCommands_WithObstacles()
        {
            /* planet info */
            var obstaclePositions = new List<KeyValuePair<int, int>>(){
                new KeyValuePair<int, int>(2, 2),
            };
            Grid grid = new Grid(3, 3, obstaclePositions);

            /* rover info*/
            Position initialPosition = new Position(0, 0, 'N');
            Rover rover = new Rover(initialPosition, grid);

            String commands = "FFRFF";
            foreach (char command in commands)
            {
                rover.Move(command);
                /* no need to move follow further commands
                 * if there ia an obstacle ahead */
                if (rover.NoObstaclesFoundYet == false)
                    break;
            }

            Position currentPosition = rover.CurrentPosition;
            Position expectedPosition = new Position(1, 2, 'E');

            Assert.AreEqual(expectedPosition, currentPosition);
        }
    }
}
