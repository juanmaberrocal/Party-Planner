using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace partyPlanCalc
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;

        public Form1()
        {
            InitializeComponent();

            // initialize dinner party
            // v1:
            //dinnerParty = new DinnerParty() { NumberOfPeople = 5 };
            //dinnerParty.SetHeathyOption(healthyBox.Checked);
            //dinnerParty.CalculateCostOfDecorations(fancyBox.Checked);

            // v2:
            dinnerParty = new DinnerParty((int)numericUpDown1.Value, healthyBox.Checked, fancyBox.Checked);
            DisplayDinnerPartyCost();

            // initialize birthday party
            birthdayParty = new BirthdayParty((int)numberBirthday.Value, fancyBirthday.Checked, cakeWriting.Text);
            DisplayBirthdayPartyCost();
        }

        // dinner party methods
        private void DisplayDinnerPartyCost()
        {
            // get cost of dinner party
            // v1:
            // decimal Cost = dinnerParty.CalculateCost(healthyBox.Checked);

            // v2:
            decimal Cost = dinnerParty.Cost;

            // display cost
            totalCostLabel.Text = Cost.ToString("c");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // set number of people
            // v1:
            // dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;

            // v2:
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;


            DisplayDinnerPartyCost(); // always update cost label
        }

        private void fancyBox_CheckedChanged(object sender, EventArgs e)
        {
            // set fancy option
            // v1:
            // dinnerParty.CalculateCostOfDecorations(fancyBox.Checked);

            // v2:
            dinnerParty.FancyDecoration = fancyBox.Checked;

            DisplayDinnerPartyCost(); // always update cost label
        }

        private void healthyBox_CheckedChanged(object sender, EventArgs e)
        {
            // set healthy option
            // v1:
            // dinnerParty.SetHeathyOption(healthyBox.Checked);

            // v2:
            dinnerParty.HealthyOption = healthyBox.Checked;

            DisplayDinnerPartyCost(); // always update cost label
        }

        // birthday party methods
        private void DisplayBirthdayPartyCost()
        {
            // check length of writing
            tooLongLabel.Visible = birthdayParty.CakeWritingTooLong;

            // get cost of party
            decimal Cost = birthdayParty.Cost;

            // display cost
            birthdayCost.Text = Cost.ToString("c");
        }

        private void numberBirthday_ValueChanged(object sender, EventArgs e)
        {
            // set number of people
            birthdayParty.NumberOfPeople = (int)numberBirthday.Value;
            DisplayBirthdayPartyCost(); // always update cost label
        }

        private void fancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            // set fancy option
            birthdayParty.FancyDecorations = fancyBirthday.Checked;
            DisplayBirthdayPartyCost(); // always update cost label
        }

        private void cakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = cakeWriting.Text;
            DisplayBirthdayPartyCost();
        }
    }
}
