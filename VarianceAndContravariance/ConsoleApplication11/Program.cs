using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            var human = new Human();


            // 1. Try removing the in keyword from ICallType - that should be compile time error
            // 2. delete  new AnimalTypeCaller() and try adding it by hand - the compiler should expect ICallType 
            //of type Human
            
            var humanTypeDiscoverer = new TypeDiscoverer<Human>(human,new AnimalTypeCaller());
            humanTypeDiscoverer.DiscoverType();

           

        }
    }
}
