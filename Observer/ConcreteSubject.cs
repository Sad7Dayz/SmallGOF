using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class ConcreteSubject : Subject
    {
        public string SubjectState
        {
            get;
            set;
        }
    }
}
