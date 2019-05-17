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
            int a, b, c;
            Console.WriteLine("This is to test workflow with Triggers and conditions(Tester approval)");
            Console.WriteLine("Sample line of code:");
            Console.WriteLine("enter any number");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("Addition is" + c);
         }
    }
}
