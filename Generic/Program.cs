using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyGenericClass<int> element = new MyGenericClass<int>();

            element.display();
        }
    }
}
