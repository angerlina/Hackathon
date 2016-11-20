using NUnit.Framework;

namespace PinGenerator
{
    public class PinGeneratorServiceTests
    {
        [Test]
        public void PinLengthTest()
        {
            PinGeneratorService testExample = new PinGeneratorService();
            string result = testExample.Generate();
            Assert.IsTrue(result.Length == 4);
        }

        [Test]
        public void PinIntTest()
        {
            PinGeneratorService testExample = new PinGeneratorService();
            string result = testExample.Generate();
            int num;
            Assert.IsTrue(int.TryParse(result, out num));
        }
    }
}