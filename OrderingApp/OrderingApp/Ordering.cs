using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrderingApp
{
    public partial class Ordering : Form
    {
        //declarations
        bool takeOut = true;
        string bunType = "";
        int pattyNum;
        string orderStep; //this keeps track of what panel you're on

        Array[] cheeseType;
        Array[] toppings;
        Array[] sauce;
        Array[] optionsArray;

        public Ordering()
        {
            InitializeComponent();
        }

        private void Ordering_Load(object sender, EventArgs e)
        {
            pnlStart.Visible = true;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;
            pnlPrevNext.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lbl1.Text = "Future menu here!";
        }

        private void btnStart_Click(object sender, EventArgs e)
            //this is "btnStart_Click () method
            //this is how we 'flip' the visibility of the first two panels
            //shut one off, turn the other on!
        {
            pnlStart.Visible = false;
            pnlLocation.Visible = true;
            orderStep = "location";
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            takeOut = false;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = true;
            orderStep = "orderType";
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            takeOut = true;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = true;
            orderStep = "orderType";
        }

 
      // here is code....  private void pnlLocation_VisibleChanged

        private void btnPrev_Click(object sender, EventArgs e)
        {
            pnlLocation.Visible = true;
            pnlOrderType.Visible = false;
            orderStep = "location";

            switch (orderStep)
            {
                case "start":
                case "location":    
                    pnlPrevNext.Visible = false;
                    break;
                case "orderType":
                    pnlPrevNext.Visible = true;
                    break;
                default:
                    break;
            }
        }
    }
}
