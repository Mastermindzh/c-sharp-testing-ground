using Classes;
using NUnit.Framework;
using System.Collections.Generic;

namespace CalculatorTest.Classes
{
	[TestFixture]
	public class PlayerCharacterTests
	{

		PlayerCharacter sut;

		[SetUp]
		public void setup()
		{
			// create and use property to set Health
			sut = new PlayerCharacter { Health = 100 };
		}

		[Test]
		public void ShouldIncreaseHealthAfterSleeping()
		{
			sut.Sleep();

			/*
			 Also available:
				Is.isGreaterThanOrEqualTo
				Is.LessThan
				Is.LessThanOrEqualTo
			 */
			Assert.That(sut.Health, Is.GreaterThan(100));
		}

		[Test]
		public void shouldGetRandomName()
		{
			Assert.That(sut.Name, Is.Not.Empty);
		}

		[Test]
		public void shouldNotHaveANickName()
		{
			Assert.That(sut.NickName, Is.Null);
		}


		[Test]
		public void ShouldIncreaseHealthAfterSleepingBetween1and100()
		{
			// Reset health to base value
			sut.Sleep();

			// range is inclusive
			Assert.That(sut.Health, Is.InRange(101, 200));
		}

		[Test]
		public void ShouldBeNewbie()
		{
			Assert.That(sut.IsNoob, Is.True);
		}

		[Test]
		public void ShouldTakeDamage()
		{
			var health = sut.Health;
			sut.TakeDamage(5);

			Assert.That(sut.Health, Is.LessThan(health));
		}

		[Test]
		public void ShouldHaveNoEmptyDefaultWeapons()
		{
			Assert.That(sut.Weapons, Is.All.Not.Empty);
		}

		[Test]
		public void ShouldHaveAStaff()
		{
			Assert.That(sut.Weapons, Contains.Item("Staff"));
		}

		[Test]
		public void ShouldHaveAtLeastOneKindOfSword()
		{
			Assert.That(sut.Weapons, Has.Some.Contains("Sword").IgnoreCase);
		}

		[Test]
		public void ShouldHaveTwoSwords()
		{
			Assert.That(sut.Weapons, Has.Exactly(2).EndsWith("sword").IgnoreCase);
		}

		[Test]
		public void ShouldNotHaveMoreThanOneTypeOfAGivenWeapon()
		{
			Assert.That(sut.Weapons, Is.Unique);
		}

		[Test]
		public void ShouldNotHaveAxe()
		{
			Assert.That(sut.Weapons, Has.None.EqualTo("Axe").IgnoreCase);
		}

		[Test]
		public void ShouldHaveAllExpectedWeapons()
		{
			var Weapons = new List<string> {
					"Sword",
					"Broadsword",
					"Bow",
					"Staff"
			};

			Assert.That(sut.Weapons, Is.EquivalentTo(Weapons));
		}

		[Test]
		public void ShouldHaveAllExpectedWeaponsInAlphabeticalOrder()
		{
			Assert.That(sut.Weapons, Is.Ordered);
		}

		[Test]
		public void ReferenceEquality() {
			var player1 = new PlayerCharacter();
			var player2 = player1;

			Assert.That(player1, Is.SameAs(player2));
		}

		[Test]
		public void ReferenceNonEquality()
		{
			var player1 = new PlayerCharacter();
			var player2 = new PlayerCharacter();

			Assert.That(player1, Is.Not.SameAs(player2));
		}
		
	}
}