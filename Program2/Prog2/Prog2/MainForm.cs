// Program 2
// CIS 200-75
// Fall 2014
// Due: 11/2/2014
// By: Javoni Faucette

// File: MainForm.cs
// This lets the information from the other forms created by the options available in the tool bar display in this form in the Rich Text
    // Box. It pulls whatever was entered and inserted in the insert address/parcels into this form in the reports section.

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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Test Data
            Address a1 = new Address("John Smith", "123 Any St.", "Apt. 45",
                "Louisville", "KY", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4
            Address a5 = new Address("Travis Tingle", "5678 Lamplight Ln.", "APT. 1220",
                "Dallas", "TX", 75056); // Test Address 5
            Address a6 = new Address("Javoni Faucette ", "1830 South 3rd Street", "APT. 18",
                "Austin", "TX", 78660); // Test Address 6
            Address a7 = new Address("Sarah Drury", "5648 Sea Dr.", "APT. 90",
                "Los Angeles", "CA", 90001); // Test Address 7
            Address a8 = new Address("Janelle Jenkins", "9878 Volleyball Ave.", "APT. 3",
                "Louisville", "KY", 40208); // Test Address 8


            Letter letter1 = new Letter(a1, a2, 3.95M);                           // Letter test objects
            Letter letter2 = new Letter(a6, a5, 6.40M);
            GroundPackage gp1 = new GroundPackage(a3, a4, 14, 10, 5, 12.5);        // Ground test objects
            GroundPackage gp2 = new GroundPackage(a1, a2, 10, 9, 4, 6);
            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15,    // Next Day test objects
                85, 7.50M);
            NextDayAirPackage ndap2 = new NextDayAirPackage(a1, a3, 3, 6, 9, 10, 4.6m);
            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a4, a1, 46.5, 39.5, 28.0, // Two Day test objects
                80.5, 'S');
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a1, a2, 6, 7, 8, 9, 'E');

            parcelReportList.Add(letter1); // Populate lists
            parcelReportList.Add(letter2);
            parcelReportList.Add(gp1);
            parcelReportList.Add(gp2);
            parcelReportList.Add(ndap1);
            parcelReportList.Add(ndap2);
            parcelReportList.Add(tdap1);
            parcelReportList.Add(tdap2);
            addressReportList.Add(a1);
            addressReportList.Add(a2);
            addressReportList.Add(a3);
            addressReportList.Add(a4);
            addressReportList.Add(a5);
            addressReportList.Add(a6);
            addressReportList.Add(a7);
            addressReportList.Add(a8);

        }

        List<Parcel> parcelReportList = new List<Parcel>(); // Lists that hold the parcels and addresses to be used in reports
        List<Address> addressReportList = new List<Address>(); // and to pass to InsertLetter form

        // Properties that return the lists
        public List<Parcel> Parcels
        {
            get { return parcelReportList; } // PreCon: None.  PostCon: returns the parcel report list
        }

        public List<Address> Addresses
        {
            get { return addressReportList; } // PreCon: None.  PostCon: returns the Address report list
        }

        // About click event form the tool bar
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About abtForm = new About();
            abtForm.ShowDialog(); // displays my info
            abtForm.Dispose(); // Closes the form
        }

        // Exit click event from the tool bar
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exits the entire application.
        }

        // Insert address click event from the tool bar
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create new insertAddress form
            // displays the form as a dialog box and puts the results in result box on the main form.
            InsertAddress insertAddress = new InsertAddress(); 
            DialogResult result = insertAddress.ShowDialog(); 

            // if the form is validated and creates an address
            // Put the new address in the address report list
            if (result == DialogResult.OK) 
            {
                addressReportList.Add(insertAddress.NewAddress); 
            }

            insertAddress.Dispose(); // Closes the form
        }

        // Insert letter click event from the tool bar
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // creates a new insert letter form and passes the address list to it as a parameter
            // displays the form as a dialog box and puts the results in result box on the main form.
            InsertLetter insertLetter = new InsertLetter(Addresses);
            DialogResult result = insertLetter.ShowDialog();
            if (result == DialogResult.OK) // if the form validates completely and successfully creates a Letter
            {
                parcelReportList.Add(insertLetter.NewLetter); // Puts the new letter in the parcel list
            }
            insertLetter.Dispose(); // Closes the form
        }

        // List address click event from the tool bar
        private void listAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clears whatever was in the reports rich text box
            rtbReports.Clear();
            StringBuilder addressReport = new StringBuilder(); //stringbuilder to make the text report in format string
            //*****I had to get help on this one*****
           
            // for every address in the address list
            // Append to stringbuilder 
            foreach (Address address in Addresses) 
            {
                addressReport.Append(String.Format("{1}{0}***********************{0}", Environment.NewLine, address.ToString()));
            }
            rtbReports.AppendText(addressReport.ToString()); // displays the info from the stringbuilder
        }

        // List parcels click event from the tool bar
        private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clears whatever was in the reports rich text box
            rtbReports.Clear();
            StringBuilder parcelReport = new StringBuilder(); //stringbuilder to make the text report in format string
            // For every address in the address list
            // Appends to stringbuilder
            foreach (Parcel parcel in Parcels)
            {
                parcelReport.Append(String.Format("{1}{0}~~~~~~~~~~~~~~~~~~~~~~~~~~{0}", Environment.NewLine, parcel.ToString())); 
            }
            rtbReports.AppendText(parcelReport.ToString()); // displays the info from the stringbuilder
        }

    }
}
