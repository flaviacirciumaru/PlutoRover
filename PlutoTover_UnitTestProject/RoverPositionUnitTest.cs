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
            /*planet info*/
            /*the position of the obstacles is not important at this point*/
            List<KeyValuePair<int, int>> obstaclesPostion = null;
            Grid grid = new Grid(3, 3, obstaclesPostion);
        }
    }
}