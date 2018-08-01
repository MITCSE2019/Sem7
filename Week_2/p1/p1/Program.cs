using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, op, res = 0;
            Console.WriteLine("Enter numbers");
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            Console.WriteLine("Enter an option: \n 1.Addition\n 2.Subtraction\n 3.Multiplication\n 4.Division");
            string z = Console.ReadLine();
            int.TryParse( x, out a );
            int.TryParse( y, out b);
            int.TryParse(z, out op);
            if( op == 1 )
            {
                 res = a + b;
            }
            else if( op == 2 )
            {
                 res = a - b;
            }
            else if( op == 3 )
            {
                 res = a * b;
            }
            else if( op == 4 )
            {
                 res = a / b;
            }
            Console.WriteLine( "Result = {0}" ,res );
            Console.Read();
            return;
        }
    }
}
