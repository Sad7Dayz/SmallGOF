using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Adapter : Target
    {
        private Adaptee _adaptee = new Adaptee();

        public override void Request()
        {
            _adaptee.SpecificRequest();
        }
    }
}
