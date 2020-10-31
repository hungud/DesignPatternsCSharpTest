using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class Adaptee
    {
        public void MethodB()
        {
            Console.WriteLine("Method B called: Thêm dữ liệu vào db Oracle");
        }

        public void MethodC()
        {
            Console.WriteLine("Method C called: Thêm dữ liệu vào db MariaDB");
        }
    }
}
