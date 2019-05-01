namespace TowerDefense
{
    class Point {
        public readonly int X;      // Readonly does not allow changes to variable
        public readonly int Y;

        public Point(int x, int y) {
            X = x;
            Y = y;
        }
    }
}