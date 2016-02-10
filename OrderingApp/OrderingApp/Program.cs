using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OrderingApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// we DON'T make ANY changes to this page!! 
        /// it automatically builds based on the forms we build 
        /// (ie, the other .cs files such as Ordering.cs)
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Ordering());
        }
    }
}
