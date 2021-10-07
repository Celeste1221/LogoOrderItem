//Programmer: Celeste Fischer
//USB.cs

namespace FischerP3
{
    public class USB : IItem
    {
        public string GetDesc(string usersText)
        {
            return " USB(s)";
        }
        public double GetCost(int numItems)
        {
            return 22.99 * numItems;
        }
    }
}

