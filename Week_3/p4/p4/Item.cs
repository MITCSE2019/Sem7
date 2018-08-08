namespace p4
{
    internal class Item
    {
        public string name { get; set; }
        public static double cost;
        public double CalcGst()
        {
            return 0.08 * cost;
        }
        public void setc ( double c )
        {
            cost = c;
        }
    }
}