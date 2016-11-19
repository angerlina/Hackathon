using NUnit.Framework;

namespace SexGenerator
{
    [TestFixture]
    public class SexGeneratorServiceTests
    {
        [Test]
        public void GeneratorReturnsString()
        {
            SexGeneratorService testExample = new SexGeneratorService();
            var result = testExample.Generate("ru");
            Assert.IsTrue(result is string);
        }

        [Test]
        public void GeneratorReturnsCorrectResultForRu()
        {
            SexGeneratorService testExample = new SexGeneratorService();
            string result = testExample.Generate("ru");
            Assert.IsTrue(result == "мужской" || result == "женский");
        }

        [Test]
        public void GeneratorReturnsCorrectResultForEn()
        {
            SexGeneratorService testExample = new SexGeneratorService();
            string result = testExample.Generate("en");
            Assert.IsTrue(result == "male" || result == "female");
        }

        [Test]
        public void GeneratorReturnsCorrectResultForDe()
        {
            SexGeneratorService testExample = new SexGeneratorService();
            string result = testExample.Generate("de");
            Assert.IsTrue(result == "männlich" || result == "weiblich");
        }

        [Test]
        public void GeneratorReturnsCorrectResultForFr()
        {
            SexGeneratorService testExample = new SexGeneratorService();
            string result = testExample.Generate("fr");
            Assert.IsTrue(result == "mâle" || result == "femelle");
        }

        [Test]
        public void GeneratorReturnsCorrectResultForCh()
        {
            SexGeneratorService testExample = new SexGeneratorService();
            string result = testExample.Generate("ch");
            Assert.IsTrue(result == "男性" || result == "女性");
        }
    }
}