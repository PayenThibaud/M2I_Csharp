namespace Calculatrice
{
    public partial class MainPage : ContentPage
    {
        private string currentInput = string.Empty;
        private string currentOperator = string.Empty;
        private double result = 0;
        private bool isNewInput = true;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnNumberClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string pressedNumber = button.Text;

            if (isNewInput)
            {
                DisplayLabel.Text = pressedNumber;
                isNewInput = false;
            }
            else
            {
                DisplayLabel.Text += pressedNumber;
            }
        }

        private void OnOperatorClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string pressedOperator = button.Text;

            currentOperator = pressedOperator;
            result = double.Parse(DisplayLabel.Text);
            isNewInput = true;
        }

        private void OnDecimalClicked(object sender, EventArgs e)
        {
            if (!DisplayLabel.Text.Contains("."))
            {
                DisplayLabel.Text += ".";
            }
        }

        private void OnEqualsClicked(object sender, EventArgs e)
        {
            double secondNumber = double.Parse(DisplayLabel.Text);

            switch (currentOperator)
            {
                case "+":
                    result += secondNumber;
                    break;
                case "-":
                    result -= secondNumber;
                    break;
                case "*":
                    result *= secondNumber;
                    break;
                case "/":
                    if (secondNumber != 0)
                    {
                        result /= secondNumber;
                    }
                    else
                    {
                        DisplayLabel.Text = "Error";
                        return;
                    }
                    break;
            }

            DisplayLabel.Text = result.ToString();
            isNewInput = true;
        }
    }
}