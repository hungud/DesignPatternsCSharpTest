using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public sealed class Singleton
    {
        private static Singleton _instance;
        private static object _lockThis = new object();

        private Singleton() { }

        public static Singleton GetSingleton()
        {
            if (_instance == null)
            {
                lock (_lockThis)
                {
                    if (_instance == null) _instance = new Singleton();
                }
            }

            return _instance;
        }
    }
}
