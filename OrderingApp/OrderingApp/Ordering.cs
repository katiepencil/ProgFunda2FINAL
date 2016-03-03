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
        string takeOut;
        bool standardBurger;

        //these strings are for the segregated display on the left panel.
        //I added this at the last minute so I could divide
        //the display by the ingredient type, regardless
        //order used when placing the order
        /* this is what I would use if I was going to show pictures, because 
         * you have to be able to show sauces together, etc
         * regardless of what order the customer decided on them in.
         * I haven't gone thru and removed the old 'lblStack' code.
         * so it's jjust on the closing page (as a second display of
         * 'what you ordered'. I realized I couldn't remove it from the display before
         * removing all the code tied to it!*/

        string allChosenToppings;
        string allChosenSauces;
        string allChosenCheeses;

        string orderStep; //this keeps track of what panel you're on

        public string[] optionsArray = new string[4];
        
        string[] toppings = new string[]{};
        string[] sauce = new string[]{};

        public Ordering()
        {
            InitializeComponent();
        }

        /* Load  events  
         these are all the pages and their status when the program
         first opens */

        private void Ordering_Load(object sender, EventArgs e)
        {
            pnlStart.Visible = true;
            pnlStack.Visible = true;
            pnlNav.Visible = false;
            pnlPrevNext.Visible = false;
            
            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;
            
            pnlBuild.Visible = false;
            pnlBun.Visible = false;
            pnlCheese.Visible = false;
            pnlToppings.Visible = false;
            pnlSauce.Visible = false;

            pnlSpecialty.Visible = false;         
            pnlSummary.Visible = false;
            pnlComplete.Visible = false;

            btnPrev.Enabled = true;
            btnNext.Enabled = true;

            lblStack.Text = "  ";
        }

        /* Button click events  
         * this is how we 'flip' the visibility
         * of panels. Shut one off, 
         * and at the same time turn the other on
         * I also used this to control when that DARN prevNext panel 
         and buttons would appear. Lots of trouble with that.
         I finally ended up just doing simple controls-- 
         now you have to click on at least one ingredient on a page before the 
         prevNext will work. Couldn't get the pageVisible controls to work, 
         * not sure why. 
         * And I dont' have the graying-out
         feature. Tho that would look nicer. */

        private void btnStart_Click(object sender, EventArgs e)    
        {   pnlStart.Visible = false;
            pnlLocation.Visible = true;
            pnlNav.Visible = false;
            pnlPrevNext.Visible = false;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {   takeOut = "to eat inside";
            pnlLocation.Visible = false;
            pnlOrderType.Visible = true;
            pnlNav.Visible = false;
            pnlPrevNext.Visible = false;
        }

        private void btnOut_Click(object sender, EventArgs e)
        {   takeOut = "to eat outside";
            pnlLocation.Visible = false;
            pnlOrderType.Visible = true;
            pnlNav.Visible = false;
            pnlPrevNext.Visible = false;
        }

        /* Panel Visible changed events 
         * As I mentioned, these are not working for me, 
         * and I couldn't figure out why.
         * So I commented them out for now and just did very basic controls. */

        //public void pnlLocation_VisibleChanged(object sender, EventArgs e)
        //{
        //    if (pnlLocation.Visible)
        //    { pnlNav.Visible = false;
        //        pnlPrevNext.Visible = false;
        //        //btnPrev.Enabled = true;
        //        //btnNext.Enabled = true;
        //    }
        //}

        //public void pnlOrderType_VisibleChanged(object sender, EventArgs e)
        //{
        //    if (pnlOrderType.Visible)
        //    {orderStep = "order Type";
        //        pnlNav.Visible = true;
        //        pnlPrevNext.Visible = false;
        //        //btnPrev.Enabled = true;
        //        //btnNext.Enabled = true;
        //    }
        //}

        //public void pnlBuild_VisibleChanged(object sender, EventArgs e)
        //{if (pnlBuild.Visible)
        //    {
        //    orderStep = "build";
        //    pnlNav.Visible = false;
        //    pnlPrevNext.Visible = true;
        //    //btnPrev.Enabled = true;
        //    //btnNext.Enabled = true;
        //    }
        //}

        //private void pnlBun_VisibleChanged(object sender, EventArgs e)
        //{if (pnlBun.Visible)
        //    {
        //    orderStep = "bun";
        //    pnlNav.Visible = true;
        //    pnlPrevNext.Visible = true;
        //    //btnPrev.Enabled = false;
        //    //btnNext.Enabled = true;
        //    }   
        //}

        //private void pnlCheese_VisibleChanged(object sender, EventArgs e)
        //{ if (pnlCheese.Visible)
        //    {
        //    orderStep = "cheese";
        //    pnlNav.Visible = true;
        //    pnlPrevNext.Visible = true;
        //    //btnPrev.Enabled = true;
        //    //btnNext.Enabled = true;
        //    }
        //}
        //private void pnlToppings_VisibleChanged(object sender, EventArgs e)
        //{ if (pnlToppings.Visible)
        //    {
        //    orderStep = "toppings";
        //    pnlNav.Visible = true;
        //    pnlPrevNext.Visible = true;
        //    //btnPrev.Enabled = true;
        //    //btnNext.Enabled = true;
        //    }
        //}
        //private void pnlSauce_VisibleChanged(object sender, EventArgs e)
        //{ if (pnlSauce.Visible)
        //    {
        //    orderStep = "sauce";
        //      pnlNav.Visible = true;
        //      pnlPrevNext.Visible = true;
        //      //btnPrev.Enabled = true;
        //      //btnNext.Enabled = true;
        //    }
        //}
       
        /* DIAGNOSTIC: Switch for prev/next button  
         * These are so I can monitor what 'orderStep' is at 
         * any moment. They are the un-colored buttons 
         * next to the colored Prev and Next buttons.
         I'm troubleshooting to see why I was not reading the right orderStep labels.
         This was VERY helpful. I was able to figure out that my switch was working,
         * at least! So then I 'forced' it to take the orderStep
         * labels (by linking them to button clicks when choosing ingredients)
         * and then the DARN prevNext started working.
         * 
         * I left the buttons there, if you want to 
         check them out! Just some extra fun.*/

        private void btnBACK_Click(object sender, EventArgs e)
        {
            btnBACK.Text = orderStep;
            btnForward.Text = "  --  ";
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            btnBACK.Text = " ... ";
            btnForward.Text = orderStep;
        }

        /* SWITCH: almost perfect! The prevNext buttons get screwy
         * if you keep going backward from the ingredient pages.
         * But at the other end, after the ingredients, I made
         * them just circle back into more ingredients.
         * Buy more! Eat more! Then when you're done, hit
         * the 'done' button.
         * I would finish this by making the 'build' case options 
         * different somehow. Have to think it thru.
         */
       
        private void btnPrev_Click(object sender, EventArgs e)
        {
          switch (orderStep)
            {
                case "build":   
                   pnlBuild.Visible = false;
                   pnlOrderType.Visible = true;
                   break;
                case "bun":
                   pnlBun.Visible = false;
                   pnlBuild.Visible = true;
                   break;
                case "cheese":
                   pnlCheese.Visible = false;
                   pnlBun.Visible = false;
                   break;
                case "toppings":
                   pnlToppings.Visible = false;
                   pnlCheese.Visible = true;
                    break;
                case "sauce":
                   pnlSauce.Visible = false;
                   pnlToppings.Visible = true;
                   break;
                default:
                    break;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            switch (orderStep)
            {
                case "build":
                    pnlBuild.Visible = false;
                    pnlBun.Visible = true;
                    break;
                case "bun":
                    pnlBun.Visible = false;
                    pnlCheese.Visible = true;
                    break;
                case "cheese":
                    pnlCheese.Visible = false;
                    pnlToppings.Visible = true;
                    break;
                case "toppings":
                    pnlToppings.Visible = false;
                    pnlSauce.Visible = true;
                    break;
                case "sauce":
                    pnlSauce.Visible = false;
                    pnlCheese.Visible = true;
                    break;
                default:
                    break;
            }
        }


        /* Controls for the top nav buttons   
         There may be a prettier way to do this, but it worked
         simply enough.
         I also used this to force the orderStep,
         so if you don't choose an ingredient but jump to another
         category, it sets the right orderStep.*/

        private void btnBun_Click(object sender, EventArgs e)
        {
            pnlNav.Visible = true;
            pnlPrevNext.Visible = true;
            pnlBun.Visible = true;
            pnlCheese.Visible = false;
            pnlToppings.Visible = false;
            pnlSauce.Visible = false;
            orderStep = "bun";
        }

        private void btnCheese_Click(object sender, EventArgs e)
        {
            pnlNav.Visible = true;
            pnlPrevNext.Visible = true;
            pnlBun.Visible = false;
            pnlCheese.Visible = true;
            pnlToppings.Visible = false;
            pnlSauce.Visible = false;
            orderStep = "cheese";
        }

        private void btnToppings_Click(object sender, EventArgs e)
        {
            pnlNav.Visible = true;
            pnlPrevNext.Visible = true;
            pnlBun.Visible = false;
            pnlCheese.Visible = false;
            pnlToppings.Visible = true;
            pnlSauce.Visible = false;
            orderStep = "toppings";
        }

        private void btnSauce_Click(object sender, EventArgs e)
        {
            pnlNav.Visible = true;
            pnlPrevNext.Visible = true;
            pnlBun.Visible = false;
            pnlCheese.Visible = false;
            pnlToppings.Visible = false;
            pnlSauce.Visible = true;
            orderStep = "sauce";
        }

      
        /* Controls for starting building the hamburger.
         * I decided not to show the prevNext controls until you 
         have committed to building a custom burger. 
         otherwise, you have to deal with that big
         branch point.
         Note that I also am forcing the orderStep labels
         * with all of these clicks.
         Couldn't figure out anything simpler.*/

        private void btnBuild_Click(object sender, EventArgs e)
        {
            pnlOrderType.Visible = false;
            pnlBuild.Visible = true;
            standardBurger = true;
            pnlPrevNext.Visible = true;
            orderStep = "build";
        }
            
        private void btnSpecialty_Click(object sender, EventArgs e)
        { pnlOrderType.Visible = false;
            pnlSpecialty.Visible = true;
            standardBurger = false;
            pnlPrevNext.Visible = true;
            orderStep = "specialty";
        }

        private void btnBuildMyBurger_Click(object sender, EventArgs e)
        { pnlBuild.Visible = false;
            pnlBun.Visible = true;
            pnlNav.Visible = true;
            pnlPrevNext.Visible = true;
            orderStep = "bun";
        }

     
        //choose your bun!!
        
        /* Now we start choosing some ingredients!
         * I set it up so you can only choose one bun
         * (it gets its own label, and only one option
         * allowed there). Every other ingredient can be piled up.
         */

        private void btnWheatBun_Click(object sender, EventArgs e)
        {
            string bunType = Bun.createBun("Wheat Bun");
            lblStackBun.Text = bunType;
            orderStep = "bun";
        }
        
        private void btnWhiteBun_Click(object sender, EventArgs e)
        {
            string bunType = Bun.createBun("White Bun");
            lblStackBun.Text = bunType;
            orderStep = "bun";
        }

        private void btnPotatoBun_Click(object sender, EventArgs e)
        {   
            string bunType = Bun.createBun("Potato Bun");
            lblStackBun.Text = bunType;
            orderStep = "bun";
        }

        
        //choose your cheese!!//
        /* Choose as many cheese as you want!
         * I did not work on making it erase other 
         * cheeses if you chose 'no cheese'. So for now you
         * can choose 'no cheese' plus other cheeses. I would
         * have to think this thru.
         * This is where I start using the 'allChosenXXX' strings
         * as a repository for all the ingredients chosen in that category.
         * They can be printed out (on left panel) as segregated
         * items.
         * I'm still wrapping my head around the creatCheese and 
         * createDisplay methods, so some of the buttons use them
         * and some done't.
         */

        private void btnCheese1_Click(object sender, EventArgs e)
        {
           string cheeseType = Cheese.createCheese("American Cheese");
           string displayOrder = Display.createDisplay(cheeseType, 1);
           lblStack.Text += displayOrder;
            optionsArray[1] = cheeseType + "\n";
           allChosenCheeses += optionsArray[1];
           orderStep = "cheese";
        }

        private void btnCheese2_Click(object sender, EventArgs e)
        {
            string cheeseType = Cheese.createCheese("Cheddar Cheese");
            optionsArray[1] = cheeseType + "\n";
            lblStack.Text += optionsArray[1];
            allChosenCheeses += optionsArray[1];
            orderStep = "cheese";
        }

        private void btnCheese3_Click(object sender, EventArgs e)
        {
            string cheeseType = Cheese.createCheese("Swiss Cheese");
            optionsArray[1] = cheeseType + "\n";
            lblStack.Text += optionsArray[1];
            allChosenCheeses += optionsArray[1];
            orderStep = "cheese";
        }

        private void btnNoCheese_Click(object sender, EventArgs e)
        {
            string cheeseType = Cheese.createCheese("No Cheese");
            optionsArray[1] = cheeseType + "\n";
            lblStack.Text += optionsArray[1];
            allChosenCheeses += optionsArray[1];
            orderStep = "cheese";
        }

       
        //choose your toppings!!
        //As discussed, I added code to use the arrays to segregate the 
        //ingredients by array position. 
        //I'm sure there's a way to put that into the display
        //method but this is a start.

        private void btnPickles_Click(object sender, EventArgs e)
        {
            string toppingsType = Toppings.createTopping("Pickles");
            string displayOrder = Display.createDisplay(toppingsType, 2);
            lblStack.Text += displayOrder;
            optionsArray[2] = toppingsType + "\n";
            allChosenToppings += optionsArray[2]; 
            orderStep = "toppings";
        }

        private void btnTomato_Click(object sender, EventArgs e)
        {
            string toppingsType = Toppings.createTopping("Tomatoes");
            string displayOrder = Display.createDisplay(toppingsType, 2);
            lblStack.Text += displayOrder;
            optionsArray[2] = toppingsType + "\n";
            allChosenToppings += optionsArray[2];
            orderStep = "toppings";
        }

        private void btnLettuce_Click(object sender, EventArgs e)
        {
            string toppingType = Toppings.createTopping("Lettuce");
            optionsArray[2] = toppingType + "\n";
            allChosenToppings += optionsArray[2];
            //this still is using the old way of making the display.
            lblStack.Text += optionsArray[2];
            orderStep = "toppings";
        }

        private void btnOnion_Click(object sender, EventArgs e)
        {
            string toppingType = Toppings.createTopping("Onion");
            optionsArray[2] = toppingType + "\n";
            lblStack.Text += optionsArray[2];
            allChosenToppings += optionsArray[2];
            orderStep = "toppings";
        }

       
        //choose your sauces!!//

        private void btnKetsup_Click(object sender, EventArgs e)
        {
            string sauceType = Sauces.createSauces("Ketchup");
            optionsArray[3] = sauceType + "\n";
            lblStack.Text += optionsArray[3];
            allChosenSauces += optionsArray[3];
            orderStep = "sauce";
        }

        private void btnMayo_Click(object sender, EventArgs e)
        {
            string sauceType = Sauces.createSauces("Mayo");
            optionsArray[3] = sauceType + "\n";
            lblStack.Text += optionsArray[3];
            allChosenSauces += optionsArray[3];
            orderStep = "sauce";
        }

        private void btnMustard_Click(object sender, EventArgs e)
        {
            string sauceType = Sauces.createSauces("Mustard");
            optionsArray[3] = sauceType + "\n";
            lblStack.Text += optionsArray[3];
            allChosenSauces += optionsArray[3];
            orderStep = "sauce";
        }

        private void btnBBQ_Click(object sender, EventArgs e)
        {
            string sauceType = Sauces.createSauces("BBQ");
            optionsArray[3] = sauceType + "\n";
            lblStack.Text += optionsArray[3];
            allChosenSauces += optionsArray[3];
            orderStep = "sauce";
        }

      
        //set the 'btnNext' button to enabled-true once it has been clicked!//

        private void btnAllDone_Click(object sender, EventArgs e)
        {
            pnlStart.Visible = false;
            pnlStack.Visible = false;
            pnlNav.Visible = false;
            pnlPrevNext.Visible = false;

            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;

            pnlBuild.Visible = false;
            pnlBun.Visible = false;
            pnlCheese.Visible = false;
            pnlToppings.Visible = false;
            pnlSauce.Visible = false;

            pnlSpecialty.Visible = false;
            pnlComplete.Visible = false;
            pnlSummary.Visible = true;

            if (standardBurger)
            {lblFinalOrderReport.Text = "You ordered a delicious hamburger " + takeOut +
                    "\non a " + lblStackBun.Text + " \nwith " + lblStack.Text;
            }
            else
            { lblFinalOrderReport.Text = "You ordered a delicious " + lblStack.Text + takeOut; }
        }

        private void btnStartOver_Click(object sender, EventArgs e)
        {
            pnlSummary.Visible = false;
            pnlLocation.Visible = true;
            pnlOrderType.Visible = false;
            pnlStack.Visible = true;
            pnlNav.Visible = true;
            pnlPrevNext.Visible = true;
            lblStack.Text = "  ";
            lblStackBun.Text = "  ";
        }

        private void btnYesDone_Click(object sender, EventArgs e)
        {
            pnlSummary.Visible = false;
            pnlOrderType.Visible = false;
            pnlStack.Visible = false;
            pnlNav.Visible = false;
            pnlPrevNext.Visible = false;
            pnlComplete.Visible = true;
        }

        private void btnBigMac_Click(object sender, EventArgs e)
        {
            lblStack.Text = "Big Mac\n"; 
        }

        private void btnVeggieBurger_Click(object sender, EventArgs e)
        {
            lblStack.Text = "Veggie Burger\n"; 
        }

        private void clickHandler(object sender)
        {
            lblStack.Text = sender.ToString();
        }

        private void btnArrayDisplay_Click(object sender, EventArgs e)
        {
            lblArrayDisplay.Text = "Cheese: \n" + allChosenCheeses + "\nTopping: \n" + allChosenToppings + "\nSauce: \n" + allChosenSauces;
        }

     
    }
    }