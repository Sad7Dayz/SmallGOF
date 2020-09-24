using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class SpicyPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough()
        {
            pizza.SetDough("pan baked");
        }

        public override void BuildSauce()
        {
            pizza.SetSauce("hot");
        }

        public override void BuildTopping()
        {
            pizza.SetTopping("pepparoni+salami");
        }
    }
}
