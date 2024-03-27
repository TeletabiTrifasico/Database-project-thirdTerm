using SomerenModel;
using SomerenService;
using System;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class UpdateDrinkForm : Form
    {
        private DrinkService drinkService;
        private Drink drink;

        public UpdateDrinkForm(Drink drink)
        {
            InitializeComponent();
            drinkService = new DrinkService();
            this.drink = drink;
            ShowDrink(drink);
        }
        
        private void ShowDrink(Drink drink)
        {
            txtBoxNewDrinkName.Text = drink.DrinkName;
            radioButtonAlcoholic.Checked = drink.IsAlcoholic;
            txtBoxNewPrice.Text=drink.Price.ToString();
            comboBoxNewType.SelectedItem=drink.DrinkType;
            txtBoxNewStockAmount.Text=drink.StockAmount.ToString();
            textBoxNewSold.Text=drink.Sold.ToString();

        }

        //update drink details
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            
            string newDrinkName = txtBoxNewDrinkName.Text;
            bool newIsAlcoholic=radioButtonAlcoholic.Checked;
            float newPrice = float.Parse(txtBoxNewPrice.Text);
            string newDrinkType = comboBoxNewType.SelectedItem.ToString();
            string newStockAmount = txtBoxNewStockAmount.Text;
            int newSold = int.Parse(textBoxNewSold.Text);

            drink.DrinkName = newDrinkName;
            drink.IsAlcoholic = newIsAlcoholic;
            drink.Price = newPrice;
            drink.DrinkType = newDrinkType;
            drink.StockAmount = newStockAmount;
            drink.Sold = newSold;


            try
            {
                drinkService.UpdateDrink(drink);

                MessageBox.Show("Drink updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }



    }
}
