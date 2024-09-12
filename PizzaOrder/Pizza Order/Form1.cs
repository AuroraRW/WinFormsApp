namespace Pizza_Order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            string Order = "Your order is: ";
            int TotalPrice = 10;

            bool showResult = true;

            Order += "\n Size: ";
            if (rdoSmall.Checked)
            {
                Order += " Small";
                TotalPrice += 5;
            }
            else if (rdoMedium.Checked)
            {
                Order += " Medium";
                TotalPrice += 8;
            }
            else if (rdoLarge.Checked) {
                Order += " Large";
                TotalPrice += 10;
            }
            else
            {
                MessageBox.Show("Please select one size!");
                showResult = false;
            }

            Order += "\n Toppings:";
            if (chkCheese.Checked) {
                Order += " Cheese";
                TotalPrice += 5;
            }
            if (chkBacon.Checked)
            {
                Order += " Bacon";
                TotalPrice += 10;
            }
            if (chkMushrooms.Checked)
            {
                Order += " Mushrooms";
                TotalPrice += 8;
            }
            if (chkPeppers.Checked)
            {
                Order += " Peppers";
                TotalPrice += 3;
            }

            Order += "\n Delivery Method: ";
            if (rdoPickup.Checked)
            {
                Order += " Pickup";
            }
            else if (rdoDelivery.Checked)
            {
                Order += " Delivery";
                TotalPrice += 5;
            }
            else
            {
                MessageBox.Show("Please select one delivery method!");
                showResult = false;
            }

            if (showResult)
            {
                Order += $"\n Total Price: ${TotalPrice}";
                MessageBox.Show(Order);
            }

        }
    }
}
