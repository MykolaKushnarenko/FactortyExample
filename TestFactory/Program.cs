using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            TokkingFactory factory = new TokkingFactory("C#");
            ATokking tokking = factory.Create();
            tokking.Print();

            Console.ReadKey();
        }
    }
}
