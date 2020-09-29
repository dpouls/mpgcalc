using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace mpgcalc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// The following function will take the input from the miles and gallon entry and parse it into the numeric datatypes. After that, it will divide the miles by the gallons and return the result to the front end.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCalculate_Clicked(object sender, EventArgs e)
        {
            //creating a variable to hold the input from the EntryMiles field on the front end and parsing it into a numeric datatype
            double miles = double.Parse(EntryMiles.Text);
            //creating a variable to hold the input from the EntryGallons field on the front end and parsing it into a numeric datatype

            double gallons = double.Parse(EntryGallons.Text);
            // creates a variable called mpg to hold the result of dividing the miles by the gallons
            double mpg = miles / gallons;
            //replaces the text in LblResults with the new value for mpg that was just calculated. The result is a number so we need to use the .ToString() method to "parse" it back into a string.
            LblResults.Text = mpg.ToString("n2");
        }
    }
}
