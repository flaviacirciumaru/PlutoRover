using System.Collections.Generic;

namespace PlutoTover_UnitTestProject
{
    internal class Position
    {
        private int xCoordinate;
        private int yCoordinate;
        private char orientation;

        public Position(int x, int y, char orientation)
        {
            xCoordinate = x;
            yCoordinate = y;
            this.orientation = orientation;
        }

        public Position()
        {
            XCoordinate = 0;
            YCoordinate = 0;
            Orientation = 'N';
        }

        public int XCoordinate { get => xCoordinate; set => xCoordinate = value; }
        public int YCoordinate { get => yCoordinate; set => yCoordinate = value; }
        public char Orientation { get => orientation; set => orientation = value; }

        public Position(Position anotherPosition)
        {
            XCoordinate = anotherPosition.XCoordinate;
            YCoordinate = anotherPosition.YCoordinate;
            Orientation = anotherPosition.Orientation;
        }

        /* verifying objects by value, not by reference*/
        public override bool Equals(object obj)
        {
            if (obj is Position)
            {
                var that = obj as Position;
                return XCoordinate == that.XCoordinate
                    && YCoordinate == that.YCoordinate
                    && Orientation == that.Orientation;
            }

            return false;
        }

        public override int GetHashCode()
        {
            var hashCode = 699838344;
            hashCode = hashCode * -1521134295 + xCoordinate.GetHashCode();
            hashCode = hashCode * -1521134295 + yCoordinate.GetHashCode();
            hashCode = hashCode * -1521134295 + orientation.GetHashCode();
            hashCode = hashCode * -1521134295 + XCoordinate.GetHashCode();
            hashCode = hashCode * -1521134295 + YCoordinate.GetHashCode();
            hashCode = hashCode * -1521134295 + Orientation.GetHashCode();
            return hashCode;
        }
    }
}