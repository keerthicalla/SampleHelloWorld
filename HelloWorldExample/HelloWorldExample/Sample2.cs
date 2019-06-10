using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldExample
{
    class Sample2
    {
        static void main()
        {
            int num = 0;
            Console.WriteLine("Enter integer Value");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("num = " +num);
            Console.ReadKey();
        }
    }
}
