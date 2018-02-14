using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication30
{
    class Program
    {
        static void Main(string[] args)
        {
            MyIntArray array = new MyIntArray();

            array.Array ={2,3,4};

            Console.WriteLine(array.Array[1]);
        }
    }
}
