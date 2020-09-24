using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class Abstraction
    {
        protected Implementor implementor;

        public Implementor Implementor
        {
            set
            {
                implementor = value;
            }
        }

            public virtual void Operation()
        {
            implementor.Operation();
        }
    }
}
