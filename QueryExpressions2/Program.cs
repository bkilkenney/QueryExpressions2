using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryExpressions2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test is a Delegate that references the i > 5 method
            Func<int, bool> test = i => i >= 5;
            //Delegate system <in parameter, out result>


            //Will call the test method and pass in the value in ()
            Console.WriteLine(test(3));
            Console.WriteLine(test(8));
     


        }
    }
}
