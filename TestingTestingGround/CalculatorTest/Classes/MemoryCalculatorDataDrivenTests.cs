using NUnit.Framework;

namespace CalculatorTest.Classes
{
	[TestFixture]
	public class MemoryCalculatorDataDrivenTests
	{
		[TestCase(5,10,-15)]
		[TestCase(-5, -5, 10)]
		public void ShouldSubtractTwoNegativeNumbers(int firstNum, int secondNum, int expected)
		{
			var sut = new MemoryCalculator();

			sut.Substract(firstNum);
			sut.Substract(secondNum);

			Assert.That(sut.Amount, Is.EqualTo(expected));
		}
		
	}
}
