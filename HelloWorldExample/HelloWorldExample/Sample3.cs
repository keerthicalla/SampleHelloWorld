using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldExample
{
    class Sample3
    {
        static void main()
        {
            int num1, num2,num3;
            Console.WriteLine("Enter integer Value");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = num1 + num2;
            Console.WriteLine("Total is " + num3);
            Console.WriteLine("This is the sample file for Testing JIRA workflow triggers");
            Console.ReadKey();
            
        }
    }
}
