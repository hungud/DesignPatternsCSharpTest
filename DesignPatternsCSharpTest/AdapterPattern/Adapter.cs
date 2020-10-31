using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class Adapter : ITarget
    {
        Adaptee _adaptee = new Adaptee();

        public void MethodA()
        {
            _adaptee.MethodB();
            _adaptee.MethodC();
        }
    }
}
