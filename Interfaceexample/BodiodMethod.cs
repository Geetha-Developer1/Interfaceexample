using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceexample
{
    class BodiodmethodExample
    {
        public void method() => Console.WriteLine("Method() is calling");
        public int square(int x) => x * x;
        public BodiodmethodExample() => Console.WriteLine("Constructor calling");
        public int number => 5;
    }
    internal class BodiodMethod
    {
        //static void Main(String[] args) //=> Console.WriteLine("Main() is calling");         
        //{
        //    BodiodmethodExample b = new BodiodmethodExample();
        //    b.method();
        //    b.square(10);

        //}
}
}
