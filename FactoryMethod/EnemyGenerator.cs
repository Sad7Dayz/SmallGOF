using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    abstract class EnemyGenerator
    {
        private List<Enemy> _enemy = new List<Enemy>(); public EnemyGenerator() { }
        public List<Enemy> Enemys { get { return _enemy; } }
        public abstract void CreateEnemys(); // Factory Method

    }
}
