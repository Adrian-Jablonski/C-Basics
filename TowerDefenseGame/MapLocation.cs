using System;

namespace TowerDefense
{
    class MapLocation : Point { // MapLocation is a subclass of point
        public MapLocation(int x, int y, Map map) : base(x, y) { // passed x,y to parent class
            if (!map.OnMap(this)) {
                throw new OutOfBoundsException(x + ", " + y + " is out of range of the map");
            }
        }
    }
}