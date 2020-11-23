using System;
using System.Collections.Generic;
using System.Linq;
using StarCannon.refactored.CannonBits;

namespace StarCannon.refactored
{
    public class NumberAdder
    {
        public static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        public static int AddNumbers(IEnumerable<int> numbers)
        {
            return numbers.Sum();
        }
    }

    public class CannonFirer
    {
        public void FireTheCannon()
        {
            ChargeTheCapacitor();

            Console.WriteLine("Bang!");
        }

        private static void ChargeTheCapacitor()
        {
            var theNumberes = NumberAdder.AddNumbers(1, 2);
            var theOtherNumbers = NumberAdder.AddNumbers(new List<int> {1, 2, 3, 4});

            const int size = 3;
            var capacitor = new FluxCapacitor(size);
        }
    }
}