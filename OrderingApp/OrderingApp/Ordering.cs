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
        string chosenBun;
        bool standardBurger;

        string orderStep; //this keeps track of what panel you're on

        public string[] optionsArray = new string[4];
        
        string bunType;
        string cheeseType;
        string[] toppings = new string[]{};
        string[] sauce = new string[]{};

        public Ordering()
        {
            InitializeComponent();
        }

        /* Load  events  */

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

            lblStack.Text = "  ";
        }

        /* Button click events  */
        //this is how we 'flip' the visibility of the first two panels
            //shut one off, turn the other on!

        private void btnStart_Click(object sender, EventArgs e)    
        {   pnlStart.Visible = false;
            pnlLocation.Visible = true;
            pnlNav.Visible = false;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {   takeOut = "to eat inside";
            pnlLocation.Visible = false;
            pnlOrderType.Visible = true;
            pnlNav.Visible = false;
        }

        private void btnOut_Click(object sender, EventArgs e)
        {   takeOut = "to eat outside";
            pnlLocation.Visible = false;
            pnlOrderType.Visible = true;
            pnlNav.Visible = false;
        }

        /* Panel Visible changed events   */

        private void pnlLocation_VisibleChanged(object sender, EventArgs e)
        {if (pnlLocation.Visible)
            {orderStep = "location";
            pnlNav.Visible = false;
            pnlPrevNext.Visible = false;
            }
        }

        private void pnlOrderType_VisibleChanged(object sender, EventArgs e)
        {if (pnlOrderType.Visible)
            { orderStep = "orderType";
            pnlNav.Visible = false;
            pnlPrevNext.Visible = true;
            }
        }
        private void pnlSpecialty_VisibleChanged(object sender, EventArgs e)
        { if (pnlSpecialty.Visible)
            { orderStep = "specialty";
                pnlNav.Visible = false;
                pnlPrevNext.Visible = false;
            }
        }
        private void pnlBuild_VisibleChanged(object sender, EventArgs e)
        {if (pnlBuild.Visible)
            { orderStep = "build";
            pnlNav.Visible = false;
            pnlPrevNext.Visible = true;
            }
        }

        private void pnlBun_VisibleChanged(object sender, EventArgs e)
        {if (pnlBun.Visible)
            {orderStep = "bun";
            pnlNav.Visible = true;
            pnlPrevNext.Visible = true;
            }   
        }
        private void pnlCheese_VisibleChanged(object sender, EventArgs e)
        { if (pnlCheese.Visible)
            { orderStep = "cheese";
            pnlNav.Visible = true;
            pnlPrevNext.Visible = true;
            }
        }
        private void pnlToppings_VisibleChanged(object sender, EventArgs e)
        { if (pnlToppings.Visible)
            { orderStep = "toppings";
            pnlNav.Visible = true;
                pnlPrevNext.Visible = true;
            }
        }
        private void pnlSauce_VisibleChanged(object sender, EventArgs e)
        { if (pnlSauce.Visible)
            { orderStep = "sauce";
              pnlNav.Visible = true;
              pnlPrevNext.Visible = true;
            }
        }
        

        /* Switch for prev/next button   */

        private void btnPrev_Click(object sender, EventArgs e)
        {
          switch (orderStep)
            {
                case "orderType":
                    pnlPrevNext.Visible = false;
                    pnlOrderType.Visible = false;
                    pnlLocation.Visible = true;
                    break;
                case "build":   
                    pnlBuild.Visible = false;
                    pnlOrderType.Visible = true;
                    break;
                case "bun":
                    pnlBuild.Visible = true;
                    pnlBun.Visible = false;
                    break;
                case "cheese":
                    pnlBun.Visible = true;
                    pnlCheese.Visible = false;
                    break;
                case "toppings":
                    pnlCheese.Visible = true;
                    pnlToppings.Visible = false;
                    break;
                case "sauce":
                    pnlToppings.Visible = true;
                    pnlSauce.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            switch (orderStep)
            {
                case "orderType":
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
                    pnlSummary.Visible = true;
                    pnlNav.Visible = false;
                    break;
                default:
                    break;
            }
        }


        /* Controls for the top nav buttons   */

        private void btnBun_Click(object sender, EventArgs e)
        {
            pnlNav.Visible = true;
            pnlPrevNext.Visible = true;

            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;

            pnlBuild.Visible = false;
            pnlBun.Visible = true;
            pnlCheese.Visible = false;
            pnlToppings.Visible = false;
            pnlSauce.Visible = false;

            pnlSpecialty.Visible = false;
            pnlSummary.Visible = false;
            pnlComplete.Visible = false;
            pnlBuild.Visible = false;
        }

        private void btnCheese_Click(object sender, EventArgs e)
        {
            pnlNav.Visible = true;
            pnlPrevNext.Visible = true;

            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;

            pnlBuild.Visible = false;
            pnlBun.Visible = false;
            pnlCheese.Visible = true;
            pnlToppings.Visible = false;
            pnlSauce.Visible = false;

            pnlSpecialty.Visible = false;
            pnlSummary.Visible = false;
            pnlComplete.Visible = false;
            pnlBuild.Visible = false;
        }

        private void btnToppings_Click(object sender, EventArgs e)
        {
            pnlNav.Visible = true;
            pnlPrevNext.Visible = true;

            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;

            pnlBuild.Visible = false;
            pnlBun.Visible = false;
            pnlCheese.Visible = false;
            pnlToppings.Visible = true;
            pnlSauce.Visible = false;

            pnlSpecialty.Visible = false;
            pnlSummary.Visible = false;
            pnlComplete.Visible = false;
            pnlBuild.Visible = false;
        }

        private void btnSauce_Click(object sender, EventArgs e)
        {
            pnlNav.Visible = true;
            pnlPrevNext.Visible = true;

            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;

            pnlBuild.Visible = false;
            pnlBun.Visible = false;
            pnlCheese.Visible = false;
            pnlToppings.Visible = false;
            pnlSauce.Visible = true;

            pnlSpecialty.Visible = false;
            pnlSummary.Visible = false;
            pnlComplete.Visible = false;
            pnlBuild.Visible = false;
        }

      
        /* Controls for the starting the building  */

        private void btnBuild_Click(object sender, EventArgs e)
        {
            pnlOrderType.Visible = false;
            pnlBuild.Visible = true;
            standardBurger = true;
        }
            
        private void btnSpecialty_Click(object sender, EventArgs e)
        { pnlOrderType.Visible = false;
            pnlSpecialty.Visible = true;
            standardBurger = false;
        }

        private void btnBuildMyBurger_Click(object sender, EventArgs e)
        { pnlBuild.Visible = false;
            pnlBun.Visible = true;
        }

     
        //choose your bun!!//

        private void btnWheatBun_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            string bunType = Bun.createBun("Wheat Bun");
            lblStackBun.Text = bunType;
        }
        
        private void btnWhiteBun_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            string bunType = Bun.createBun("White Bun");
            lblStackBun.Text = bunType;
        }

        private void btnPotatoBun_Click(object sender, EventArgs e)
        {    
            btnNext.Enabled = true;
            string bunType = Bun.createBun("Potato Bun");
            lblStackBun.Text = bunType;
        }

        
        //choose your cheese!!//

        private void btnCheese1_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            string cheeseType = Cheese.createCheese("WOW American Cheese");
            //optionsArray[1] = cheeseType + "\n";
            //lblStack.Text += optionsArray[1];
          
           string displayOrder = Display.createDisplay(cheeseType, 1);
           lblStack.Text += displayOrder;
        }

        private void btnCheese2_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            string cheeseType = Cheese.createCheese("Cheddar Cheese");
            optionsArray[1] = cheeseType + "\n";
            lblStack.Text += optionsArray[1];
        }

        private void btnCheese3_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            string cheeseType = Cheese.createCheese("Swiss Cheese");
            optionsArray[1] = cheeseType + "\n";
            lblStack.Text += optionsArray[1];
        }

        private void btnNoCheese_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            string cheeseType = Cheese.createCheese("No Cheese");
            optionsArray[1] = cheeseType + "\n";
            lblStack.Text += optionsArray[1];
        }

       
        //choose your toppings!!//

        private void btnPickles_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            string toppingsType = Toppings.createTopping("WOW PICKLES!");
            string displayOrder = Display.createDisplay(toppingsType, 2);
            lblStack.Text += displayOrder;

           // string toppingType = Toppings.createTopping("Pickles");
            //optionsArray[2] = toppingType + "\n";
            //lblStack.Text += optionsArray[2];
        }

        private void btnTomato_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            string toppingsType = Toppings.createTopping("WOW tomatoes!");
            string displayOrder = Display.createDisplay(toppingsType, 2);
            lblStack.Text += displayOrder;

            //string toppingType = Toppings.createTopping("Tomatoes");
            //optionsArray[2] = toppingType + "\n";
            //lblStack.Text += optionsArray[2];
        }

        private void btnLettuce_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            string toppingType = Toppings.createTopping("Lettuce");
            optionsArray[2] = toppingType + "\n";
            lblStack.Text += optionsArray[2];
        }

        private void btnOnion_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            string toppingType = Toppings.createTopping("Onion");
            optionsArray[2] = toppingType + "\n";
            lblStack.Text += optionsArray[2];
        }

       
        //choose your sauces!!//

        private void btnKetsup_Click(object sender, EventArgs e)
        {
            string sauceType = Sauces.createSauces("Ketsup");
            optionsArray[3] = sauceType + "\n";
            lblStack.Text += optionsArray[3]; 
        }

        private void btnMayo_Click(object sender, EventArgs e)
        {
            string sauceType = Sauces.createSauces("Mayo");
            optionsArray[3] = sauceType + "\n";
            lblStack.Text += optionsArray[3]; 
        }

        private void btnMustard_Click(object sender, EventArgs e)
        {
            string sauceType = Sauces.createSauces("Mustard");
            optionsArray[3] = sauceType + "\n";
            lblStack.Text += optionsArray[3]; 
        }

        private void btnBBQ_Click(object sender, EventArgs e)
        {
            string sauceType = Sauces.createSauces("BBQ");
            optionsArray[3] = sauceType + "\n";
            lblStack.Text += optionsArray[3]; 
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
        
    }
    }