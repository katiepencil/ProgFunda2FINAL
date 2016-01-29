namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ordering));
            this.btnOne = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnOne.Image = ((System.Drawing.Image)(resources.GetObject("btnOne.Image")));
            this.btnOne.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnOne.Location = new System.Drawing.Point(24, 48);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(186, 169);
            this.btnOne.TabIndex = 0;
            this.btnOne.Text = "Francine!";
            this.btnOne.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblOutput.Image = ((System.Drawing.Image)(resources.GetObject("lblOutput.Image")));
            this.lblOutput.Location = new System.Drawing.Point(264, 289);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 32);
            this.lblOutput.TabIndex = 1;
            // 
            // Ordering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 486);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnOne);
            this.Name = "Ordering";
            this.Text = "BurgerOrder";
            this.Load += new System.EventHandler(this.Ordering_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Label lblOutput;
    }
}

