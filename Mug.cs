//Mug.cs

namespace FischerP3
{
    public class Mug : IItem
    {
        public string GetDesc(string usersText)
        {
            return " mug(s) ";
        }
        public double GetCost(int numItems)
        {
            return 10.99 * numItems;
        }
    }
}
