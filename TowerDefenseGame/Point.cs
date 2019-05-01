using System;

namespace TowerDefense
{
    class Point {
        public readonly int X;      // Readonly does not allow changes to variable
        public readonly int Y;

        public Point(int x, int y) {
            X = x;
            Y = y;
        }

        public int DistanceTo(int x, int y) {
            int xDiff = X - x;
            int yDiff = Y - y;

            int xDiffSquared = xDiff * xDiff;
            int yDiffSquared = yDiff * yDiff;

            return (int)Math.Sqrt(xDiffSquared + yDiffSquared);
        }

        public int DistanceTo(Point point) {
            return DistanceTo(point.X, point.Y);
        }
    }
}