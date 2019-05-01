namespace TowerDefense
{
    class Map {
        public readonly int Width;      // Readonly does not allow changes to variable
        public readonly int Height;

        public Map(int width, int height) {
            Width = width;
            Height = height;
        }
    }
}