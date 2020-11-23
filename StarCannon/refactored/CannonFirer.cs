using System;
using System.Collections.Generic;
using System.Linq;
using StarCannon.refactored.CannonBits;

namespace StarCannon.refactored
{
    public class CannonFirer
    {
        public void FireTheCannon()
        {
            var theNumberes = AddNumbers(1, 2);
            var theOtherNumbers = AddNumbers(new List<int> {1, 2, 3, 4});

            var capacitor = new FluxCapacitor();

            Console.WriteLine("Bang!");
        }

        private static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        private static int AddNumbers(IEnumerable<int> numbers)
        {
            return numbers.Sum();
        }
    }
}