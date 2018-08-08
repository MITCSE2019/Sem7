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
            string t;
            Console.WriteLine("Enter Limit");
            t = Console.ReadLine();
            int n,x;
            int.TryParse(t, out n);
            Console.WriteLine("Enter elements of array");
            int i;
            int[]a = new int[n];
            for( i = 0; i < n; i++ )
            {
                t = Console.ReadLine();
                int.TryParse(t, out x);
                a[i] = x;
            }
            Array.Sort(a);
            Console.Write("Output after sort:\t");
            foreach( int y in a )
            {
                Console.Write("{0}\t", y);
            }
            Console.Write("\n");
            Array.Reverse(a);
            Console.Write("Output after reverse:\t");
            foreach (int y in a)
            {
                Console.Write("{0}\t", y);
            }
            Console.Read();
        }
    }
}
