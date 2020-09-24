using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class Zombie : Enemy
    {
        public Zombie()
        {
            type = EnemyType.Zombie;
            name = "Zombie";
            hp = 100;
            exp = 50;
            Console.WriteLine("{0} : 출현!!", this.name);
        }

    }
}
