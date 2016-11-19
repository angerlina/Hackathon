using System;
using System.Diagnostics;
using NUnit.Framework;

namespace InnGenerator
{
    [TestFixture]
    public class InnGeneratorServiceTests
    {
        [Test]
        public void GeneratorReturnsStringForIndividual()
        {
            InnGeneratorService testExample = new InnGeneratorService();
            var result = testExample.Generate("individual");
            Assert.IsTrue(result is string);
        }
        [Test]
        public void GeneratorReturnsStringForEntity()
        {
            InnGeneratorService testExample = new InnGeneratorService();
            var result = testExample.Generate("entity");
            Assert.IsTrue(result is string);
        }
        [Test]
        public void CheckInnLengthForIndividual()
        {
            InnGeneratorService testExample = new InnGeneratorService();
            string result = testExample.Generate("individual");
            Assert.IsTrue(result.Length == 12);
        }

        [Test]
        public void CheckInnLengthForEntity()
        {
            InnGeneratorService testExample = new InnGeneratorService();
            string result = testExample.Generate("entity");
            Assert.IsTrue(result.Length == 10);
        }

    }
}