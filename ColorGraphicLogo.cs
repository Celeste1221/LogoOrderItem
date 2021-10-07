//Programmer: Celeste Fischer
//ColorGraphicLogo.cs

namespace FischerP3
{
    public class ColorGraphicLogo : ItemDecorator
    {
        public ColorGraphicLogo(IItem wrappedItem) : base(wrappedItem)
        {
            //super(wrappedItem)
        }
        public override string GetDesc(string usersText)
        {
            return base.GetDesc(usersText) + " with color ";
        }
        public override double GetCost(int numItems)
        {
            //base.GetCost() is the itemType * numItems from ItemDecorator from the concrete
            //item class through the interface IItem
            //add 25 cents per item for a graphic logo plus 5 cents per color per item for colors
            return base.GetCost(numItems) + (0.25 * numItems) + (0.5 * numColors * numItems); 
        }
    }
}

