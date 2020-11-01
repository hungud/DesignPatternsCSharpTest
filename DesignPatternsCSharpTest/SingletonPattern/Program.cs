using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //
            Console.WriteLine("Khoi tao 4 instance");

            //
            LoadBalancer b1 = LoadBalancer.GetSingleton();
            LoadBalancer b2 = LoadBalancer.GetSingleton();
            LoadBalancer b3 = LoadBalancer.GetSingleton();
            LoadBalancer b4 = LoadBalancer.GetSingleton();

            // Same instance?
            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("===> cung van chi la mot instance\n");
            }

            // Load balance 15 server requests
            LoadBalancer balancer = LoadBalancer.GetSingleton();
            for (int i = 0; i < 15; i++)
            {
                string server = balancer.Server;
                Console.WriteLine("Yêu cầu gửi đến: " + server);
            }

            // Wait for user
            Console.ReadLine();
        }
    }
}
