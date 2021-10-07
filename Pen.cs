//Programmer: Celeste Fischer
//Pen.cs

namespace FischerP3
{
    public class Pen : IItem
    {
        public string GetDesc(string usersText)
        {
            return " pen(s)";
        }
        public double GetCost(int numItems)
        {
            return 12.99 * numItems;
        }
    }
}
