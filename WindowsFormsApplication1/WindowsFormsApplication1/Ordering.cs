using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Ordering : Form
    {
        string message1 = "Wow, you have clicked a button!";
        string message2 = "yes, a note will go here.";

        public Ordering()
        {
            InitializeComponent();
        }

        private void Ordering_Load(object sender, EventArgs e)
        {
            lblOutput.Text = message2;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            lblOutput.Text = message1;
        }
    }
}
