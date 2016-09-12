using Classes;
using NUnit.Framework;
using System;

namespace CalculatorTest.Classes
{
    [TestFixture]
    [Category("Calculator")]
    class CalculatorTest
    {


        [Test]
        [Category("Adding")]
        [MaxTime(1000)] /* Max execution time of a second */
        [Repeat(10)]
        public void ShouldAddTwoNumbers()
        {
            // System Under Test (sut)
            var sut = new Calculator();

            Assert.That(sut.Add(1, 2), Is.EqualTo(3));
        }

        [Test]
        [Category("Adding")]
        [Ignore("Broken by design ;)")]
        public void ShouldAddTwoNumbersSkipped()
        {
            // System Under Test (sut)
            var sut = new Calculator();

            Assert.That(sut.Add(1, 2), Is.EqualTo(3));
        }

        [Test]
        public void ShouldMultiplyTwoNumbers()
        {
            var sut = new Calculator();
            Assert.That(sut.Multiply(2, 10), Is.EqualTo(20));
        }

        [Test]
        public void ShouldAddDoubles()
        {
            var sut = new Calculator();
            var result = sut.Add(1.1, 2.2);

            // within adds a tolerance to the result
            /*
				Also available:
					Is.Positive
					Is.Negative
					Is.NaN
			 */
            Assert.That(result, Is.EqualTo(3.3).Within(0.01));
        }

        [Test]
        public void ShouldErrorWhenDivideByZero()
        {
            var sut = new Calculator();

            Assert.That(() => sut.Divide(10, 0), Throws.Exception);
        }

        [Test]
        public void ShouldErrorWhenDivideByZeroExplicit()
        {
            var sut = new Calculator();

            Assert.That(() => sut.Divide(10, 0), Throws.TypeOf<DivideByZeroException>());
        }

        [Test]
        public void ShouldErrorWhenValueTooHigh_Explicit()
        {
            var sut = new Calculator();

            Assert.That(() => sut.Divide(1000, 0), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void ShouldErrorWhenValueTooHigh_MoreExplicit()
        {
            var sut = new Calculator();

            Assert.That(() => sut.Divide(1000, 0),
                Throws.TypeOf<ArgumentOutOfRangeException>()
                .With.Matches<ArgumentOutOfRangeException>(x => x.ParamName == "value")

                );
        }

    }
}
