using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    sealed class OptimizeSingleton
    {
        public string Name { get; set; }

        private static readonly OptimizeSingleton _instance = new OptimizeSingleton();

        private OptimizeSingleton()
        {
        }

        public static OptimizeSingleton Instance()
        {
            return _instance;
        }
    }
}
