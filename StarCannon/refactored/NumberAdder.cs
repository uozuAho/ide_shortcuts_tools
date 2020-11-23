using System.Collections.Generic;
using System.Linq;

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
}