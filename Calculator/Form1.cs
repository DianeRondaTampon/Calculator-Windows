namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        double operator1; // is the first operator of calculator
        bool division = false;  // will be true if the operation is ongoing if not will be false
        bool multiplication = false;  // will be true if the operation is ongoing if not will be false
        bool addition = false;  // will be true if the operation is ongoing if not will be false
        bool subtraction = false;  // will be true if the operation is ongoing if not will be false


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNumber1_Click(object sender, EventArgs e)
        {
            txtCalculator.Text = txtCalculator.Text + "1";
        }

        private void btnNumber2_Click(object sender, EventArgs e)
        {
            txtCalculator.Text = txtCalculator.Text + "2";
        }

        private void btnNumber3_Click(object sender, EventArgs e)
        {
            txtCalculator.Text = txtCalculator.Text + "3";
        }

        private void btnNumber4_Click(object sender, EventArgs e)
        {
            txtCalculator.Text = txtCalculator.Text + "4";
        }

        private void btnNumber5_Click(object sender, EventArgs e)
        {
            txtCalculator.Text = txtCalculator.Text + "5";
        }

        private void btnNumber6_Click(object sender, EventArgs e)
        {
            txtCalculator.Text = txtCalculator.Text + "6";
        }

        private void btnNumber7_Click(object sender, EventArgs e)
        {
            txtCalculator.Text = txtCalculator.Text + "7";
        }

        private void btnNumber8_Click(object sender, EventArgs e)
        {
            txtCalculator.Text = txtCalculator.Text + "8";
        }

        private void btnNumber9_Click(object sender, EventArgs e)
        {
            txtCalculator.Text = txtCalculator.Text + "9";
        }

        private void btnNumber0_Click(object sender, EventArgs e)
        {
            txtCalculator.Text = txtCalculator.Text + "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)  
        {
            double number;
            bool isNumeric = double.TryParse(txtCalculator.Text, out number);
            if (isNumeric)
            {
                if (division)
                {
                    double result = operator1 / number;
                    txtCalculator.Text = result.ToString();
                    division = false;
                }
                else if (multiplication)
                {
                    double result = operator1 * number;
                    txtCalculator.Text = result.ToString();
                    multiplication = false;
                }
                else if (subtraction)
                {
                    double result = operator1 - number;
                    txtCalculator.Text = result.ToString();
                    subtraction = false;
                }
                else if (addition)
                {
                    double result = operator1 + number;
                    txtCalculator.Text = result.ToString();
                    addition = false;
                }
            }
            else 
            { 
                MessageBox.Show("Error, not numeric"); 
            }
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            double number;
            bool isNumeric = double.TryParse(txtCalculator.Text, out number);
            if (isNumeric)
            {
                // when the user starts a addition, if the first operator is a valid number:

                // we will mark the addition as ongoing
                addition = true;
                subtraction = false;
                multiplication = false;
                division = false;
                // we will save the first operator
                operator1 = number;
                // we will empty the calculator input
                txtCalculator.Text = "";
            }
            else
            {
                MessageBox.Show("Error, not numeric");
            }
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            double number;
            bool isNumeric = double.TryParse(txtCalculator.Text, out number);
            if (isNumeric)
            {
                // when the user starts a subtraction, if the first operator is a valid number:

                // we will mark the subtraction as ongoing
                subtraction = true;
                addition = false;
                multiplication = false;
                division = false;
                // we will save the first operator
                operator1 = number;
                // we will empty the calculator input
                txtCalculator.Text = "";
            }
            else
            {
                MessageBox.Show("Error, not numeric");
            }
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            double number;
            bool isNumeric = double.TryParse(txtCalculator.Text, out number);
            if (isNumeric)
            {
                // when the user starts a multiplication, if the first operator is a valid number:

                // we will mark the multiplication as ongoing
                multiplication = true;
                addition = false;
                subtraction = false;
                division = false;
                // we will save the first operator
                operator1 = number;
                // we will empty the calculator input
                txtCalculator.Text = "";
            }
            else
            {
                MessageBox.Show("Error, not numeric");
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        { 

            double number;
            bool isNumeric = double.TryParse(txtCalculator.Text, out number);
            if (isNumeric)
            {
                // when the user starts a division, if the first operator is a valid number:

                // we will mark the division as ongoing
                division = true;
                addition = false;
                multiplication = false;
                subtraction = false;
                // we will save the first operator
                operator1 = number;
                // we will empty the calculator input
                txtCalculator.Text = "";
            }
            else
            {
                MessageBox.Show("Error, not numeric");
            }
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (txtCalculator.Text.IndexOf(".") == -1)  //Not found "." in calculator's input
            {
                txtCalculator.Text = txtCalculator.Text + ".";
            }
            

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCalculator.Text = "";
            operator1 = 0;
            division = false;
            multiplication = false;
            addition = false;
            subtraction = false;
        }
    }
}