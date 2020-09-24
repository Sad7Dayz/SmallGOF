using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    abstract class AbstactFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }
}
