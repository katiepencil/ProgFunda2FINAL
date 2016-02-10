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
            this.lbl1 = new System.Windows.Forms.Label();
            this.pnlStart = new System.Windows.Forms.Panel();
            this.lblStart = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlLocation = new System.Windows.Forms.Panel();
            this.lblLocation = new System.Windows.Forms.Label();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.pnlOrderType = new System.Windows.Forms.Panel();
            this.btnBuild = new System.Windows.Forms.Button();
            this.btnSpecialty = new System.Windows.Forms.Button();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.pnlPrevNext = new System.Windows.Forms.Panel();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.pnlStart.SuspendLayout();
            this.pnlLocation.SuspendLayout();
            this.pnlOrderType.SuspendLayout();
            this.pnlPrevNext.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl1.Location = new System.Drawing.Point(754, 24);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(226, 23);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "what will be here?";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
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
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(37, 7);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(245, 43);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Text = "<< Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(558, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(168, 49);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next >>";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // Ordering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(992, 594);
            this.Controls.Add(this.pnlLocation);
            this.Controls.Add(this.pnlPrevNext);
            this.Controls.Add(this.pnlOrderType);
            this.Controls.Add(this.pnlStart);
            this.Controls.Add(this.lbl1);
            this.Name = "Ordering";
            this.Text = "Ordering";
            this.pnlStart.ResumeLayout(false);
            this.pnlStart.PerformLayout();
            this.pnlLocation.ResumeLayout(false);
            this.pnlLocation.PerformLayout();
            this.pnlOrderType.ResumeLayout(false);
            this.pnlOrderType.PerformLayout();
            this.pnlPrevNext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
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
    }
}

