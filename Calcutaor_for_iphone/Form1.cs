namespace Calcutaor_for_iphone
{
    public partial class Form1 : Form
    {
        double firstNum, SecNum;
        char option; // Changed from float to char for clarity
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtdisplay.Text = "0"; // Initialize display
        }

        // Consolidated number button click handler
        private void NumberButton_Click(string number)
        {
            if (txtdisplay.Text == "0")
            {
                txtdisplay.Text = number;
            }
            else
            {
                txtdisplay.Text += number;
            }
        }

        private void btn9_Click(object sender, EventArgs e) => NumberButton_Click("9");
        private void btn8_Click(object sender, EventArgs e) => NumberButton_Click("8");
        private void btn7_Click(object sender, EventArgs e) => NumberButton_Click("7");
        private void btn6_Click(object sender, EventArgs e) => NumberButton_Click("6");
        private void btn5_Click(object sender, EventArgs e) => NumberButton_Click("5");
        private void btn4_Click(object sender, EventArgs e) => NumberButton_Click("4");
        private void btn3_Click(object sender, EventArgs e) => NumberButton_Click("3");
        private void btn2_Click(object sender, EventArgs e) => NumberButton_Click("2");
        private void btn1_Click(object sender, EventArgs e) => NumberButton_Click("1");
        private void btn0_Click(object sender, EventArgs e) => NumberButton_Click("0");

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtdisplay.Text, out firstNum))
            {
                option = '+';
                txtdisplay.Text = "0";
            }
            else
            {
                txtdisplay.Text = "Error";
            }
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtdisplay.Text, out firstNum))
            {
                option = '-';
                txtdisplay.Text = "0";
            }
            else
            {
                txtdisplay.Text = "Error";
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtdisplay.Text, out firstNum))
            {
                option = '*';
                txtdisplay.Text = "0";
            }
            else
            {
                txtdisplay.Text = "Error";
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtdisplay.Text, out firstNum))
            {
                option = '/';
                txtdisplay.Text = "0";
            }
            else
            {
                txtdisplay.Text = "Error";
            }
        }

        private void buttonPM_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtdisplay.Text, out double q))
            {
                txtdisplay.Text = (-q).ToString();
            }
            else
            {
                txtdisplay.Text = "Error";
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = "0";
            firstNum = 0;
            SecNum = 0;
            option = '\0';
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = "0";
        }

        private void buttonCearspace_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text.Length > 0)
            {
                txtdisplay.Text = txtdisplay.Text.Remove(txtdisplay.Text.Length - 1, 1);
            }
            if (string.IsNullOrEmpty(txtdisplay.Text))
            {
                txtdisplay.Text = "0";
            }
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtdisplay.Text, out SecNum))
            {
                txtdisplay.Text = "Error";
                return;
            }

            double result = 0;
            bool validOperation = true;

            if (option == '+')
            {
                result = firstNum + SecNum;
            }
            else if (option == '-')
            {
                result = firstNum - SecNum;
            }
            else if (option == '*')
            {
                result = firstNum * SecNum;
            }
            else if (option == '/')
            {
                if (SecNum != 0)
                {
                    result = firstNum / SecNum;
                }
                else
                {
                    txtdisplay.Text = "Divide by 0";
                    validOperation = false;
                }
            }
            else
            {
                txtdisplay.Text = "Invalid Operation";
                validOperation = false;
            }

            if (validOperation)
            {
                txtdisplay.Text = result.ToString();
            }
        }

        private void btnplue_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtdisplay.Text))
            {
                txtdisplay.Text = "0.";
            }
            else if (!txtdisplay.Text.Contains("."))
            {
                txtdisplay.Text += ".";
            }
            // Else do nothing to prevent multiple decimal points
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtdisplay.Text, out double value))
            {
                value = value / 100;
                txtdisplay.Text = value.ToString();
            }
            else
            {
                txtdisplay.Text = "Error";
            }
        }
    }
}