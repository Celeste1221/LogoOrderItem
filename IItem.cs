//Programmer: Celeste Fischer
//IItem.cs

namespace FischerP3
{
    //this is the interface that the concrete items will inherit from
    public interface IItem
    {
        string GetDesc(string usersText);
        double GetCost(int numItems);
    }
}