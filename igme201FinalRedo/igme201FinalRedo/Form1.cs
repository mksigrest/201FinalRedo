using System.Reflection.Metadata.Ecma335;
using System.IO;
using System.Text.Json;
using Microsoft.VisualBasic.ApplicationServices;

namespace igme201FinalRedo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadUsers();
        }

        Dictionary<string, List<Food>> users = new Dictionary<string, List<Food>>();

        bool loggedIn = false;
        double totalPrice = 0;
        double[] prices = { 2.25, 7.75, 8.50, 3.00, 1.50, 2.00, 0.00, 2.00, 1.50, 3.50, 1.25 };
        int[] calories = { 354, 303, 100, 365, 59, 95, 0, 150, 1, 137, 142 };
        int[] ounces = {0,0,0,0,0,0, 17, 12, 8 };

        private void label1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button == null || button.Tag == null) return;
            int buttonIndex = (int)button.Tag;

            if (buttonIndex != 6 && buttonIndex != 7 && buttonIndex != 8)
            {
                curOrder.Items.Add(new Food(button.Text, prices[buttonIndex], calories[buttonIndex]));
                priceUpdate(1, buttonIndex);
            }

            else
            {
                curOrder.Items.Add(new Drink(button.Text, prices[buttonIndex], calories[buttonIndex], ounces[buttonIndex]));
                priceUpdate(1, buttonIndex);
            }
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
                loggedIn = false;
            }

            else if (users.ContainsKey(user))
            {
                loggedIn = true;
                prevOrder.Items.Clear();
                foreach (var food in users[user])
                {
                    prevOrder.Items.Add(food);
                }
            }

            else
            {
                loggedIn = true;
                users[user] = new List<Food>();
            }
        }
        private void checkButton_Click(object sender, EventArgs e)
        {
            if (loggedIn == true)
            {
                string user = textBox1.Text;

                if (users.ContainsKey(user))
                {
                    users[user] = curOrder.Items.Cast<Food>().ToList();
                }

                MessageBox.Show($"Succesful Check out. Total is $" + totalPrice);
                curOrder.Items.Clear();
                totalPrice = 0;
                priceLabel.Text = $"Total: ${totalPrice}";

                string filePath = "users.txt";

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var user1 in users)
                    {
                        writer.WriteLine(user1.Key);
                        foreach (var food in user1.Value)
                        {
                            writer.WriteLine($"{food.Name}|{food.Price}|{food.Cals}");
                        }

                        writer.WriteLine("END");
                    }
                }
            }
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;

            curOrder.Items.Clear();
            foreach (var food in users[user])
            {
                curOrder.Items.Add(food);
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

        public void LoadUsers()
        {
            string filePath = "users.txt";

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    string currentUser = null;

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line == "END")
                        {
                            currentUser = null;
                        }

                        else if (currentUser == null)
                        {
                            currentUser = line;
                            users[currentUser] = new List<Food>();
                        }

                        else
                        {
                            string[] parts = line.Split('|');
                            if (parts.Length == 3 && double.TryParse(parts[1], out double price) && int.TryParse(parts[2], out int calories))
                            {
                                users[currentUser].Add(new Food(parts[0], price, calories));
                            }
                        }
                    }
                }
            }
        }
    }
}
