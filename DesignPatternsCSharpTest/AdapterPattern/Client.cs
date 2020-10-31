using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class Client
    {
        private ITarget _target;

        public Client(ITarget target)
        {
            _target = target;
        }

        public void MakeRequest()
        {
            _target.MethodA();
        }
    }
}
