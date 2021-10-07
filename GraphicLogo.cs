//Programmer: Celeste Fischer
//GraphicLogo.cs

using System;

namespace FischerP3
{
    public class GraphicLogo : ItemDecorator
    {
        public GraphicLogo(IItem wrappedItem) : base(wrappedItem)
        {
            //super(wrappedItem)
        }

        public override string GetDesc(string usersText)
        {
            return base.GetDesc(usersText) + " with a graphic logo";
        }
        public override double GetCost(int numItems)
        {
            //base.GetCost() is the itemType * numItems from ItemDecorator from the concrete
            //item class through the interface IItem
            //add 25 cents per item for a graphic logo
            return base.GetCost(numItems) + (0.25 * numItems);
        }
    }
}

