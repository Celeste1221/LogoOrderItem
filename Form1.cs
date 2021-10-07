//Programmer: Celeste Fischer
//Form1.cs

using System;
using System.Windows.Forms;

namespace FischerP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //initialize the form
            InitializeComponent();
        }
     
        //button click event is analogous to main in a console program
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                //instantiate the class object 
                ItemStore store = new ItemStore(new ItemFactory());

                //takes in choice's store, determines which item with ItemFactory
                //and returns it to usersItem
                //usersItem can now be decorated 
                IItem usersItem = store.GetItem(tbUserItem.Text); //TODO ignore case
                
                int numItems = int.Parse(tbNumItems.Text);
                int numColors = int.Parse(tbNumColors.Text);
                string textToPrint = tbTextToPrint.Text;
                bool logo = ckbxLogo.Checked;
                
                IItem usersOrder;
               
                if (logo && numColors>0) 
                {   
                    //wrap with all decorators
                    usersOrder = new ColorGraphicLogo(new GraphicLogo(new TextLogo(usersItem)));
                }
                else if (logo && numColors == 0)
                {   
                    //wrap with TextLogo and GraphicLogo only
                    usersOrder = new GraphicLogo(new TextLogo(usersItem));
                }
                else
                {
                    //wrap with TextLogo only
                    usersOrder = new TextLogo(usersItem);
                }
                tbOrderSummary.Text = "Order summary: " + numItems + 
                    usersOrder.GetDesc(textToPrint) + " Total: $" + 
                    usersOrder.GetCost(numItems);
            }
            catch (Exception exc) //if the input is incorrect
            {
                tbOrderSummary.Text = exc.Message;
            }
        }

        //reset all the fields in the form
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbUserItem.Text = "";
            tbNumItems.Text = "";
            ckbxLogo.Checked = false;
            tbOrderSummary.Text = "";
            tbTextToPrint.Text = "";
            tbNumColors.Text = "0";
        }
     }
}

  