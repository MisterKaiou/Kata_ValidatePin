using NUnit.Framework;
using Validate.Pin;

namespace Validate.UnitTests.Pin
{
    [TestFixture]
    public class Tests
    {
        public PinValidator validator = new PinValidator();

        [Test, Description("ValidatePin should return false for pins with lenght other than 4 or 6")]
        public void LengthTest()
        {
            Assert.IsFalse(validator.ValidatePin("1"), "\u2717 Pin size should not be lower then 4");
            Assert.IsFalse(validator.ValidatePin("12"), "\u2717 Pin size should not be lower then 4");
            Assert.IsFalse(validator.ValidatePin("123"), "\u2717 Pin size should not be lower then 4");
            Assert.IsFalse(validator.ValidatePin("12345"), "\u2717 Pin size should not be bigger then 6");
            Assert.IsFalse(validator.ValidatePin("000000000"), "\u2717 Pin size should not be bigger then 6");
            Assert.IsFalse(validator.ValidatePin("-1234"), "\u2717 Pin should not contain punctuation");
            Assert.IsFalse(validator.ValidatePin("1.234"), "\u2717 Pin should not contain punctuation");
            Assert.IsFalse(validator.ValidatePin("-1.234"), "\u2717 Pin should not contain punctuation");
        }

        [Test, Description("ValidatePin should not contains any non-number characters")]
        public void NonDigitTest()
        {
            Assert.IsFalse(validator.ValidatePin("a123"), "\u2717 Pin should not contains letters");
            Assert.IsFalse(validator.ValidatePin(".123"), "\u2717 Pin should not contains letters");
            Assert.IsFalse(validator.ValidatePin("123\n"), "\u2717 Pin size should not contain whitespaces or new-line characters");
            Assert.IsFalse(validator.ValidatePin("1234\n"), "\u2717 Pin size should not contain whitespaces or new-line characters");
            Assert.IsFalse(validator.ValidatePin("12345\n"), "\u2717 Pin size should not contain whitespaces or new-line characters");
            Assert.IsFalse(validator.ValidatePin("123456\n"), "\u2717 Pin size should not contain whitespaces or new-line characters");
            Assert.IsFalse(validator.ValidatePin("123 "), "\u2717 Pin size should not contain whitespaces or new-line characters");
            Assert.IsFalse(validator.ValidatePin("123 \n"), "\u2717 Pin size should not contain whitespaces or new-line characters");
        }

        [Test, Description("ValidatePin should return true for valid numbers")]
        public void ValidTest()
        {
            Assert.IsTrue(validator.ValidatePin("1234"), "\u2717 Pin should return true for valid pins");
            Assert.IsTrue(validator.ValidatePin("0000"), "\u2717 Pin should return true for valid pins");
            Assert.IsTrue(validator.ValidatePin("1111"), "\u2717 Pin should return true for valid pins");
            Assert.IsTrue(validator.ValidatePin("123456"), "\u2717 Pin should return true for valid pins");
            Assert.IsTrue(validator.ValidatePin("098765"), "\u2717 Pin should return true for valid pins");
            Assert.IsTrue(validator.ValidatePin("000000"), "\u2717 Pin should return true for valid pins");
            Assert.IsTrue(validator.ValidatePin("090909"), "\u2717 Pin should return true for valid pins");
        }
    }
}