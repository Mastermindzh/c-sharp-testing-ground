using Classes;
using NUnit.Framework;

namespace CalculatorTest.Classes
{
	[TestFixture]
	public class NameJoinerTests
	{


		NameJoiner sut;

		[OneTimeSetUp]
		public void setup()
		{
			sut = new NameJoiner();
		}

		[Test]
		public void ShouldJoinNames()
		{
			Assert.That(sut.JoinNames("Sarah", "Smith"), Is.EqualTo("Sarah Smith"));
		}

		[Test]
		public void ShouldJoinNamesIgnoreCase()
		{
			Assert.That(sut.JoinNames("Sarah", "Smith"), Is.EqualTo("sarah smith").IgnoreCase);
		}
	}
}