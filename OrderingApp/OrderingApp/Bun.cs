using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OrderingApp;

namespace OrderingApp
{
    class Bun
    {
        static public string createBun(string _bunType)
        {
            var orderingApp = new Ordering();
            orderingApp.btnNext.Enabled = true;
            //orderingApp.lblStackBun.Text = _bunType;
            orderingApp.btnPrev.Enabled = true;
            var bunType = _bunType;
            return bunType;
        }
    }
}
