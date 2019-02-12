using System.Collections.Generic;

namespace PlutoTover_UnitTestProject
{
    internal class Grid
    {
        private int numberOfLines;
        private int numberofColumns;
        private readonly List<KeyValuePair<int, int>> obstaclesPostion;

        public Grid(int numberOfLines, int numberOfColumns, List<KeyValuePair<int, int>> obstaclesPostion)
        {
            this.numberOfLines = numberOfLines;
            this.NumberofColumns = numberofColumns;
            this.obstaclesPostion = obstaclesPostion;
        }

        public int NumberOfLines { get => numberOfLines; set => numberOfLines = value; }
        public int NumberofColumns { get => numberofColumns; set => numberofColumns = value; }

        public List<KeyValuePair<int, int>> ObstaclesPostion => obstaclesPostion;
    }
}