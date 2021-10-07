using System;
//Programmer: Celeste Fischer
//ItemFactory.cs

//the logo item factory that encapsulates item creation 
//only need to make future modifications here (and in the UI)

namespace FischerP3
{  
	public class ItemFactory 
	{
		public IItem createItem(string newItem)
        {
            //get newItem from ItemStore, which gets it from the form's text box
            switch (newItem)
            {
                case "USB":
                    return new USB();
                case "Pen":
                    return new Pen();
                case "Mug":
                    return new Mug();
                default:
                    return null;
            }
        }
	}
}

