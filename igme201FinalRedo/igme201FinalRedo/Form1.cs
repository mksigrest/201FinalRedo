namespace igme201FinalRedo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                string addText = button.Text;
                curOrder.Items.Add(addText);
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
    }
}
