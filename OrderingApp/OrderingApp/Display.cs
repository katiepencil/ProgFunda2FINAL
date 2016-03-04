using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderingApp
{
    class Display
    {
        static public string createDisplay(string ingredient, int i)
        {
          var orderingApp = new Ordering();
          orderingApp.lblArrayDisplay.Text = "testing";
              //= "Cheese: \n" + orderingApp.allChosenCheeses + "\nTopping: \n" + allChosenToppings + "\nSauce: \n" + allChosenSauces;
 
          string displayOrder = orderingApp.optionsArray[i] = ingredient + "\n";
          return displayOrder;
            
        }
    }
}
