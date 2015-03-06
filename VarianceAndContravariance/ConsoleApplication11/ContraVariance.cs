using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    public class Animal
    {
        public void SayYourType()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }


    public class Human : Animal
    {

    }

    public interface ICallType<in T>
    {
        void CallType(T x);
    }

    public class TypeDiscoverer<T>
    {
        T Item;
        ICallType<T> TypeCaller;

        public TypeDiscoverer(T item, ICallType<T> typeCaller)
        {
            Item = item;
            TypeCaller = typeCaller;
        }

        public void DiscoverType()
        {
            TypeCaller.CallType(Item);
        }
    }

    public class AnimalTypeCaller : ICallType<Animal>
    {
        public void CallType(Animal x)
        {
            x.SayYourType();
        }
    }
}
