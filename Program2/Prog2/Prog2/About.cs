// Program 2
// CIS 200-75
// Fall 2014
// Due: 11/2/2014
// By: Javoni Faucette

// File: About.cs
// Shows my class information. When the close button is clicked the About form closes.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        //PreCondition: None.
        //PostCondition: When the Close button is Clicked the About form closes.
        private void btnAbtClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK; // closes the form
        }
    }
}
