namespace TowerDefense
{
    class Path {
        private readonly MapLocation[] path;

        public Path(MapLocation[] path) {
            this.path = path;
        }

        public MapLocation GetLocationAt(int pathStep) {
            return (pathStep < this.path.Length) ? this.path[pathStep] : null;
        }
    }
}
