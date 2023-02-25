//ItemStore.cs

using System;

namespace FischerP3
{
    //has a ItemFactory
    public class ItemStore
    {
        ItemFactory factory;

        //gets a factory passed to it in the constructor
        public ItemStore(ItemFactory factory)
        {
            this.factory = factory;
        }

        //uses the factory to create the item type by passing on the type of the user's 
        //order and returning it
        public IItem GetItem(String usersItem)
        {
            IItem item;
            item = factory.createItem(usersItem);
            return item;
        }
    }
}
