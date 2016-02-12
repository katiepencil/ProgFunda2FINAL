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

        int pattyNum;
        string orderStep; //this keeps track of what panel you're on

        string[] optionsArray = new string[4];
        
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
            pnlNav.Visible = true;
            pnlPrevNext.Visible = true;
            
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
        {   takeOut = " to eat inside.";
            pnlLocation.Visible = false;
            pnlOrderType.Visible = true;
            pnlNav.Visible = false;
        }

        private void btnOut_Click(object sender, EventArgs e)
        {   takeOut = " to eat outside.";
            pnlLocation.Visible = false;
            pnlOrderType.Visible = true;
            pnlNav.Visible = false;
        }

        /* Panel Visible changed events   */

        private void pnlLocation_VisibleChanged(object sender, EventArgs e)
        {if (pnlLocation.Visible == true)
            {orderStep = "location"; }
        }

        private void pnlOrderType_VisibleChanged(object sender, EventArgs e)
        {if (pnlOrderType.Visible == true)
            { orderStep = "orderType"; }
        }

        private void pnlBuild_VisibleChanged(object sender, EventArgs e)
        {if (pnlBuild.Visible == true)
            { orderStep = "build"; }
        }

        private void pnlBun_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlBun.Visible == true)
            { orderStep = "bun";
            
            //this checks if you've already ordered your bun...
            if (optionsArray[0] != "")
                 { btnNext.Enabled = true; }
            btnNext.Enabled = false;    
            }
            
        }

        /* Switch for prev/next button   */

        private void btnPrev_Click(object sender, EventArgs e)
        {
          switch (orderStep)
            {
                case "location":
                    pnlLocation.Visible = false;
                    pnlPrevNext.Visible = true;
                    break;
                case "build":                    
                    pnlBuild.Visible = false;
                    pnlPrevNext.Visible = true;
                    break;
                case "orderType":
                    pnlPrevNext.Visible = true;
                    break;
                case "bun":
                    pnlBuild.Visible = true;
                    pnlBun.Visible = false;
                    break;
                default:
                    pnlStart.Visible = true;
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
                default:
                    break;
            }
        }


        /* Controls for the top nav buttons   */

        private void btnBun_Click(object sender, EventArgs e)
        {
            pnlNav.Visible = true;

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

            pnlSummary.Visible = false;
            pnlBuild.Visible = false;
        }

        private void btnCheese_Click(object sender, EventArgs e)
        {
            pnlNav.Visible = true;

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

            pnlSummary.Visible = false;
            pnlBuild.Visible = false;
        }

        private void btnToppings_Click(object sender, EventArgs e)
        {
            pnlNav.Visible = true;

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

            pnlSummary.Visible = false;
            pnlBuild.Visible = false;
        }

        private void btnSauce_Click(object sender, EventArgs e)
        {
            pnlNav.Visible = true;
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

            pnlSummary.Visible = false;
            pnlBuild.Visible = false;
        }

        /* Controls for the starting the building  */

        private void btnBuild_Click(object sender, EventArgs e)
        {
            pnlOrderType.Visible = false;
            pnlBuild.Visible = true;
            pnlNav.Visible = false;
        }
            
        private void btnSpecialty_Click(object sender, EventArgs e)
        {
            pnlOrderType.Visible = false;
            pnlNav.Visible = true;
        }

        private void btnChooseBun_Click(object sender, EventArgs e)
        {
            pnlSummary.Visible = false;
            pnlBuild.Visible = true;
            pnlNav.Visible = true;
        }

        private void btnBuildMyBurger_Click(object sender, EventArgs e)
        {
            pnlBuild.Visible = false;
            pnlBun.Visible = true;
            pnlNav.Visible = true;
        }
        private void btnBunWhite_Click(object sender, EventArgs e)
        {
            pnlSummary.Visible = true;
            pnlBuild.Visible = false;
            chosenBun = "white bun";
        }

        //set the 'btnNext' button to enabled-true once it has been clicked!//

        private void btnAllDone_Click(object sender, EventArgs e)
        {
            pnlBuild.Visible = false;
            pnlSummary.Visible = true;
            btnNext.Enabled = true;
           }

        //choose your bun!!//

        private void btnWheatBun_Click(object sender, EventArgs e)
        {   optionsArray[0] = "wheatBun\n";
            lblStack.Text = optionsArray[0];
            btnNext.Enabled = true;
        }
        
        private void btnWhiteBun_Click(object sender, EventArgs e)
        {   optionsArray[0] = "whiteBun\n";
            lblStack.Text = optionsArray[0];
            btnNext.Enabled = true;
        }
       

        private void btnPotatoBun_Click(object sender, EventArgs e)
        {   optionsArray[0] = "potatoBun\n";
            lblStack.Text = optionsArray[0];
        }

        private void btnCheese1_Click(object sender, EventArgs e)
        {
            optionsArray[1] = "americanCheese\n";
            lblStack.Text += optionsArray[1];
        }

        private void btnCheese2_Click(object sender, EventArgs e)
        {
            optionsArray[1] = "cheddarCheese\n";
            lblStack.Text += optionsArray[1];
        }

        private void btnCheese3_Click(object sender, EventArgs e)
        {
            optionsArray[1] = "swissCheese\n";
            lblStack.Text += optionsArray[1];
        }

        private void btnNoCheese_Click(object sender, EventArgs e)
        {
            optionsArray[1] = "noCheese\n";
            lblStack.Text += optionsArray[1];
        }

        }
    }