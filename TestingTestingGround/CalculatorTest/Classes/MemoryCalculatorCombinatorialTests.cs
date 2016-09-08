using Classes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest.Classes
{
	[TestFixture]
	class MemoryCalculatorCombinatorialTests
	{
		[Test]
		public void ShouldAddAndDivide(
			[Values(10,20,30)] int numToAdd,
			[Values(2,1,10)]int numToDivideBy)
		{
			var sut = new MemoryCalculator();
			sut.Add(numToAdd);
			sut.Divide(numToDivideBy);

		}
	}
}
