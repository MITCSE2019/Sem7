using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    public delegate void PriceChangedEventHandler();
    class Item
    {
        public event PriceChangedEventHandler PriceChanged;

        private string name;
        private double price;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }


        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                if (PriceChanged != null) { PriceChanged(); }
            }
        }

        public void ChangeDetected()
        {
            Console.WriteLine("The new price is {0}", price);
        }


        static void Main(string[] args)
        {
            Item item = new Item();
            item.Name = "Bat";
            item.Price = 44.4;
            Console.WriteLine("The value of {0} is {1}",item.Name,item.Price); 
            Console.Read();
            item.PriceChanged += item.ChangeDetected;
            item.Price *= 2;
            Console.Read();
            Console.Read();

        }

    }
}
