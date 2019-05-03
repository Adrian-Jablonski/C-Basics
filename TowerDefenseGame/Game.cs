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
                MapLocation mapLocation = new MapLocation(20, 20, map);
            }
            catch (OutOfBoundsException ex) {
                Console.WriteLine(ex.Message);
            }
            catch (DefenseException) {
                Console.WriteLine("Unhandled tree house defense exception");
            }
            catch (Exception) {
                Console.WriteLine("Unhandled exception");
            }

            Console.ReadLine();
        }
    }
}