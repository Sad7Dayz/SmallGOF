using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class OldSingleton
    {
        public string Name { get; set; }

        private static OldSingleton _instance;

        protected OldSingleton()
        {
        }

        public static OldSingleton Instance()
        {
            if (_instance == null)
            {
                _instance = new OldSingleton();
            }

            return _instance;
        }
    }
}
