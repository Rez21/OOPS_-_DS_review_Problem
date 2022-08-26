//Write interger number division , float number division  and compare the string must be in upper case only then refactor code by using generic method
namespace ReviewProblem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to select operation to perform");
            Console.WriteLine("1. Integer Division");
            Console.WriteLine("2. Float Division");
            Console.WriteLine("3. String UpperCase Check");
            Console.WriteLine("4. Division Generic");
           

            int ip = Convert.ToInt32(Console.ReadLine());
            switch (ip)
            {
                case 1:
                    Operations intDivision = new Operations();
                    intDivision.DivideInt();
                    break;

                case 2:
                    Operations floatDivision = new Operations();
                    floatDivision.DivideFloat();
                    break;
                case 3:
                    Operations stringCheck = new Operations();
                    stringCheck.StringCompare();
                    break;
                case 4:
                    GenericOperations.DivideByGeneric(30,3);
                    break;

            }
        }
    }
}