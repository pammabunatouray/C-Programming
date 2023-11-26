using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//CIS-199 Program 3 
//Submission Date: 4/4/2022
//Grade ID:R2235
//This program will allow a user to figure out the cost of flowers based on the type of flower they would like and the number of flowers.

namespace ProgramThree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Arrays for the program
        string[] gardenType = { "Premium", "Standard", "Discount" };
        double[] baseRates = { 1.1, 1, 0.9 };

        int[] flowerNumbers = { 10001, 10002, 10003, 10004, 10005, 10006, 10007 };
        double[] flowercost = { 7.87, 9.51, 10.73, 9.99, 11.99, 5.00, 4.58 };

        double[] quantity = {1, 6, 16, 21 };
        double[] percentFullprice = {1, 0.95, 0.90, 0.85 };
        //bools for sequential search and doubles to reset the prices 
        bool gardenTypes = false;
        bool quantitytype = false;
        bool fNumbers = false;
        double flowerCosts = 0;
        double baseRate = 0;
        double quantityCost = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            
            

            if (int.TryParse(fnumberLabelinput.Text, out int flowerNumber) && flowerNumber >= 10001 && flowerNumber <= 10007)//Will prevent incorrect inputs for the flower number and they have to only be in the range 10001 to 10007
            {
                if (int.TryParse(quantityLabelinput.Text, out int quantityNumber) && quantityNumber >= 0)//Will prevent incorrect inputs for the quantity number, they can only range above 0
                {
                    if (gardenCombobox.SelectedIndex >= 0)//Combobox if statement 
                    {
                        
                        for (int x = 0; x < gardenType.Length && !gardenTypes; x++)// for loop used to align the garden combo boxes text to the gardentype array
                        {
                            if (gardenCombobox.Text == gardenType[x])//if statement used to align the garden combo box to the gardentype array
                            {
                                gardenTypes = true;//gardentype is true
                                baseRate = baseRates[x];//assignes the base rate value to the base rate array
                            }
                        }


                        for (int x = 0; x < flowerNumbers.Length && !fNumbers; x++)//for loop used to align the flower number with the flowernumbers in the array
                        {
                            if (flowerNumber == flowerNumbers[x])
                            {
                                fNumbers = true;//fNumber is true
                                flowerCosts = flowercost[x];//assings the flower cost value to the flower cost array
                            }
                        }

                        
                        for (int x = quantity.Length - 1; x >= 0 && !quantitytype; x--)//for loop used to compare quantity to the quantity array 
                        {
                            if (quantityNumber >= quantity[x])
                            {
                                quantitytype = true;//quantity type is true
                                quantityCost = percentFullprice[x];//will set the quantity array to the percentage discount
                            }
                        }

                        //Formulas to calculate the costs for the flowers,base cost, discount percentage, and the overall total price 
                        double flowerCost = flowerCosts * quantityNumber;
                        double baseCost = flowerCost * baseRate;
                        double discountPercent = 1 - quantityCost;
                        double totalPrice = baseCost * quantityCost;
                        flowerCostoutput.Text = $"{flowerCost:C}";
                        baseCostoutput.Text = $"{baseCost:C}";
                        discountPercentoutput.Text = $"{discountPercent:P}";
                        totalPriceoutput.Text = $"{totalPrice:C}";

                    }//else statements for incorrect inputs
                    else
                        MessageBox.Show("Error");
                }
                else
                    MessageBox.Show("Error");
            }
            else
                MessageBox.Show("Error");
        }
    }
}
