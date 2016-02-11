namespace OrderingApp
{
    partial class Ordering
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlStart = new System.Windows.Forms.Panel();
            this.lblStart = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlLocation = new System.Windows.Forms.Panel();
            this.lblLocation = new System.Windows.Forms.Label();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.pnlBunChoice = new System.Windows.Forms.Panel();
            this.lblBunChoice = new System.Windows.Forms.Label();
            this.btnBunWhite = new System.Windows.Forms.Button();
            this.btnBunWheat = new System.Windows.Forms.Button();
            this.pnlOrderType = new System.Windows.Forms.Panel();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.btnSpecialty = new System.Windows.Forms.Button();
            this.btnBuild = new System.Windows.Forms.Button();
            this.pnlPrevNext = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.pnlBurgerNav = new System.Windows.Forms.Panel();
            this.btnToppings = new System.Windows.Forms.Button();
            this.btnCheese = new System.Windows.Forms.Button();
            this.btnMeat = new System.Windows.Forms.Button();
            this.btnBun = new System.Windows.Forms.Button();
            this.pnlOrderStart = new System.Windows.Forms.Panel();
            this.lblOrderStart = new System.Windows.Forms.Label();
            this.btnChooseMeat = new System.Windows.Forms.Button();
            this.btnChooseBun = new System.Windows.Forms.Button();
            this.btnChooseCheese = new System.Windows.Forms.Button();
            this.btnChooseToppings = new System.Windows.Forms.Button();
            this.btnAllDone = new System.Windows.Forms.Button();
            this.pnlFinalOrder = new System.Windows.Forms.Panel();
            this.lblFinalOrderReport = new System.Windows.Forms.Label();
            this.pnlStart.SuspendLayout();
            this.pnlLocation.SuspendLayout();
            this.pnlBunChoice.SuspendLayout();
            this.pnlOrderType.SuspendLayout();
            this.pnlPrevNext.SuspendLayout();
            this.pnlBurgerNav.SuspendLayout();
            this.pnlOrderStart.SuspendLayout();
            this.pnlFinalOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlStart
            // 
            this.pnlStart.BackColor = System.Drawing.Color.MistyRose;
            this.pnlStart.Controls.Add(this.lblStart);
            this.pnlStart.Controls.Add(this.btnStart);
            this.pnlStart.Location = new System.Drawing.Point(91, 79);
            this.pnlStart.Name = "pnlStart";
            this.pnlStart.Size = new System.Drawing.Size(756, 413);
            this.pnlStart.TabIndex = 1;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(68, 117);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(642, 42);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Click the button to begin!";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Gold;
            this.btnStart.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(256, 212);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(225, 81);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnlLocation
            // 
            this.pnlLocation.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.pnlLocation.Controls.Add(this.lblLocation);
            this.pnlLocation.Controls.Add(this.btnOut);
            this.pnlLocation.Controls.Add(this.btnIn);
            this.pnlLocation.Location = new System.Drawing.Point(91, 79);
            this.pnlLocation.Name = "pnlLocation";
            this.pnlLocation.Size = new System.Drawing.Size(756, 413);
            this.pnlLocation.TabIndex = 2;
            this.pnlLocation.Visible = false;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.Color.Maroon;
            this.lblLocation.Location = new System.Drawing.Point(68, 103);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(618, 42);
            this.lblLocation.TabIndex = 2;
            this.lblLocation.Text = "Where do you want to eat?";
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.Color.Turquoise;
            this.btnOut.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnOut.Location = new System.Drawing.Point(380, 212);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(210, 102);
            this.btnOut.TabIndex = 1;
            this.btnOut.Text = "Outside";
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.Violet;
            this.btnIn.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Location = new System.Drawing.Point(155, 213);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(198, 101);
            this.btnIn.TabIndex = 0;
            this.btnIn.Text = "Inside";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // pnlBunChoice
            // 
            this.pnlBunChoice.BackColor = System.Drawing.Color.Honeydew;
            this.pnlBunChoice.Controls.Add(this.lblBunChoice);
            this.pnlBunChoice.Controls.Add(this.btnBunWhite);
            this.pnlBunChoice.Controls.Add(this.btnBunWheat);
            this.pnlBunChoice.Location = new System.Drawing.Point(92, 74);
            this.pnlBunChoice.Name = "pnlBunChoice";
            this.pnlBunChoice.Size = new System.Drawing.Size(756, 413);
            this.pnlBunChoice.TabIndex = 3;
            this.pnlBunChoice.Visible = false;
            // 
            // lblBunChoice
            // 
            this.lblBunChoice.AutoSize = true;
            this.lblBunChoice.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBunChoice.ForeColor = System.Drawing.Color.Maroon;
            this.lblBunChoice.Location = new System.Drawing.Point(52, 102);
            this.lblBunChoice.Name = "lblBunChoice";
            this.lblBunChoice.Size = new System.Drawing.Size(655, 36);
            this.lblBunChoice.TabIndex = 2;
            this.lblBunChoice.Text = "What kind of bun would you like?";
            // 
            // btnBunWhite
            // 
            this.btnBunWhite.BackColor = System.Drawing.Color.Turquoise;
            this.btnBunWhite.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBunWhite.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnBunWhite.Location = new System.Drawing.Point(380, 212);
            this.btnBunWhite.Name = "btnBunWhite";
            this.btnBunWhite.Size = new System.Drawing.Size(210, 102);
            this.btnBunWhite.TabIndex = 1;
            this.btnBunWhite.Text = "White";
            this.btnBunWhite.UseVisualStyleBackColor = false;
            // 
            // btnBunWheat
            // 
            this.btnBunWheat.BackColor = System.Drawing.Color.Violet;
            this.btnBunWheat.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBunWheat.Location = new System.Drawing.Point(155, 213);
            this.btnBunWheat.Name = "btnBunWheat";
            this.btnBunWheat.Size = new System.Drawing.Size(198, 101);
            this.btnBunWheat.TabIndex = 0;
            this.btnBunWheat.Text = "Wheat";
            this.btnBunWheat.UseVisualStyleBackColor = false;
            this.btnBunWheat.Click += new System.EventHandler(this.btnBunWheat_Click);
            // 
            // pnlOrderType
            // 
            this.pnlOrderType.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlOrderType.Controls.Add(this.lblOrderType);
            this.pnlOrderType.Controls.Add(this.btnSpecialty);
            this.pnlOrderType.Controls.Add(this.btnBuild);
            this.pnlOrderType.Location = new System.Drawing.Point(93, 79);
            this.pnlOrderType.Name = "pnlOrderType";
            this.pnlOrderType.Size = new System.Drawing.Size(757, 411);
            this.pnlOrderType.TabIndex = 3;
            this.pnlOrderType.Visible = false;
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderType.Location = new System.Drawing.Point(185, 106);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(402, 42);
            this.lblOrderType.TabIndex = 2;
            this.lblOrderType.Text = "Choose an option";
            // 
            // btnSpecialty
            // 
            this.btnSpecialty.BackColor = System.Drawing.Color.Gold;
            this.btnSpecialty.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpecialty.Location = new System.Drawing.Point(417, 182);
            this.btnSpecialty.Name = "btnSpecialty";
            this.btnSpecialty.Size = new System.Drawing.Size(267, 131);
            this.btnSpecialty.TabIndex = 1;
            this.btnSpecialty.Text = "Specialty burgers!";
            this.btnSpecialty.UseVisualStyleBackColor = false;
            // 
            // btnBuild
            // 
            this.btnBuild.BackColor = System.Drawing.Color.Gold;
            this.btnBuild.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuild.Location = new System.Drawing.Point(73, 182);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(257, 130);
            this.btnBuild.TabIndex = 0;
            this.btnBuild.Text = "Build my own!";
            this.btnBuild.UseVisualStyleBackColor = false;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // pnlPrevNext
            // 
            this.pnlPrevNext.Controls.Add(this.btnNext);
            this.pnlPrevNext.Controls.Add(this.btnPrev);
            this.pnlPrevNext.Location = new System.Drawing.Point(96, 512);
            this.pnlPrevNext.Name = "pnlPrevNext";
            this.pnlPrevNext.Size = new System.Drawing.Size(754, 56);
            this.pnlPrevNext.TabIndex = 4;
            this.pnlPrevNext.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(0, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 0;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(0, 0);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 1;
            // 
            // pnlBurgerNav
            // 
            this.pnlBurgerNav.BackColor = System.Drawing.Color.Firebrick;
            this.pnlBurgerNav.Controls.Add(this.btnToppings);
            this.pnlBurgerNav.Controls.Add(this.btnCheese);
            this.pnlBurgerNav.Controls.Add(this.btnMeat);
            this.pnlBurgerNav.Controls.Add(this.btnBun);
            this.pnlBurgerNav.Location = new System.Drawing.Point(124, 12);
            this.pnlBurgerNav.Name = "pnlBurgerNav";
            this.pnlBurgerNav.Size = new System.Drawing.Size(610, 61);
            this.pnlBurgerNav.TabIndex = 5;
            this.pnlBurgerNav.Visible = false;
            // 
            // btnToppings
            // 
            this.btnToppings.BackColor = System.Drawing.Color.Gold;
            this.btnToppings.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToppings.ForeColor = System.Drawing.Color.DarkRed;
            this.btnToppings.Location = new System.Drawing.Point(433, 7);
            this.btnToppings.Name = "btnToppings";
            this.btnToppings.Size = new System.Drawing.Size(161, 46);
            this.btnToppings.TabIndex = 3;
            this.btnToppings.Text = "Toppings";
            this.btnToppings.UseVisualStyleBackColor = false;
            // 
            // btnCheese
            // 
            this.btnCheese.BackColor = System.Drawing.Color.Gold;
            this.btnCheese.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheese.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCheese.Location = new System.Drawing.Point(289, 7);
            this.btnCheese.Name = "btnCheese";
            this.btnCheese.Size = new System.Drawing.Size(129, 46);
            this.btnCheese.TabIndex = 2;
            this.btnCheese.Text = "Cheese";
            this.btnCheese.UseVisualStyleBackColor = false;
            // 
            // btnMeat
            // 
            this.btnMeat.BackColor = System.Drawing.Color.Gold;
            this.btnMeat.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeat.ForeColor = System.Drawing.Color.DarkRed;
            this.btnMeat.Location = new System.Drawing.Point(150, 8);
            this.btnMeat.Name = "btnMeat";
            this.btnMeat.Size = new System.Drawing.Size(122, 46);
            this.btnMeat.TabIndex = 1;
            this.btnMeat.Text = "Meat";
            this.btnMeat.UseVisualStyleBackColor = false;
            // 
            // btnBun
            // 
            this.btnBun.BackColor = System.Drawing.Color.Gold;
            this.btnBun.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBun.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBun.Location = new System.Drawing.Point(10, 8);
            this.btnBun.Name = "btnBun";
            this.btnBun.Size = new System.Drawing.Size(122, 46);
            this.btnBun.TabIndex = 0;
            this.btnBun.Text = "Bun";
            this.btnBun.UseVisualStyleBackColor = false;
            this.btnBun.Click += new System.EventHandler(this.btnBun_Click);
            // 
            // pnlOrderStart
            // 
            this.pnlOrderStart.BackColor = System.Drawing.Color.Honeydew;
            this.pnlOrderStart.Controls.Add(this.btnAllDone);
            this.pnlOrderStart.Controls.Add(this.btnChooseToppings);
            this.pnlOrderStart.Controls.Add(this.btnChooseCheese);
            this.pnlOrderStart.Controls.Add(this.lblOrderStart);
            this.pnlOrderStart.Controls.Add(this.btnChooseMeat);
            this.pnlOrderStart.Controls.Add(this.btnChooseBun);
            this.pnlOrderStart.Location = new System.Drawing.Point(0, 0);
            this.pnlOrderStart.Name = "pnlOrderStart";
            this.pnlOrderStart.Size = new System.Drawing.Size(991, 489);
            this.pnlOrderStart.TabIndex = 4;
            this.pnlOrderStart.Visible = false;
            // 
            // lblOrderStart
            // 
            this.lblOrderStart.AutoSize = true;
            this.lblOrderStart.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderStart.ForeColor = System.Drawing.Color.Maroon;
            this.lblOrderStart.Location = new System.Drawing.Point(217, 49);
            this.lblOrderStart.Name = "lblOrderStart";
            this.lblOrderStart.Size = new System.Drawing.Size(375, 36);
            this.lblOrderStart.TabIndex = 2;
            this.lblOrderStart.Text = "Click one to start";
            // 
            // btnChooseMeat
            // 
            this.btnChooseMeat.BackColor = System.Drawing.Color.Turquoise;
            this.btnChooseMeat.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseMeat.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnChooseMeat.Location = new System.Drawing.Point(394, 125);
            this.btnChooseMeat.Name = "btnChooseMeat";
            this.btnChooseMeat.Size = new System.Drawing.Size(237, 130);
            this.btnChooseMeat.TabIndex = 1;
            this.btnChooseMeat.Text = "Choose meat";
            this.btnChooseMeat.UseVisualStyleBackColor = false;
            // 
            // btnChooseBun
            // 
            this.btnChooseBun.BackColor = System.Drawing.Color.Violet;
            this.btnChooseBun.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseBun.Location = new System.Drawing.Point(166, 123);
            this.btnChooseBun.Name = "btnChooseBun";
            this.btnChooseBun.Size = new System.Drawing.Size(207, 130);
            this.btnChooseBun.TabIndex = 0;
            this.btnChooseBun.Text = "Choose bun";
            this.btnChooseBun.UseVisualStyleBackColor = false;
            this.btnChooseBun.Click += new System.EventHandler(this.btnChooseBun_Click);
            // 
            // btnChooseCheese
            // 
            this.btnChooseCheese.BackColor = System.Drawing.Color.Violet;
            this.btnChooseCheese.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseCheese.Location = new System.Drawing.Point(166, 261);
            this.btnChooseCheese.Name = "btnChooseCheese";
            this.btnChooseCheese.Size = new System.Drawing.Size(207, 126);
            this.btnChooseCheese.TabIndex = 3;
            this.btnChooseCheese.Text = "Choose cheese";
            this.btnChooseCheese.UseVisualStyleBackColor = false;
            // 
            // btnChooseToppings
            // 
            this.btnChooseToppings.BackColor = System.Drawing.Color.Violet;
            this.btnChooseToppings.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseToppings.Location = new System.Drawing.Point(392, 261);
            this.btnChooseToppings.Name = "btnChooseToppings";
            this.btnChooseToppings.Size = new System.Drawing.Size(239, 127);
            this.btnChooseToppings.TabIndex = 4;
            this.btnChooseToppings.Text = "Choose toppings";
            this.btnChooseToppings.UseVisualStyleBackColor = false;
            // 
            // btnAllDone
            // 
            this.btnAllDone.BackColor = System.Drawing.Color.Gold;
            this.btnAllDone.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllDone.Location = new System.Drawing.Point(725, 347);
            this.btnAllDone.Name = "btnAllDone";
            this.btnAllDone.Size = new System.Drawing.Size(239, 127);
            this.btnAllDone.TabIndex = 5;
            this.btnAllDone.Text = "All done";
            this.btnAllDone.UseVisualStyleBackColor = false;
            this.btnAllDone.Click += new System.EventHandler(this.btnAllDone_Click);
            // 
            // pnlFinalOrder
            // 
            this.pnlFinalOrder.Controls.Add(this.lblFinalOrderReport);
            this.pnlFinalOrder.Location = new System.Drawing.Point(33, 19);
            this.pnlFinalOrder.Name = "pnlFinalOrder";
            this.pnlFinalOrder.Size = new System.Drawing.Size(931, 455);
            this.pnlFinalOrder.TabIndex = 6;
            this.pnlFinalOrder.Visible = false;
            // 
            
            // Ordering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(992, 594);
            this.Controls.Add(this.pnlFinalOrder);
            this.Controls.Add(this.pnlOrderStart);
            this.Controls.Add(this.pnlBunChoice);
            this.Controls.Add(this.pnlOrderType);
            this.Controls.Add(this.pnlLocation);
            this.Controls.Add(this.pnlBurgerNav);
            this.Controls.Add(this.pnlPrevNext);
            this.Controls.Add(this.pnlStart);
            this.Name = "Ordering";
            this.Text = "Ordering";
            this.pnlStart.ResumeLayout(false);
            this.pnlStart.PerformLayout();
            this.pnlLocation.ResumeLayout(false);
            this.pnlLocation.PerformLayout();
            this.pnlBunChoice.ResumeLayout(false);
            this.pnlBunChoice.PerformLayout();
            this.pnlOrderType.ResumeLayout(false);
            this.pnlOrderType.PerformLayout();
            this.pnlPrevNext.ResumeLayout(false);
            this.pnlBurgerNav.ResumeLayout(false);
            this.pnlOrderStart.ResumeLayout(false);
            this.pnlOrderStart.PerformLayout();
            this.pnlFinalOrder.ResumeLayout(false);
            this.pnlFinalOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStart;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnlLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Panel pnlOrderType;
        private System.Windows.Forms.Panel pnlPrevNext;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.Button btnSpecialty;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Panel pnlBurgerNav;
        private System.Windows.Forms.Button btnToppings;
        private System.Windows.Forms.Button btnCheese;
        private System.Windows.Forms.Button btnMeat;
        private System.Windows.Forms.Button btnBun;
        private System.Windows.Forms.Panel pnlBunChoice;
        private System.Windows.Forms.Label lblBunChoice;
        private System.Windows.Forms.Button btnBunWhite;
        private System.Windows.Forms.Button btnBunWheat;
        private System.Windows.Forms.Panel pnlOrderStart;
        private System.Windows.Forms.Button btnChooseToppings;
        private System.Windows.Forms.Button btnChooseCheese;
        private System.Windows.Forms.Label lblOrderStart;
        private System.Windows.Forms.Button btnChooseMeat;
        private System.Windows.Forms.Button btnChooseBun;
        private System.Windows.Forms.Button btnAllDone;
        private System.Windows.Forms.Panel pnlFinalOrder;
        private System.Windows.Forms.Label lblFinalOrderReport;
    }
}

