namespace WinFormsCalculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result=0;
            string input1 = num1Box.Text;
            string input2 = num2Box.Text;
            double number1=Double.Parse(input1);
            double number2 = Double.Parse(input2);
            string input3=opandBox.SelectedItem.ToString();
            char op = input3[0];
            switch(op)
            {
                case '+':
                    result = number1 + number2; 
                    break;
                case '-':
                    result = number1 - number2;
                    break;
                case '*':
                    result = number1 * number2;
                    break;
                case '/':
                    if(number2 == 0)
                    {
                        resultBox.Text = "除数不能为0";
                        return;
                    }
                    result = number1 / number2;
                    break;
            }
            resultBox.Text = result.ToString();
        }

        private void num1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
