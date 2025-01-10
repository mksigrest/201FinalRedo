using System.Reflection.Metadata.Ecma335;

namespace igme201FinalRedo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double totalPrice = 0;
        double[] prices = {2.25, 7.75, 8.50, 3.00, 1.50, 2.00, 0.00, 2.00, 1.50, 3.50, 1.25 };
        int[] calories = {354, 303, 100, 365, 59, 95, 0, 150, 1, 137, 142};

        private void label1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string buttonName = button.Name.Substring(button.Name.IndexOf("ton") + 3);
            int buttonIndex = int.Parse(buttonName);

            if (sender is Button)
            {
                curOrder.Items.Add(new Food(button.Text, prices[buttonIndex], calories[buttonIndex]));
                priceUpdate(1, buttonIndex);
            }
            else
            {
                Console.WriteLine("Sender not a Button");
            }
        }

        private void curOrder_Click(object sender, EventArgs e)
        {
            curOrder.Items.RemoveAt(curOrder.SelectedIndex);
        }

        public void priceUpdate(int addSub, int priceIndex)
        {
            if (addSub == 1)
            {
                totalPrice += prices[priceIndex];
                Console.WriteLine(priceIndex);
                Console.WriteLine(totalPrice);
                priceLabel.Text = $"${totalPrice}";
            }

            else if(addSub == 0)
            {

            }
        }
    }
}
