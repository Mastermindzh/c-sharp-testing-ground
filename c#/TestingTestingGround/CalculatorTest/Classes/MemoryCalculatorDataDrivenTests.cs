using NUnit.Framework;
using System.Collections;
using System;

namespace CalculatorTest.Classes
{
	[TestFixture]
	public class MemoryCalculatorDataDrivenTests
	{
		[TestCaseSource(typeof(ExampleTestCaseSource))]
		public void ShouldSubtractTwoNegativeNumbers(int firstNum, int secondNum, int expected)
		{
			var sut = new MemoryCalculator();

			sut.Substract(firstNum);
			sut.Substract(secondNum);

			Assert.That(sut.Amount, Is.EqualTo(expected));
		}
		
	}

	class ExampleTestCaseSource : IEnumerable
	{
		public IEnumerator GetEnumerator()
		{
			yield return new[] { 5, 10, -15 };
			yield return new[] { -5, -5, 10 };
		}
	}
}
