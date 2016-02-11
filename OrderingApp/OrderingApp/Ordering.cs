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
        string chosenBun;

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
                pnlBurgerNav.Visible = false;
                pnlPrevNext.Visible = false;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;
            pnlOrderStart.Visible = false;
            pnlBunChoice.Visible = false;
            pnlFinalOrder.Visible = false;
            
        }

        private void btnStart_Click(object sender, EventArgs e)
            //this is "btnStart_Click () method
            //this is how we 'flip' the visibility of the first two panels
            //shut one off, turn the other on!
        {
            pnlStart.Visible = false;
                pnlBurgerNav.Visible = false;
                pnlPrevNext.Visible = false;
            pnlLocation.Visible = true;
            pnlOrderType.Visible = false;
            pnlOrderStart.Visible = false;
            pnlBunChoice.Visible = false;
            pnlFinalOrder.Visible = false;
            //orderStep = "location";
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            //takeOut = false;
            pnlStart.Visible = false;
                pnlBurgerNav.Visible = false;
                pnlPrevNext.Visible = false;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = true;
            pnlOrderStart.Visible = false;
            pnlBunChoice.Visible = false;
            pnlFinalOrder.Visible = false;
           // orderStep = "orderType";
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            //takeOut = true;
            pnlStart.Visible = false;
                pnlBurgerNav.Visible = false;
                pnlPrevNext.Visible = false;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = true;
            pnlOrderStart.Visible = false;
            pnlBunChoice.Visible = false;
            pnlFinalOrder.Visible = false;
            //orderStep = "orderType";
        }

 
      // here is code....  private void pnlLocation_VisibleChanged

        //private void btnPrev_Click(object sender, EventArgs e)
        //{
        //    pnlStart.Visible = false;
        //        pnlBurgerNav.Visible = false;
        //        pnlPrevNext.Visible = false;
        //    pnlLocation.Visible = false;
        //    pnlOrderType.Visible = false;
        //    pnlBunChoice.Visible = true;

            //orderStep = "location";

            //switch (orderStep)
            //{
            //    case "start":
            //    case "location":    
            //        pnlPrevNext.Visible = false;
            //        break;
            //    case "orderType":
            //        pnlPrevNext.Visible = true;
            //        break;
            //    default:
            //        break;
            //}
        //}

        private void btnBun_Click(object sender, EventArgs e)
        {
           // orderStep = "bunChoice";
            pnlStart.Visible = false;
                pnlBurgerNav.Visible = false;
                pnlPrevNext.Visible = false;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;
            pnlOrderStart.Visible = false;
            pnlBunChoice.Visible = true;
            pnlFinalOrder.Visible = false;
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            //orderStep = "bunChoice";
            pnlStart.Visible = false;
                pnlBurgerNav.Visible = false;
                pnlPrevNext.Visible = false;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;
            pnlOrderStart.Visible = true;
            pnlBunChoice.Visible = false;
            pnlFinalOrder.Visible = false;
        }

        private void btnChooseBun_Click(object sender, EventArgs e)
        {
            pnlStart.Visible = false;
                pnlBurgerNav.Visible = false;
                pnlPrevNext.Visible = false;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;
            pnlOrderStart.Visible = false;
            pnlBunChoice.Visible = true;
            pnlFinalOrder.Visible = false;
        }

        private void btnBunWheat_Click(object sender, EventArgs e)
        {
            pnlStart.Visible = false;
                pnlBurgerNav.Visible = false;
                pnlPrevNext.Visible = false;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;
            pnlOrderStart.Visible = true;
            pnlBunChoice.Visible = false;
            pnlFinalOrder.Visible = false;

            chosenBun = "wheat";
        }

        private void btnAllDone_Click(object sender, EventArgs e)
        {
            pnlStart.Visible = false;
                pnlBurgerNav.Visible = false;
                pnlPrevNext.Visible = false;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;
            pnlOrderStart.Visible = false;
            pnlBunChoice.Visible = false;
            pnlFinalOrder.Visible = true;

            lblFinalOrderReport.Text = chosenBun;
        }

        

        }
    }