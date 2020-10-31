using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class Target : ITarget
    {
        public void MethodA()
        {
            Console.WriteLine("MethodA called: Thêm dữ liệu vào db Mssql");
        }
    }
}
