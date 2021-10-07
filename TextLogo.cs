//Programmer: Celeste Fischer
//TextLogo.cs

namespace FischerP3
{
    public class TextLogo : ItemDecorator
    {
        public TextLogo(IItem wrappedItem) : base(wrappedItem)
        {
            //super(wrappedItem)
        }

        public override string GetDesc(string usersText)
        {
            return base.GetDesc(usersText) + " with the following text: \"" + usersText + "\";";
        }
        public override double GetCost(int numItems) 
        {
            //base.GetCost() is the itemType * numItems from ItemDecorator from the concrete
            //item class through the interface IItem
            //add ten cents per item for the textlogo
            return base.GetCost(numItems);
        }
    }
}


