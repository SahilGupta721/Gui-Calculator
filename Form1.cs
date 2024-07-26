using System;
using System.Windows.Forms;
namespace Assignment_GUI_Fractional_calculator

{
    public partial class Form1 : Form
    {
        private string choice;

        public Form1()
        {
            InitializeComponent();
        }

        private void numerator1_TextChanged(object sender, EventArgs e)
        {
            numerator1.Text+="";
        }

        private void denominator1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radio_add_CheckedChanged(object sender, EventArgs e)
        {
            choice = "+";
        }

        private void radio_sub_CheckedChanged(object sender, EventArgs e)
        {
            choice = "-";
        }

        private void radio_mul_CheckedChanged(object sender, EventArgs e)
        {
            choice = "*";
        }

        private void radio_div_CheckedChanged(object sender, EventArgs e)
        {
            choice = "/";
        }

        private void numerator2_TextChanged(object sender, EventArgs e)
        {

        }

        private void denominator2_TextChanged(object sender, EventArgs e)
        {

        }

        private void result_num_TextChanged(object sender, EventArgs e)
        {
            result_num.Enabled = false;
        }

        private void result_den_TextChanged(object sender, EventArgs e)
        {
            result_den.Enabled = false;
        }

        private void Per_operation_Click(object sender, EventArgs e)
        {
            DoCalculation();
        }
        public void DoCalculation()
        {
            try
            {
                Fraction fraction1 = new Fraction(numerator1.Text, denominator1.Text);
                Fraction fraction2 = new Fraction(numerator2.Text, denominator2.Text);
                Fraction result;

                switch (choice)
                {
                    case "+":
                        result = fraction1 + fraction2;
                        break;
                    case "-":
                        result = fraction1 - fraction2;
                        break;
                    case "*":
                        result = fraction1 * fraction2;
                        break;
                    case "/":
                        result = fraction1 / fraction2;
                        break;
                    default:
                        throw new InvalidOperationException("Operation is not supported.");
                }

                result_num.Text = result.Top.ToString();
                result_den.Text = result.Bottom.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Text_b_keypress(object sender,KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true;

            }
        }

        /*
        * Fraction class supplies the underlying logic to 
        * drive this application. A better design might be
        *to have this in a separate file or as a library.
        */
        public class Fraction:Form1
        {
            public int Top { get; }
            public int Bottom { get; }
            public Fraction(int top=0,int bottom=1)
            {
               
                    if (bottom == 0)
                        throw new ArgumentException("Denominator cannot be zero.");
                    Top = top;
                    Bottom = bottom;
            }


            /**
            * This constructor takes two optional int
            * arguments and assigns them to the 
            * appropriate properties
            */
            //public Fraction(int top = 0, int bottom = 1)
            //=> (Top, Bottom) = (top, bottom);
            
            public Fraction(string top, string bottom)
            {
                if (!int.TryParse(top, out int parsedTop) || !int.TryParse(bottom, out int parsedBottom))
                    throw new ArgumentException("Invalid input. Please provide integers.");

                if (parsedBottom == 0)
                    throw new ArgumentException("Denominator cannot be zero.");

                Top = parsedTop;
                Bottom = parsedBottom;

            }
            /**
            * Add another constructor that takes two optional string
            * arguments and assigns them to the appropriate
            * properties (of course after conversion).
            */
            public static Fraction operator +(Fraction lhs, Fraction rhs)
            => new Fraction(lhs.Top * rhs.Bottom + rhs.Top * lhs.Bottom, lhs.Bottom * rhs.Bottom).Simplify();
            public static Fraction operator -(Fraction lhs, Fraction rhs)
            => new Fraction(lhs.Top * rhs.Bottom - rhs.Top * lhs.Bottom, lhs.Bottom * rhs.Bottom).Simplify();
            public static Fraction operator *(Fraction lhs, Fraction rhs)
            {
                int top = lhs.Top * rhs.Top;
                int bottom = lhs.Bottom * rhs.Bottom;
                return new Fraction(top, bottom).Simplify();
            }

            public Fraction Simplify()
            {
                int gcd = GCD(Top, Bottom);
                return new Fraction(Top / gcd, Bottom / gcd);
            }

            private int GCD(int a, int b)
            {
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                return Math.Abs(a);
            }
            public static Fraction operator /(Fraction lhs, Fraction rhs)
            {
                if (rhs.Top == 0)
                    throw new DivideByZeroException("Cannot divide by a fraction with a numerator of zero.");

                int top = lhs.Top * rhs.Bottom;
                int bottom = lhs.Bottom * rhs.Top;
                return new Fraction(top, bottom).Simplify();
            }
            /**
            * Add two more methods that overloads the arithmetic 
            * operators multiply and divide arithmetic.
            */

           
            public override string ToString()
             => $"[{Top}, {Bottom}]";
            /**
            * This Deconstructor allows you to get both properties
            * with a single statement.
            */
            public void Deconstruct(out string top, out string bottom)
            => (top, bottom) = ($"{Top}", $"{Bottom}");

        }
    }
}
