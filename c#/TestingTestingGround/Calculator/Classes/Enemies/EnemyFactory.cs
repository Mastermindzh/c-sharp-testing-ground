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
            else
            {
                return new NormalEnemy();
            }
        }

    }
}
