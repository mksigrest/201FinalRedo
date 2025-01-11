using System.Reflection.Metadata.Ecma335;
using System.IO;
using System.Text.Json;

namespace igme201FinalRedo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double totalPrice = 0;
        double[] prices = { 2.25, 7.75, 8.50, 3.00, 1.50, 2.00, 0.00, 2.00, 1.50, 3.50, 1.25 };
        int[] calories = { 354, 303, 100, 365, 59, 95, 0, 150, 1, 137, 142 };
        string[] users = { };

        private void label1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string buttonName = button.Name.Substring(button.Name.IndexOf("ton") + 3);
            int buttonIndex = int.Parse(buttonName);

            curOrder.Items.Add(new Food(button.Text, prices[buttonIndex], calories[buttonIndex]));
            priceUpdate(1, buttonIndex);
        }

        private void curOrder_Click(object sender, EventArgs e)
        {
            if (curOrder.SelectedIndex != -1)
            {
                Food selectedFood = curOrder.SelectedItem as Food;
                int priceIndex = Array.IndexOf(prices, selectedFood.Price);

                curOrder.Items.RemoveAt(curOrder.SelectedIndex);
                priceUpdate(0, priceIndex);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;

            if (string.IsNullOrWhiteSpace(user))
            {
                textBox1.Text = "Enter Username";
            }

            else if (users.Contains(user))
            {

            }

            else
            {

            }
        }

        public void priceUpdate(int addSub, int priceIndex)
        {
            if (addSub == 1)
            {
                totalPrice += prices[priceIndex];
                priceLabel.Text = $"Total: ${totalPrice}";
            }

            else if (addSub == 0)
            {
                totalPrice -= prices[priceIndex];
                priceLabel.Text = $"Total: ${totalPrice}";
            }
        }
    }
}
