using System;
using System.Runtime.InteropServices;

namespace AdapterPattern
{
    class Program
    {

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleOutputCP(uint wCodePageID);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleCP(uint wCodePageID);



        static void Main(string[] args)
        {
            SetConsoleOutputCP(65001);
            SetConsoleCP(65001);
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=====================");
            
            Console.WriteLine("Client1 - gọi chưa có adapter sử dụng đúng Target của hệ thống ví dụ: chỉ cần insert dữ liệu vào mssql");
            var client1 = new Client(target: new Target());
            client1.MakeRequest();

            Console.WriteLine("=====================");

            Console.WriteLine("Client2 - gọi cần có adapter sử dụng, ví dụ: cần insert vào Oracle và MariaDB");            
            var client2 = new Client(target: new Adapter());
            client2.MakeRequest();


            Console.WriteLine("=====================");
            Console.WriteLine("Enter để kết thúc");
            Console.ReadLine();
        }
    }
}
