using System;

namespace TowerDefense
{
    class Game
    {
        public static void Main()
        {
            Tower tower = new Tower();

            Map map = new Map(8, 5);

            try {
                Path path = new Path(
                    new [] {
                        new MapLocation(0, 2, map),
                        new MapLocation(1, 2, map),
                        new MapLocation(2, 2, map),
                        new MapLocation(3, 2, map),
                        new MapLocation(4, 2, map),
                        new MapLocation(5, 2, map),
                        new MapLocation(6, 2, map),
                        new MapLocation(7, 2, map)
                    }
                );

                Invader invader = new Invader();
                MapLocation location = new MapLocation(0, 0, map);

                // invader.SetLocation(location);  // uses method setter

                // invader.Location = location; //uses property setter
                // location = invader.Location; // uses property getter
            }
            catch (OutOfBoundsException ex) {
                Console.WriteLine(ex.Message);
            }
            catch (DefenseException) {
                Console.WriteLine("Unhandled tree house defense exception");
            }
            catch (Exception ex) {
                Console.WriteLine("Unhandled exception: " + ex);
            }

            Console.ReadLine();
        }
    }
}