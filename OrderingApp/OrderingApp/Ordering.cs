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

        public string allChosenToppings = " ";
        public string allChosenSauces = " ";
        public string allChosenCheeses = " ";

        string orderStep; //this keeps track of what panel you're on

        public string[] optionsArray = new string[4];

        string[] toppings = new string[] { };
        string[] sauce = new string[] { };

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
            lblStackBun.Text = "  ";
        }

        /* Button click events  
         * this is how we 'flip' the visibility
         * of panels. Shut one off, 
         * and at the same time turn the other on
          */

        private void btnStart_Click(object sender, EventArgs e)
        {
            pnlStart.Visible = false;
            pnlLocation.Visible = true;
            pnlNav.Visible = false;
            pnlPrevNext.Visible = true;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            takeOut = "to eat inside";
            pnlLocation.Visible = false;
            pnlOrderType.Visible = true;
            pnlNav.Visible = false;
            pnlPrevNext.Visible = true;
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            takeOut = "to eat outside";
            pnlLocation.Visible = false;
            pnlOrderType.Visible = true;
            pnlNav.Visible = false;
            pnlPrevNext.Visible = true;
        }

        /* Panel Visible changed events 
          */

        public void pnlLocation_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlLocation.Visible)
            {
                pnlNav.Visible = false;
                pnlPrevNext.Visible = true;
                btnPrev.Enabled = false;
                btnNext.Enabled = true;
                orderStep = "location";
            }
        }

        public void pnlOrderType_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlOrderType.Visible)
            {
                orderStep = "order type";
                pnlNav.Visible = false;
                pnlPrevNext.Visible = true;
                btnPrev.Enabled = true;
                btnNext.Enabled = true;
            }
        }

        public void pnlBuild_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlBuild.Visible)
            {
                orderStep = "build";
                pnlNav.Visible = false;
                pnlPrevNext.Visible = true;
                btnPrev.Enabled = true;
                btnNext.Enabled = true;
            }
        }

        private void pnlBun_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlBun.Visible)
            {
                orderStep = "bun";
                pnlNav.Visible = true;
                pnlPrevNext.Visible = true;
                btnPrev.Enabled = true;
                btnNext.Enabled = true;
            }
        }

        private void pnlCheese_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlCheese.Visible)
            {
                orderStep = "cheese";
                pnlNav.Visible = true;
                pnlPrevNext.Visible = true;
                btnPrev.Enabled = true;
                btnNext.Enabled = true;
            }
        }
        private void pnlToppings_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlToppings.Visible)
            {
                orderStep = "toppings";
                pnlNav.Visible = true;
                pnlPrevNext.Visible = true;
                btnPrev.Enabled = true;
                btnNext.Enabled = true;
            }
        }
        private void pnlSauce_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlSauce.Visible)
            {
                orderStep = "sauce";
                pnlNav.Visible = true;
                pnlPrevNext.Visible = true;
                btnPrev.Enabled = true;
                btnNext.Enabled = false;
            }
        }


        /* SWITCH code is here.
         */

        private void btnPrev_Click(object sender, EventArgs e)
        {
            switch (orderStep)
            {
                case "order type":
                    pnlOrderType.Visible = false;
                    pnlLocation.Visible = true;
                    break;
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
                    pnlBun.Visible = true;
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
                case "location":
                    pnlLocation.Visible = false;
                    pnlOrderType.Visible = true;
                    break;
                case "order type":
                    pnlOrderType.Visible = false;
                    pnlBuild.Visible = true;
                    break;
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
         simply enough.*/

        private void btnBun_Click(object sender, EventArgs e)
        {
            pnlNav.Visible = true;
            pnlPrevNext.Visible = true;
            pnlBun.Visible = true;
            pnlCheese.Visible = false;
            pnlToppings.Visible = false;
            pnlSauce.Visible = false;
        }

        private void btnCheese_Click(object sender, EventArgs e)
        {
            pnlNav.Visible = true;
            pnlPrevNext.Visible = true;
            pnlBun.Visible = false;
            pnlCheese.Visible = true;
            pnlToppings.Visible = false;
            pnlSauce.Visible = false;
        }

        private void btnToppings_Click(object sender, EventArgs e)
        {
            pnlNav.Visible = true;
            pnlPrevNext.Visible = true;
            pnlBun.Visible = false;
            pnlCheese.Visible = false;
            pnlToppings.Visible = true;
            pnlSauce.Visible = false;
        }

        private void btnSauce_Click(object sender, EventArgs e)
        {
            pnlNav.Visible = true;
            pnlPrevNext.Visible = true;
            pnlBun.Visible = false;
            pnlCheese.Visible = false;
            pnlToppings.Visible = false;
            pnlSauce.Visible = true;
        }


        /* Controls for starting building the hamburger.
         */

        private void btnBuild_Click(object sender, EventArgs e)
        {
            pnlOrderType.Visible = false;
            pnlBuild.Visible = true;
            pnlLocation.Visible = false;
            standardBurger = true;
            pnlPrevNext.Visible = true;
        }

        private void btnSpecialty_Click(object sender, EventArgs e)
        {
            pnlOrderType.Visible = false;
            pnlSpecialty.Visible = true;
            standardBurger = false;
            pnlPrevNext.Visible = true;
        }

        private void btnBuildMyBurger_Click(object sender, EventArgs e)
        {
            pnlBuild.Visible = false;
            pnlBun.Visible = true;
            pnlNav.Visible = true;
            pnlPrevNext.Visible = true;
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
        }

        private void btnWhiteBun_Click(object sender, EventArgs e)
        {
            string bunType = Bun.createBun("White Bun");
            lblStackBun.Text = bunType;
        }

        private void btnPotatoBun_Click(object sender, EventArgs e)
        {
            string bunType = Bun.createBun("Potato Bun");
            lblStackBun.Text = bunType;
        }


        //choose your cheese!!//
        /* Choose as many cheese as you want!
         * 
         * I'm still wrapping my head around the creatCheese and 
         * createDisplay methods, so some of the buttons use them
         * and some done't.
         */

        private void btnCheese1_Click(object sender, EventArgs e)
        {
            string cheeseType = Cheese.createCheese("American Cheese");
            string displayOrder = Display.createDisplay(cheeseType, 1);
            lblStack.Text += displayOrder + "\n";
            optionsArray[1] = cheeseType ;
            allChosenCheeses += optionsArray[1] + "  ";
        }

        private void btnCheese2_Click(object sender, EventArgs e)
        {
            string cheeseType = Cheese.createCheese("Cheddar Cheese");
            optionsArray[1] = cheeseType ;
            lblStack.Text += optionsArray[1] + "\n";
            allChosenCheeses += optionsArray[1] + "  ";
        }

        private void btnCheese3_Click(object sender, EventArgs e)
        {
            string cheeseType = Cheese.createCheese("Swiss Cheese");
            optionsArray[1] = cheeseType ;
            lblStack.Text += optionsArray[1] + "\n";
            allChosenCheeses += optionsArray[1] + "  ";
        }

        private void btnNoCheese_Click(object sender, EventArgs e)
        {
            string cheeseType = Cheese.createCheese("No Cheese");
            optionsArray[1] = cheeseType ;
            lblStack.Text += optionsArray[1] + "\n";
            allChosenCheeses += optionsArray[1] + "  ";
        }

 
        //choose your toppings!!
        //

        private void btnPickles_Click(object sender, EventArgs e)
        {
            string toppingsType = Toppings.createTopping("Pickles");
            string displayOrder = Display.createDisplay(toppingsType, 2);
            lblStack.Text += displayOrder+ "\n";
            optionsArray[2] = toppingsType ;
            allChosenToppings += optionsArray[2] + "  ";
        }

        private void btnTomato_Click(object sender, EventArgs e)
        {
            string toppingsType = Toppings.createTopping("Tomatoes");
            string displayOrder = Display.createDisplay(toppingsType, 2);
            lblStack.Text += displayOrder + "\n";
            optionsArray[2] = toppingsType ;
            allChosenToppings += optionsArray[2] + "  ";
        }

        private void btnLettuce_Click(object sender, EventArgs e)
        {
            string toppingType = Toppings.createTopping("Lettuce");
            optionsArray[2] = toppingType ;
            allChosenToppings += optionsArray[2] + "  " ;
            //this still is using the old way of making the display.
            lblStack.Text += optionsArray[2] + "\n";
        }

        private void btnOnion_Click(object sender, EventArgs e)
        {
            string toppingType = Toppings.createTopping("Onion");
            optionsArray[2] = toppingType ;
            lblStack.Text += optionsArray[2] + "\n";
            allChosenToppings += optionsArray[2] + "  ";
        }
        

        //choose your sauces!!//

        private void btnKetsup_Click(object sender, EventArgs e)
        {
            string sauceType = Sauces.createSauces("Ketchup");
            optionsArray[3] = sauceType;
            lblStack.Text += optionsArray[3] + "\n";
            allChosenSauces += optionsArray[3] + "  ";
            //orderStep = "sauce";
        }

        private void btnMayo_Click(object sender, EventArgs e)
        {
            string sauceType = Sauces.createSauces("Mayo");
            optionsArray[3] = sauceType ;
            lblStack.Text += optionsArray[3] + "\n";
            allChosenSauces += optionsArray[3] + "  ";
            //orderStep = "sauce";
        }

        private void btnMustard_Click(object sender, EventArgs e)
        {
            string sauceType = Sauces.createSauces("Mustard");
            optionsArray[3] = sauceType ;
            lblStack.Text += optionsArray[3] + "\n";
            allChosenSauces += optionsArray[3] + "  ";
            //orderStep = "sauce";
        }

        private void btnBBQ_Click(object sender, EventArgs e)
        {
            string sauceType = Sauces.createSauces("BBQ");
            optionsArray[3] = sauceType ;
            lblStack.Text += optionsArray[3] + "\n";
            allChosenSauces += optionsArray[3] + "  ";
            //orderStep = "sauce";
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
            {
                lblFinalOrderReport.Text = "You ordered a delicious hamburger " 
                    + takeOut 
                    + "\nBun: " 
                    + lblStackBun.Text
                    + "\nCheese: "   + allChosenCheeses
                    + "\nSauce: "   + allChosenSauces
                    + "\nToppings: " + allChosenToppings;
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
            pnlNav.Visible = false;
            pnlPrevNext.Visible = true;
            btnPrev.Enabled = false;
            lblStack.Text = "  ";
            lblStackBun.Text = "  ";
            allChosenCheeses = " ";
            allChosenSauces = " ";
            allChosenToppings = " ";
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
     
        private void btnOrderAnother_Click(object sender, EventArgs e)
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
            lblStackBun.Text = "  ";
            allChosenCheeses = " ";
            allChosenSauces = " ";
            allChosenToppings = " ";
        }

        //this is for the 'change selection' buttons
        /* I just reset the array and concatenation
         * and the choice starts fresh */

        private void btnChangeCheese_Click(object sender, EventArgs e)
        {
            optionsArray[1] = "\n ";
            allChosenCheeses = " ";
            lblStack.Text = optionsArray[1] + optionsArray[2] + optionsArray[3];
        }

        private void btnChangeTopping_Click(object sender, EventArgs e)
        {
            optionsArray[2] = "\n ";
            allChosenToppings = " ";
            lblStack.Text = optionsArray[1] + optionsArray[2] + optionsArray[3];
        }       
        
        private void btnChangeSauce_Click(object sender, EventArgs e)
        {
            optionsArray[3] = "\n ";
            allChosenSauces = " ";
            lblStack.Text = optionsArray[1] + optionsArray[2] + optionsArray[3];
        }

 
    }
}