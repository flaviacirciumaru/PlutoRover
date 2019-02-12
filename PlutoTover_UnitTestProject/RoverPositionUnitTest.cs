﻿using System;
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
    }
}
