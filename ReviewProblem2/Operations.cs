using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblem2
{
    internal class Operations
    {
        public void DivideInt()
        {
            Console.WriteLine("Enter integer number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter integer number 1: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 / num2;
            Console.WriteLine("Result of division is = " + result);


        }
        public void DivideFloat()
        {
            Console.WriteLine("Enter integer number 1: ");
            float num3 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter integer number 1: ");
            float num4 = Convert.ToSingle(Console.ReadLine());

            float divResult= num3 / num4;
            Console.WriteLine("Result of division is = " + divResult);
        }
        public void StringCompare()
        {
            Console.WriteLine("Enter a String");
            String s= Console.ReadLine();
            if (s == s.ToUpper())
            {
                Console.WriteLine("String is in Uppercase");
            }
            else
            {
                Console.WriteLine("String is not in Uppercase");
            }
        }
    }
}
