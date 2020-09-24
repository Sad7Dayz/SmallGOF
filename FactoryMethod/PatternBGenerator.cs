using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class PatternBGenerator : EnemyGenerator
    {
        public override void CreateEnemys()
        {
            Enemys.Add(new Slime());
            Enemys.Add(new Slime());
            Enemys.Add(new Slime());
            Enemys.Add(new Zombie());
            Enemys.Add(new Zombie());
            Enemys.Add(new Zombie());
            Enemys.Add(new Zombie());
        }
    }
}
