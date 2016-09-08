using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingTestingGround.Classes.Enemies;
using TestingTestingGround.Classes.Enemies.Types;

namespace TestingTestingGround.Classes
{
	public class EnemyFactory
	{

		public Enemy Create(bool isBoss)
		{
			if (isBoss)
			{
				return new BossEnemy();
			}
			else {
				return new NormalEnemy();
			}
		}

	}
}
