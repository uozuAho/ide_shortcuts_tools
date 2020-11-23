using NUnit.Framework;

namespace StarCannon.Test.refactored
{
    public class CannonFirerTests
    {
        [Test]
        public void TheCannonFires()
        {
            var cannon = new CannonFirer();

            cannon.fireTheCannon();

            Assert.DoesNotThrow(() => cannon.fireTheCannon());
        }
    }
}