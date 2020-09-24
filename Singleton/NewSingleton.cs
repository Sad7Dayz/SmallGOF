using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class NewSingleton
    {
        public string Name { get; set; }

        private static NewSingleton _instance;
        private static object syncLock = new object();

        protected NewSingleton()
        {
        }

        public static NewSingleton Instance()
        {
            if (_instance == null)
            {
                lock (syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new NewSingleton();
                    }
                }
            }
            return _instance;
        }
    }

    
}
