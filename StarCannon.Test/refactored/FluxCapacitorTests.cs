using NUnit.Framework;
using StarCannon.CannonBits;

namespace StarCannon.Test.refactored
{
    class FluxCapacitorTests
    {
        [Test]
        public void CalculatesTheCorrectAmountOfGigawatts()
        {
            var fluxCapacitor = new flux_capacitor();

            Assert.AreEqual(1.21, fluxCapacitor.calculateGigawatts());
        }
    }
}
