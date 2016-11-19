using NUnit.Framework;

namespace CreditCardNumberGenerator
{
    [TestFixture]
    public class CreditCardNumberGeneratorTests
    {
        [Test]
        public void GeneratorReturnsString()
        {
            CreditCardNumberGeneratorService testExample = new CreditCardNumberGeneratorService();
            var result = testExample.Generate();
            Assert.IsTrue(result is string);
        }
    }
}