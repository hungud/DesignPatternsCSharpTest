using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public sealed class LoadBalancer
    {
        private static LoadBalancer _instance;
        
        // extend
        private List<string> _servers = new List<string>();
        private Random _random = new Random();

        // lock
        private static object syncLock = new object();

        private LoadBalancer() {

            _servers.AddRange(new List<string>() { 
                "ServerI",
                "ServerII",
                "ServerIII",
                "ServerIV",
                "ServerV",
            });
            
        }

        public static LoadBalancer GetSingleton()
        {
            // Support multithreaded applications through
            // 'Double checked locking' pattern which (once
            // the instance exists) avoids locking each
            // time the method is invoked

            if (_instance == null)
            {
                lock (syncLock)
                {
                    if (_instance == null) _instance = new LoadBalancer();
                }
            }

            return _instance;
        }

        // Simple, but effective random load server
        public string Server
        {
            get

            {
                int r = _random.Next(_servers.Count);
                return _servers[r].ToString();
            }
        }
    }
}
