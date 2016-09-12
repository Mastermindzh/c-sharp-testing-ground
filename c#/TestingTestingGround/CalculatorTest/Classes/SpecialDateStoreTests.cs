using NUnit.Framework;
using System;

namespace Classes.Tests
{
    [TestFixture]
    public class SpecialDateStoreTests
    {
        [Test]
        public void ShouldHaveCorrectMilleniumDate()
        {
            var sut = new SpecialDateStore();
            var result = sut.DateOf("millennium");

            Assert.That(result, Is.EqualTo(new DateTime(2000, 1, 1, 0, 0, 0, 0)));
        }

        [Test]
        public void ShouldHaveCorrectMilleniumDate_WithTolerance()
        {
            var sut = new SpecialDateStore();
            var result = sut.DateOf("millennium");

            Assert.That(result,
                Is.EqualTo(new DateTime(2000, 1, 1, 0, 0, 0, 1))
                .Within(TimeSpan.FromMilliseconds(1)));

            Assert.That(result,
                Is.EqualTo(new DateTime(2000, 1, 1, 0, 0, 0, 1))
                .Within(1).Milliseconds);
        }
    }
}