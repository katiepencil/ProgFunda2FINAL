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
          string displayOrder = orderingApp.optionsArray[i] = ingredient + "\n(Using method!)\n";
          return displayOrder;
            
        }
    }
}
