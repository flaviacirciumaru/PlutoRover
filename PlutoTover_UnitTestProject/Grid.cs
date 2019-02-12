using System.Collections.Generic;

namespace PlutoTover_UnitTestProject
{
    internal class Grid
    {
        private int numberOfLines;
        private int numberOfColumns;
        private readonly List<KeyValuePair<int, int>> obstaclesPostion;

        public Grid(int numberOfLines, int numberOfColumns, List<KeyValuePair<int, int>> obstaclesPostion)
        {
            this.numberOfLines = numberOfLines;
            this.NumberOfColumns = this.numberOfColumns;
            this.obstaclesPostion = obstaclesPostion;
        }

        public int NumberOfLines { get => numberOfLines; set => numberOfLines = value; }
        public int NumberOfColumns { get => numberOfColumns; set => numberOfColumns = value; }

        public List<KeyValuePair<int, int>> ObstaclesPostion => obstaclesPostion;
    }
}