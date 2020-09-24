using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class HawaiienPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough()
        {
            pizza.SetDough("cross"); 
        }

        public override void BuildSauce()
        {
            pizza.SetSauce("mild");
        }

        public override void BuildTopping()
        {
            pizza.SetTopping("ham+pineapple");
        }
    }
}
