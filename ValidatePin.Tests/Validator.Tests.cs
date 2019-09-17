using NUnit.Framework;
using Validate.Pin;

namespace Validate.UnitTests.Pin
{
    [TestFixture]
    public class Tests
    {
        public PinValidator validator = new PinValidator();

        [Test]
        public void LengthTest()
        {
            Assert.IsTrue(validator.ValidatePin(""));
        }
    }
}