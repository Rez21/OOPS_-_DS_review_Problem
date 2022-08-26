using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblem2
{
    public class GenericOperations
    {
        public static void DivideByGeneric<T>(T Val1, T Val2) where T : notnull
        {

            dynamic d1 = Val1;
            dynamic d2 = Val2;
            dynamic result = d1 / d2;
            Console.WriteLine("Result=" + result);
                       
        }
    }
}
