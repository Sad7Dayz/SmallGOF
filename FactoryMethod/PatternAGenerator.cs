using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class PatternAGenerator : EnemyGenerator
    {
        public override void CreateEnemys()
        {
            Enemys.Add(new Zombie());
            Enemys.Add(new Zombie());
            Enemys.Add(new Zombie());
            Enemys.Add(new Zombie());
            Enemys.Add(new Zombie());
            Enemys.Add(new Zombie());
            Enemys.Add(new Zombie());
            Enemys.Add(new Zombie());
        }
    }
}
