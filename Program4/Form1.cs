//Joe Dawson
//CIS199-01
//Due Date: April 24, 2016
//Program 4
/*This program takes user input for a package and stores it in a list. 
The user can then select the package from the list and see its details or change the package's origin and destination zip code by clicking the appropriate buttons
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program4
{
    public partial class groundPackageForm : Form
    {
        public groundPackageForm()
        {
            InitializeComponent();
        }
         
        private GroundPackage groundpackage = new GroundPackage(1, 1, 1, 1, 1, 1);//creates new instance of GroundPackage class and initializes values for all parameters
        List<string> mypackage = new List<string>();//Creates new list to hold package entries

        int originZip; // variable holding origin zip code passed through constructor
        int destinationZip;// variable holding destination zip code passed through constructor
        int uOfLZip = 40292;// variable holding xip code for the university of louisville used to replace origin and destination zip codes upon appropriate button clicks
        double length;// variable holding length passed through constructor
        double width;// variable holding width passed through constructor
        double height;// variable holding height zip code passed through constructor
        double weight;// variable holding weight zip code passed through constructor

        //Precondition: all textboxes must be appropriately filled
        //Postcondition: places package with user entered dimensions into list. Calculates shipping cost of package and places price into listbox
        private void addButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(originZipTextBox.Text, out originZip) && originZipTextBox.TextLength == 5)
            {
                if (int.TryParse(destinationZipTextBox.Text, out destinationZip) && destinationZipTextBox.TextLength == 5)
                {
                    if (double.TryParse(lengthTextBox.Text, out length) && length > 0)
                    {
                        if (double.TryParse(widthTextBox.Text, out width) && width > 0)
                        {
                            if (double.TryParse(heightTextBox.Text, out height) && height > 0)
                            {
                                if (double.TryParse(weightTextBox.Text, out weight) && weight > 0)
                                {
                                    groundpackage.OriginZip = originZip;
                                    groundpackage.DestinationZip = destinationZip;
                                    groundpackage.Length = length;
                                    groundpackage.Width = width;
                                    groundpackage.Height = height;
                                    groundpackage.Weight = weight;
                                    mypackage.Add(groundpackage.ToString());
                                    double cost = groundpackage.CalcCost(); //holds cost calculation to be converted into string
                                    packageListBox.Items.Add(cost.ToString("C"));
                                    originZipTextBox.Clear();
                                    destinationZipTextBox.Clear();
                                    lengthTextBox.Clear();
                                    widthTextBox.Clear();
                                    heightTextBox.Clear();
                                    weightTextBox.Clear();
                                }
                                else
                                {
                                    MessageBox.Show("Please enter valid weight");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please enter valid height");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid width");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid length");
                    }

                }
                else
                {
                    MessageBox.Show("Please enter valid zip code");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid zip code");
            }




        }

        //Precondition: package must be selected from listbox
        //Postcondition: Shows dimensions of user entered package in a messagebox
        private void detailsButton_Click(object sender, EventArgs e)
        {

            if (packageListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a package from the list");
            }
            else
            {
                bool found = false;
                for (int index = 0; index < mypackage.Count && found != true; index++)
                {
                    if (index == packageListBox.SelectedIndex)
                    {



                        MessageBox.Show(mypackage[index].ToString());
                        found = true;

                    }
                }

            }
        }

        //Precondition: package must be selected from listbox
        //Postcondition: replaces destination zip code with UofL's zip code, 40292
        private void sendToButton_Click(object sender, EventArgs e)
        {
            if (packageListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an package from the list");
            }
            else
            {
                bool found = false;
                for (int index = 0; index < mypackage.Count && found != true; index++)
                {
                    if (index == packageListBox.SelectedIndex)
                    {

                        mypackage.Remove(mypackage[index]);
                        packageListBox.Items.Remove(packageListBox.SelectedItem);
                        groundpackage.OriginZip = originZip;
                        groundpackage.DestinationZip = uOfLZip;
                        groundpackage.Length = length;
                        groundpackage.Width = width;
                        groundpackage.Height = height;
                        groundpackage.Weight = weight;
                        mypackage.Add(groundpackage.ToString());
                        double cost = groundpackage.CalcCost(); // variable to hold calculated cost to be converted to string
                        packageListBox.Items.Add(cost.ToString("C"));
                       
                        MessageBox.Show("The specified package destination has been reset");
                        found = true;
                    }
                }
            }
        }

        //Precondition: package must be selected from listbox
        //Postcondition: origin zip code replaced with UofL's zip code, 40292
        private void sendFromButton_Click(object sender, EventArgs e)
        {
           
            if(packageListBox.SelectedIndex == -1)
            {
                MessageBox.Show ("Please select a package from the list");
            }
            else
            {
                 bool found = false;
            for (int index = 0; index < mypackage.Count && found != true; index++)
            {
                if (index == packageListBox.SelectedIndex)
                {

                    mypackage.Remove(mypackage[index]);
                    packageListBox.Items.Remove(packageListBox.SelectedItem);
                    groundpackage.OriginZip = uOfLZip;
                    groundpackage.DestinationZip = destinationZip;
                    groundpackage.Length = length;
                    groundpackage.Width = width;
                    groundpackage.Height = height;
                    groundpackage.Weight = weight;
                    mypackage.Add(groundpackage.ToString());
                    double cost = groundpackage.CalcCost(); // variable to hold calculated cost to be converted to string
                    packageListBox.Items.Add(cost.ToString("C"));
                    
                    MessageBox.Show("The specified package origin has been reset");
                    found = true;
                }
            
           
                
            }
            }
                
            
            
        
    }
    }
}   
            
    
    


