using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            Console.WriteLine("Enter Limit");
            int n, i, m1 = int.MinValue, m2 = int.MinValue;
            t = Console.ReadLine();
            int.TryParse(t, out n);
            int[] a = new int[n];
            Console.WriteLine("Enter elements of array:");
            for( i = 0; i < n; i++ )
            {
                t = Console.ReadLine();
                int.TryParse(t, out a[i]);
            }
            for( i = 0; i < a.Length; i++ )
            {
                if( m1 < a[i] )
                {
                    m2 = m1;
                    m1 = a[i];
                }
                else if( m2 < m1 && m2 < a[i] )
                {
                    m2 = a[i];
                }
            }
            Console.WriteLine("Second largest element is: {0}", m2);
            Console.Read();
        }
    }
}
