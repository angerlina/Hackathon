using System;
using System.Diagnostics;
using NUnit.Framework;

namespace OgrnGenerator
{
    [TestFixture]
    public class OgrnGeneratorServiceTests
    {
        [Test]
        public void GeneratorReturnsString()
        {
            OgrnGeneratorService testExample = new OgrnGeneratorService();
            var result = testExample.Generate("1");
            Assert.IsTrue(result is string);
        }

        [Test]
        public void GeneratorReturnsResultNotZertLengthForEntity()
        {
            OgrnGeneratorService testExample = new OgrnGeneratorService();
            string result = testExample.Generate("1");
            Assert.IsTrue(result.Length != 0);
        }

        [Test]
        public void GeneratorReturnsResultNotZeroLengthForIndividual()
        {
            OgrnGeneratorService testExample = new OgrnGeneratorService();
            string result = testExample.Generate("2");
            Assert.IsTrue(result.Length != 0);
        }
    }
}