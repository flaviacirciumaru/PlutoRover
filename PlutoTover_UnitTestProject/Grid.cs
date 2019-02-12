using System.Collections.Generic;

namespace PlutoTover_UnitTestProject
{
    internal class Grid
    {
        private int v1;
        private int v2;
        private List<KeyValuePair<int, int>> obstaclesPostion;

        public Grid(int v1, int v2, List<KeyValuePair<int, int>> obstaclesPostion)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.obstaclesPostion = obstaclesPostion;
        }
    }
}