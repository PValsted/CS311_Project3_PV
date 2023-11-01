namespace CS311_Project3_PV
{
    public partial class PizzaApp : Form
    {
        //prices:
        double SMALL = 2.0;
        double MEDIUM = 5.0;
        double LARGE = 10.0;
        double XLARGE = 15.0;
        double GINORMOUS = 20.0;
        double PEPPERONI = 2.0, SAUSAGE = 2.0, CBACON = 2.0, SPICYSAUSAGE = 2.0;
        double OTHERTOP = 1.0;

        double TAX = 0.06;
        double sum;

        public PizzaApp()
        {
            InitializeComponent();
        }//end constructor

        /*
         * This method prints the user's selections to the rich text box and calculates the SubTotal, Tax, and Total
         * 
         */
        private void Summarize()
        {
            String data = cboSize.GetItemText(cboSize.SelectedItem);

            //this section initializes the sum as the price of the chosen size
            if (data == "Small") sum = SMALL;
            else if (data == "Medium") sum = MEDIUM;
            else if (data == "Large") sum = LARGE;
            else if (data == "X-Large") sum = XLARGE;
            else if (data == "Ginormous") sum = GINORMOUS;

            //this section determines the message at the top of the summary box based on the crust the user selects
            if (rdoReg.Checked) rtfSummary.SelectedText = "You ordered a " + data + " pizza with Regular crust and the following toppings:\n";
            else if (rdoThick.Checked) rtfSummary.SelectedText = "You ordered a " + data + " pizza with Thick crust and the following toppings:\n";
            else if (rdoThin.Checked) rtfSummary.SelectedText = "You ordered a " + data + " pizza with Thin crust and the following toppings:\n";

            //this section checks to see if each of the 12 toppings are checked,
            if (ckbPepperoni.Checked)
            {
                rtfSummary.SelectionBullet = true; //and if so, formats the line to be bulleted,
                rtfSummary.SelectedText = "Pepperoni\n"; //outputs the name of the topping and starts a new line,
                rtfSummary.SelectionBullet = false; //makes the format unbulleted so the last topping won't output a blank bulleted line,
                sum = sum + PEPPERONI; //and finally adds the price of the topping to the current sum
            }

            if (ckbSausage.Checked)
            {
                rtfSummary.SelectionBullet = true;
                rtfSummary.SelectedText = "Sausage\n";
                rtfSummary.SelectionBullet = false;
                sum = sum + SAUSAGE;
            }

            if (ckbCBacon.Checked)
            {
                rtfSummary.SelectionBullet = true;
                rtfSummary.SelectedText = "Canadian Bacon\n";
                rtfSummary.SelectionBullet = false;
                sum = sum + CBACON;
            }

            if (ckbSpicySausage.Checked)
            {
                rtfSummary.SelectionBullet = true;
                rtfSummary.SelectedText = "Spicy Italian Sausage\n";
                rtfSummary.SelectionBullet = false;
                sum = sum + SPICYSAUSAGE;
            }

            if (ckbOnion.Checked)
            {
                rtfSummary.SelectionBullet = true;
                rtfSummary.SelectedText = "Onion\n";
                rtfSummary.SelectionBullet = false;
                sum = sum + OTHERTOP;
            }

            if (ckbGrnPepper.Checked)
            {
                rtfSummary.SelectionBullet = true;
                rtfSummary.SelectedText = "Green Peppers\n";
                rtfSummary.SelectionBullet = false;
                sum = sum + OTHERTOP;
            }

            if (ckbBlOlive.Checked)
            {
                rtfSummary.SelectionBullet = true;
                rtfSummary.SelectedText = "Black Olives\n";
                rtfSummary.SelectionBullet = false;
                sum = sum + OTHERTOP;
            }

            if (ckbGrnOlive.Checked)
            {
                rtfSummary.SelectionBullet = true;
                rtfSummary.SelectedText = "Green Olives\n";
                rtfSummary.SelectionBullet = false;
                sum = sum + OTHERTOP;
            }

            if (ckbBanPepper.Checked)
            {
                rtfSummary.SelectionBullet = true;
                rtfSummary.SelectedText = "Banana Peppers\n";
                rtfSummary.SelectionBullet = false;
                sum = sum + OTHERTOP;
            }

            if (ckbJalepeno.Checked)
            {
                rtfSummary.SelectionBullet = true;
                rtfSummary.SelectedText = "Jalepenos\n";
                rtfSummary.SelectionBullet = false;
                sum = sum + OTHERTOP;
            }

            if (ckbCheese.Checked)
            {
                rtfSummary.SelectionBullet = true;
                rtfSummary.SelectedText = "Extra Cheese\n";
                rtfSummary.SelectionBullet = false;
                sum = sum + OTHERTOP;
            }

            if (ckbMushroom.Checked)
            {
                rtfSummary.SelectionBullet = true;
                rtfSummary.SelectedText = "Mushrooms\n";
                rtfSummary.SelectionBullet = false;
                sum = sum + OTHERTOP;
            }

            //this section outputs the SubTotal, Tax, and Total to the appropriate text boxes
            txtSub.Text = sum.ToString("C");
            txtTax.Text = (sum * TAX).ToString("C");
            txtTotal.Text = (sum + (sum * TAX)).ToString("C");

        }//end Summarize

        /*
         * This method runs when the Calculate button is pressed and executes the Summarize() method
         * 
         */
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Summarize();
        }//end btnCalculate_Click

    }//end form
}//end namespace