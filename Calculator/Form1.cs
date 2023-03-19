namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        double number1; // is the first operator of calculator
        bool division = false;  // will be true if the opeartion is ongoing if not will be false

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

        }

        private void btnAddition_Click(object sender, EventArgs e)
        {

        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {

        }

        private void btnDivision_Click(object sender, EventArgs e)
        { 

            double number;
            bool isNumeric = double.TryParse(txtCalculator.Text, out number);
            if (isNumeric)
            {
                
                // when the user starts a division, if the first operator is a valid number:
                // we will save the first operator
                // we will empty the calculator input
                // we will mark the division as ongoing
                division = true;
                number1 = number;
                txtCalculator.Text = "";
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (txtCalculator.Text.IndexOf(".") == -1)  //NOT FOUND . IN CALCULATOR
            {
                txtCalculator.Text = txtCalculator.Text + ".";
            }
            

        }
    }
}