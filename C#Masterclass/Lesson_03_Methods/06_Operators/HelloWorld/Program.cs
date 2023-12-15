using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            // unary operators (multyple)
            num3 = -num1;                                       // it multiplies by -1 
            Console.WriteLine("num3 is {0}", num3);

            bool isSunny = true;
            Console.WriteLine("Is it sunny {0}", !isSunny);     // "!" means it is "not"

            // increment operators
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num++);
            // pre increment
            Console.WriteLine("num is {0}", ++num);

            // decrement operator
            num--;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num--);
            // pre decrement
            Console.WriteLine("num is {0}", --num);

            int result;

            result = num1 + num2;
            Console.WriteLine("result of num1 + num2 is {0}", result);
            result = num1 - num2;
            Console.WriteLine("result of num1 - num2 is {0}", result);
            result = num1 / num2;
            Console.WriteLine("result of num1 / num2 is {0}", result);
            result = num1 * num2;
            Console.WriteLine("result of num1 * num2 is {0}", result);
            // modulo operator
            result = num1 % num2;
            Console.WriteLine("result of num1 % num2 is {0}", result);

            // relational and type operators
            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine("result of num1 < num2 is {0}", isLower);

            //equality operator
            bool isEqual;
            isEqual = num1 == num2;    // "==" means that we compare is whatever is on right, the same as whatever is on the left. It is comparing sign, it is bool.
            Console.WriteLine("result of num1 == num2 is {0}", isEqual);

            // conditional operators

            // AND operator
            bool isLowerAndSunny;
            isLowerAndSunny = isLower && isSunny; // so they all should be true to be true. Con1 AND Cond2
            Console.WriteLine("result isLower && isSunny {0}", isLowerAndSunny);

            // OR operator
            isLowerAndSunny = isLower || isSunny; // if one of them is true the whole statement will be true
            Console.WriteLine("result isLower || isSunny {0}", isLowerAndSunny);


        }

    }
}