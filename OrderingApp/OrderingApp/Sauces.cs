using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderingApp
{
    class Sauces
    {
        static public string createSauces(string _sauceType)
        {
            var orderingApp = new Ordering();
            orderingApp.btnPrev.Enabled = true;
            orderingApp.btnNext.Enabled = true;
            var sauceType = _sauceType;
            //orderingApp.optionsArray[1] = cheeseType;
            //orderingApp.lblStack.Text += orderingApp.optionsArray[1];

            return sauceType;
        }
    }
}
