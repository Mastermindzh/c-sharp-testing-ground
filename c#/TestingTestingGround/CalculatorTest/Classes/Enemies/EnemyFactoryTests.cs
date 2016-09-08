using NUnit.Framework;
using TestingTestingGround.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingTestingGround.Classes.Enemies;
using TestingTestingGround.Classes.Enemies.Types;

namespace TestingTestingGround.Classes.Tests
{
	[TestFixture]
	public class EnemyFactoryTests
	{

		EnemyFactory sut;

		[SetUp]
		public void SetUp() {
			sut = new EnemyFactory();
		}

		[Test]
		public void ShouldCreateNormalEnemy()
		{
			var enemy = sut.Create(false);
			Assert.That(enemy, Is.TypeOf<NormalEnemy>());
		}
		[Test]
		public void ShouldCreateBossEnemy()
		{
			var enemy = sut.Create(true);
			Assert.That(enemy, Is.TypeOf<BossEnemy>());
		}

		[Test]
		public void ShouldBeOfBaseType()
		{
			var enemy = sut.Create(true);
			Assert.That(enemy, Is.InstanceOf<Enemy>());
		}

		[Test]
		public void ShouldHaveExtraPower() {
			var enemy = sut.Create(true);
			Assert.That(enemy, Has.Property("ExtraPower"));
		}
	}
}