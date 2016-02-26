using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderingApp
{
    class Cheese
    {
        static public string createCheese(string _cheeseType)
        {
            var orderingApp = new Ordering();
            orderingApp.btnNext.Enabled = true;
            orderingApp.btnPrev.Enabled = true;
            var cheeseType = _cheeseType;
            //orderingApp.optionsArray[1] = cheeseType;
            //orderingApp.lblStack.Text += orderingApp.optionsArray[1];
            
            return cheeseType;
        }
    }
}
