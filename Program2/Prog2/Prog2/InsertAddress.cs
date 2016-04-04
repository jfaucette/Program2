// Program 2
// CIS 200-75
// Fall 2014
// Due: 11/2/2014
// By: Javoni Faucette

// File: InsertAddress.cs
// Provides a function to the InsertAddress form. As well as, validating and validated methods to make sure stuff is entered in the fields.
// As well as button functions. I also added all 50 states :) (I think...)

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
    public partial class InsertAddress : Form
    {
        public InsertAddress()
        {
            InitializeComponent();
        }

        // variables
        private Address newAddress;

        // property that holds the new address so it can be inserted into the address list.
        public Address NewAddress 
        {
            get { return newAddress; }
            private set { newAddress = value; }
        }


        // Name validating
        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text)) // Error if the Name text box is empty.
            {
                e.Cancel = true; 
                errorProviderName.SetError(txtName, "You Must Enter a Name"); // Sets error message.
            }
        }

        // Name validated
        private void txtName_Validated(object sender, EventArgs e)
        {
            errorProviderName.SetError(txtName, ""); // Removes the error.
        }

        // Address line 1 validating.
        private void txtAddressLine1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddressLine1.Text)) // Error if the Address Line 1 text box is empty.
            {
                e.Cancel = true;
                errorProviderAL1.SetError(txtAddressLine1, "You Must Enter an Address");//Sets the error message.
            }
        }

        // Address line 1 validated
        private void txtAddressLine1_Validated(object sender, EventArgs e)
        {
            errorProviderAL1.SetError(txtAddressLine1, ""); // Removes the error.
        }

        // City validating
        private void txtCity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCity.Text)) // Error if the City text box is empty.
            {
                e.Cancel = true;
                errorProviderCity.SetError(txtCity, "Enter a City"); // sets the error message.
            }
        }

        // City validated
        private void txtCity_Validated(object sender, EventArgs e)
        {
            errorProviderCity.SetError(txtCity, ""); // Removes the error.
        }

        // State validating
        private void cbState_Validating(object sender, CancelEventArgs e)
        {
            if (cboState.SelectedIndex == -1) // Error if nothing selected in the State ComboBox
            {
                e.Cancel = true;
                errorProviderState.SetError(cboState, "You Must Select a State"); // Sets the error Message.
            }
        }

        // State validated
        private void cbState_Validated(object sender, EventArgs e)
        {
            errorProviderState.SetError(cboState, ""); // Removes the error.
        }

        // Zip validating
        private void txtZIP_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtZIP.Text)) // Error if the Zip text box is empty.
            {
                e.Cancel = true;
                errorProviderZip.SetError(txtZIP, "You Must Enter a Zip"); // Sets the error message.
            }

        }

        // Zip validated
        private void txtZIP_Validated(object sender, EventArgs e)
        {
            errorProviderZip.SetError(txtZIP, ""); // Removes the error.
        }

        // Insert button click event.
        private void btnAddInsert_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren()) // If all of these validate then...
            {
                if (string.IsNullOrWhiteSpace(txtAddressLine2.Text)) // checks if address line 2 is blank
                    this.newAddress = new Address(txtName.Text, txtAddressLine1.Text, txtCity.Text, cboState.SelectedItem.ToString(), int.Parse(txtZIP.Text)); // New constructor if there is no address 2.
                else
                    this.newAddress = new Address(txtName.Text, txtAddressLine1.Text, txtAddressLine2.Text, txtCity.Text, cboState.SelectedItem.ToString(), int.Parse(txtZIP.Text)); // Constructor if there is something in address 2

                this.DialogResult = DialogResult.OK; // Closes the form.
            }
        }

        // Cancel button click event
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel; // Closes the form.
        }
    }
}
