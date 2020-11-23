using System;
using System.Collections.Generic;
using StarCannon.refactored.CannonBits;

namespace StarCannon.refactored
{
    public class CannonFirer
    {
        public void fireTheCannon()
        {
            int theNumberes = addNumbers(1, 2);
            int theOtherNumbers = addNumbers(new List<int> {1, 2, 3, 4});

            flux_capacitor capacitor = new flux_capacitor();

            Console.WriteLine("Bang!");
        }
        int addNumbers(int a, int b) {
            return a + b;           
        }
        int addNumbers(List<int> numbers) {
            int Sum = 0;    
            foreach (var number in numbers) 
            {
                Sum += 1;                
            }                

            return Sum;
        }
    }
}
