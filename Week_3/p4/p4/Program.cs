using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4
{
    class Program
    {
        static void Main(string[] args)
        {
            double c;
            Item i = new Item();
            Console.WriteLine("Enter Product and Cost");
            i.name = Console.ReadLine();
            double.TryParse(Console.ReadLine(), out c);
            i.setc(c);
            Console.WriteLine("GST on {0} is {1}",i.name, i.CalcGst());
            Console.Read();
        }
    }
}
