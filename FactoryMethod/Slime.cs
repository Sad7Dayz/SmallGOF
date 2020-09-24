using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class Slime : Enemy
    {
        public Slime()
        {
            type = EnemyType.Slime;
            name = "Slime";
            hp = 200; exp = 15;
            Console.WriteLine("{0} : 출현!!", this.name);
        }
    }
}
