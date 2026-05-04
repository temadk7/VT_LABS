namespace LAB05
{
    public partial class Калькулятор : Form
    {
        public Калькулятор()
        {
            InitializeComponent();
            label4.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ReadNumbers(out double a, out double b))
            {
                ShowResult(a + b);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ReadNumbers(out double a, out double b))
            {
                ShowResult(a - b);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ReadNumbers(out double a, out double b))
            {
                ShowResult(a * b);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ReadNumbers(out double a, out double b))
            {
                if (b == 0)
                {
                    ShowError("Ошибка: деление на ноль");
                    return;
                }

                ShowResult(a / b);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label4.Text = "";
            label4.ForeColor = Color.Black;
            textBox1.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private bool ReadNumbers(out double a, out double b)
        {
            a = 0;
            b = 0;

            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                return true;
            }
            catch
            {
                ShowError("Ошибка: введите числа");
                return false;
            }
        }

        private void ShowResult(double result)
        {
            label4.ForeColor = Color.Black;
            label4.Text = result.ToString();
        }

        private void ShowError(string text)
        {
            label4.ForeColor = Color.Red;
            label4.Text = text;
        }
    }
}
