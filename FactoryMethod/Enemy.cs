using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public enum EnemyType { Zombie, Slime }

    abstract class Enemy
    {
        protected EnemyType type;
        protected string name;
        protected int hp;
        protected int exp;
        protected void Attack() { }

    }
}
