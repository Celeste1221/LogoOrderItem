//Programmer: Celeste Fischer
//ItemDecorator.cs

namespace FischerP3
{
	//has-a relationship with IItem
	public abstract class ItemDecorator : IItem
	{
		public IItem wrappedItem;
		public int numColors;

		//takes an IItem object in the constructor
		public ItemDecorator(IItem wrappedItem)
		{
			this.wrappedItem = wrappedItem;
		}

		public virtual string GetDesc(string usersText)
        {
			return wrappedItem.GetDesc(usersText);
        }
	
        public virtual double GetCost(int numItems)
        {
            return + wrappedItem.GetCost(numItems);
        }
    }
}

