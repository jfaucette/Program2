// Program 2
// CIS 200-75
// Fall 2014
// Due: 11/2/2014
// By: Javoni Faucette

// File: InsertLetter.cs
// Provides a function to the InsertLetter form. As well as, validating and validated methods to make sure stuff is entered in the fields.
// As well as button functions.

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
    public partial class InsertLetter : Form
    {   
        //PreCondition: insertletter has to have a list so it can populate them in the combo boxes
        //PostCondition:
        public InsertLetter(List<Address> Addresses)
        {
            InitializeComponent();
            //PreCondition:
            //PostCondition: Foreach loop that populates the ComboBoxes with addresses from the address list.
            foreach (Address address in Addresses)
            {
                cbOriginAddress.Items.Add(address.Name);
                cbDestinationAddress.Items.Add(address.Name);
            }
            this.Addresses = Addresses; // Method to the address list with reference from MainForm
        }

        private List<Address> _addresses;
        private Letter newLetter;

        // private property that creates the create Letters.
        private List<Address> Addresses   
        {
            get { return _addresses; } //PreCondition: Addresses must be set. 
                                       //PostCondition: Returns the list of addresses.
            set { _addresses = value; } //PreCondition: Value must be a list of addresses. 
                                        //PostCondition: sets _addresses to value. 
        }

        // Property that holds the output of this form to be referenced in the main form.
        public Letter NewLetter 
        {
            get { return newLetter; } //PreCondition: This property must be set after the letter constructor runs before the form closes. 
                                          //PostCondition: returns the letter to the mainform placed in the letter report list.
            private set { newLetter = value; } //PreCondition: None. 
                                                   //PostCondition: NewLetter is assigned the newly constructed letter.
        }

        // Orgin Address vailidating
        private void cbOriginAddress_Validating(object sender, CancelEventArgs e)
        {
            if (cbOriginAddress.SelectedIndex == -1) // Shows an error if no origin address selected from the ComboBox.
            {
                e.Cancel = true;
                errorProviderOrigin.SetError(cbOriginAddress, "You Must Select an Origin Address"); // Sets the error message.
            }

            if (cbOriginAddress.SelectedIndex == cbDestinationAddress.SelectedIndex) // Shows an error if same origin address and destination address are selected.
            {
                e.Cancel = true;
                errorProviderOrigin.SetError(cbOriginAddress, "The Orgin Address and Destination Address Cannot Be the Same"); // Sets the error message.
            }

        }

        // Orgin Address validated
        private void cbOriginAddress_Validated(object sender, EventArgs e)
        {
            errorProviderOrigin.SetError(cbOriginAddress, ""); // Removes the error
        }

        // Destination address validating
        private void cbDestinationAddress_Validating(object sender, CancelEventArgs e)
        {
            if (cbDestinationAddress.SelectedIndex == -1) // Shows an error if no destination address is selected from the ComboBox.
            {
                e.Cancel = true;
                errorProviderDestination.SetError(cbDestinationAddress, "Select a Destination Address"); // sets the error message.
            }

            if (cbDestinationAddress.SelectedIndex == cbOriginAddress.SelectedIndex) // shows an error if same origin address and destination address are selected.
            {
                e.Cancel = true;
                errorProviderDestination.SetError(cbDestinationAddress, "The Orgin Address and Destination Address Cannot Be the Same"); // sets the error message.
            }

        }

        // Destination Address validated
        private void cbDestinationAddress_Validated(object sender, EventArgs e)
        {
            errorProviderDestination.SetError(cbDestinationAddress, ""); // Removes the error.
        }

        // Fixed cost validating
        private void txtFixedCost_Validating(object sender, CancelEventArgs e) // Shows an error if the Fixed Cost text box is empty.
        {
            if (string.IsNullOrWhiteSpace(txtFixedCost.Text))
            {
                e.Cancel = true;
                errorProviderCost.SetError(txtFixedCost, "Enter a Fixed Cost"); // sets the error message.
            }
        }

        //Fixed cost validated
        private void txtFixedCost_Validated(object sender, EventArgs e)
        {
            errorProviderCost.SetError(txtFixedCost, ""); // Removes the error.
        }

        //Click event for the Insert Button
        private void btnLetterInsert_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren()) // if everything validates then...
            // create a new letter with the addresses and fixed cost and sets the NewLetter property to the curretn letter entered.
            { 
                this.NewLetter = new Letter(Addresses.ElementAt(cbOriginAddress.SelectedIndex), Addresses.ElementAt(cbDestinationAddress.SelectedIndex), Decimal.Parse(txtFixedCost.Text));
                this.DialogResult = DialogResult.OK; // Closes the form.
            }
        }

        // Click event for the Cancel Button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            {
                this.DialogResult = DialogResult.Cancel; // Closes the form.
            }
        }
    }
}
