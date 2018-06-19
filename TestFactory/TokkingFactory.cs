using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFactory
{
    class TokkingFactory
    {
        public string _name { get; set; }

        public TokkingFactory(){}

        public TokkingFactory(string name)
        {
            _name = name;
        }

        public ATokking Create()
        {

            
            if (_name == "C#")
            {
                return new Sharp();
            }

            if (_name == "Java")
            {
                return new Java();
            }
            else
                return null;
        }
    }
}
