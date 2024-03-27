using SomerenModel;
using SomerenService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class AddDrinkForm : Form
    {
        public AddDrinkForm()
        {
            InitializeComponent();
            DrinkService drinkservice = new DrinkService();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxDrinkName.Text) || string.IsNullOrEmpty(textBoxPrice.Text) || string.IsNullOrEmpty(comboBoxType.Text) || string.IsNullOrEmpty(textBoxStockAmount.Text) || string.IsNullOrEmpty(textBoxSold.Text))
            {
                MessageBox.Show("Please fill required informations.");
                return; 
            }
            else
            {
                string drinkName = textBoxDrinkName.Text;
                bool isAlcoholic = radioButtonAlcoholic.Checked;
                float price = float.Parse(textBoxPrice.Text);
                string drinkType = comboBoxType.SelectedItem.ToString();
                string stockAmount = textBoxStockAmount.Text;
                int sold = int.Parse(textBoxSold.Text);

                Drink newDrink = new Drink
                {
                    DrinkName = drinkName,
                    IsAlcoholic = isAlcoholic,
                    Price = price,
                    DrinkType = drinkType,
                    StockAmount = stockAmount,
                    Sold = sold
                };


                try
                {

                    DrinkService drinkService = new DrinkService();
                    drinkService.AddDrink(newDrink);
                    MessageBox.Show("Drink added successfully!");



                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }

            }

           
        }

    }
}
