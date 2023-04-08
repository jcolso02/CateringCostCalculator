// S5034
// CIS 199-50
// Program 3
// November 11, 2021

// This program is a cost calculator for uThankItWeMakeIt Catering Services. 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            //
            // Variable Declaration
            //

            string[] cities = { "Louisville", "Lexington", "Indianapolis", "Nashville" };
            double[] shipmentFees = { 0.060, 0.0717, 0.070, 0.0817 };

            int itemNum;
            int servings;
            double totalCost;

            bool validItemNum = false;
            bool validServings = false;

            //
            // Item/Entree Number Validation
            //

            if (int.TryParse(itemNumTextBox.Text, out itemNum))
            {
                if (itemNum >= 10001 && itemNum <= 10007)
                {
                    validItemNum = true;
                    this.itemNumErrorLabel.Visible = false;
                }
                else
                {
                    this.itemNumErrorLabel.Visible = true;
                }
            }
            else
            {
                this.itemNumErrorLabel.Visible = true;
            }

            //
            // Serving Amount Validation
            //

            if (int.TryParse(quantityTextBox.Text, out servings))
            {
                if (servings > -1)
                {
                    validServings = true;
                    this.quantityErrorLabel.Visible = false;
                }
                else
                {
                    this.quantityErrorLabel.Visible = true;
                }
            }
            else
            {
                this.quantityErrorLabel.Visible = true;
            }

            //
            // Main Code
            //

            if (validItemNum && validServings)
            {
                double shipmentRate = shipmentFees[cityComboBox.SelectedIndex];

                // Serving Size to Fee

                double servingRate = 0;

                if(servings >= 0 && servings <= 5)
                {
                    servingRate = .15;
                }
                else if(servings >= 6 && servings <= 10)
                {
                    servingRate = .10;
                }
                else if(servings >= 11 && servings <= 20)
                {
                    servingRate = .05;
                }
                else
                {
                    servingRate = 1;
                }

                // Entree Number to Cost

                double entreeCost = 0;

                if(itemNum == 10001)
                {
                    entreeCost = 7.87;
                }
                else if(itemNum == 10002)
                {
                    entreeCost = 9.51;
                }
                else if(itemNum == 10003)
                {
                    entreeCost = 10.73;
                }
                else if(itemNum == 10004)
                {
                    entreeCost = 9.99;
                }
                else if(itemNum == 10005)
                {
                    entreeCost = 11.99;
                }
                else if (itemNum == 10006)
                {
                    entreeCost = 5.00;
                }
                else if (itemNum == 10007)
                {
                    entreeCost = 4.58;
                }

                // Calculations

                double initialCost = entreeCost * servings;

                double adjustedCost = (initialCost * servingRate) + initialCost;

                double shipmentCost = adjustedCost * shipmentRate;

                totalCost = adjustedCost + shipmentCost;

                // Display Totals

                initialTextBox.Text = initialCost.ToString("C2");

                adjustedTextBox.Text = adjustedCost.ToString("C2");

                shipmentTextBox.Text = shipmentCost.ToString("C2");

                totalTextBox.Text = totalCost.ToString("C2");

            }
            else // Clear Previous Results
            {
                initialTextBox.Text = "";
                adjustedTextBox.Text = "";
                shipmentTextBox.Text = "";
                totalTextBox.Text = "";
            }
        }
    }
}
