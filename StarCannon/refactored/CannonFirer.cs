using System;
using System.Collections.Generic;
using StarCannon.refactored.CannonBits;

namespace StarCannon.refactored
{
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