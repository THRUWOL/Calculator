using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for Scientific.xaml
    /// </summary>
    public partial class Scientific : Page
    {
        public Scientific()
        {
            InitializeComponent();
        }
        int left = 0,
            right = 0;

        /*ПРОВЕРКА ОКНА ВЫВОДА*/
        private bool check_output(string output)
        {
            if (TextOutput.Text.Length != 0 &&
                TextOutput.Text[TextOutput.Text.Length - 1] != '+' &&
                TextOutput.Text[TextOutput.Text.Length - 1] != '-' &&
                TextOutput.Text[TextOutput.Text.Length - 1] != '*' &&
                TextOutput.Text[TextOutput.Text.Length - 1] != '/' &&
                TextOutput.Text[TextOutput.Text.Length - 1] != '^' &&
                TextOutput.Text[TextOutput.Text.Length - 1] != '%' &&
                TextOutput.Text[TextOutput.Text.Length - 1] != '(' &&
                TextOutput.Text[TextOutput.Text.Length - 1] != '!') return true;
            else return false;
        }
        private bool check_number(string output)
        {
            if( TextOutput.Text.Length != 0 &&
                TextOutput.Text[TextOutput.Text.Length - 1] != '0' &&
                TextOutput.Text[TextOutput.Text.Length - 1] != '1' &&
                TextOutput.Text[TextOutput.Text.Length - 1] != '2' &&
                TextOutput.Text[TextOutput.Text.Length - 1] != '3' &&
                TextOutput.Text[TextOutput.Text.Length - 1] != '4' &&
                TextOutput.Text[TextOutput.Text.Length - 1] != '5' &&
                TextOutput.Text[TextOutput.Text.Length - 1] != '6' &&
                TextOutput.Text[TextOutput.Text.Length - 1] != '7' &&
                TextOutput.Text[TextOutput.Text.Length - 1] != '8' &&
                TextOutput.Text[TextOutput.Text.Length - 1] != '9') return true;
            else return false;
        }

        /*ОЧИСТКА*/
        //Очистка всего поля
        private void btn_clear_Click(object sender, RoutedEventArgs e)
        {
            TextOutput.Clear();
        }
        //Очистка последнего символа
        private void btn_DEL_Click(object sender, RoutedEventArgs e)
        {
            if (TextOutput.Text.Length != 0)
            {
                TextOutput.Text = TextOutput.Text.Remove(TextOutput.Text.Length - 1);
            }
            else
                TextOutput.Text = TextOutput.Text.Insert(TextOutput.Text.Length, "");
        }
        //Очистка истории
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextHistory.Text = "";
        }

        /*ВВОД ЦИФР*/
        private void btn_1_Click(object sender, RoutedEventArgs e) => TextOutput.Text += "1";
        private void btn_2_Click(object sender, RoutedEventArgs e) => TextOutput.Text += "2";
        private void btn_3_Click(object sender, RoutedEventArgs e) => TextOutput.Text += "3";
        private void btn_4_Click(object sender, RoutedEventArgs e) => TextOutput.Text += "4";
        private void btn_5_Click(object sender, RoutedEventArgs e) => TextOutput.Text += "5";
        private void btn_6_Click(object sender, RoutedEventArgs e) => TextOutput.Text += "6";
        private void btn_7_Click(object sender, RoutedEventArgs e) => TextOutput.Text += "7";
        private void btn_8_Click(object sender, RoutedEventArgs e) => TextOutput.Text += "8";
        private void btn_9_Click(object sender, RoutedEventArgs e) => TextOutput.Text += "9";
        private void btn_0_Click(object sender, RoutedEventArgs e) => TextOutput.Text += "0";

        /*ВВОД СИМФОЛОВ*/
        private void btn_left_Click(object sender, RoutedEventArgs e)
        {
            TextOutput.Text += "(";
            left += 1;
        }

        private void btn_right_Click(object sender, RoutedEventArgs e)
        {
            if (left != 0 && left > right)
            {
                TextOutput.Text += ")";
                right += 1;
            }
        }

        private void btn_minus_Click(object sender, RoutedEventArgs e)
        {
            TextOutput.Text += "-";
        }

        private void btn_divide_Click(object sender, RoutedEventArgs e)
        {
            if (check_output(TextOutput.Text)) TextOutput.Text += "/";
        }

        private void btn_multiply_Click(object sender, RoutedEventArgs e)
        {
            if (check_output(TextOutput.Text)) TextOutput.Text += "*";
        }
        private void btn_plus_Click(object sender, RoutedEventArgs e)
        {
            if (check_output(TextOutput.Text)) TextOutput.Text += "+";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //ln
            if (TextOutput.Text.Length == 0)
            {
                left += 1;
                TextOutput.Text += "ln(";
            }
            else if (check_number(TextOutput.Text))
            {
                left += 1;
                TextOutput.Text += "ln(";
            }
        }
        private void btn_sqrt_Copy_Click(object sender, RoutedEventArgs e)
        {
            //число E
            TextOutput.Text += "2.71828182845905"; //проблемная зона
        }

        private void btn_pi_Click(object sender, RoutedEventArgs e)
        {
            //число пи
            TextOutput.Text += "3.14159265358979"; //проблемная зона
        }

        private void btn_log1_Click(object sender, RoutedEventArgs e)
        {
            //log
            if (TextOutput.Text.Length == 0)
            {
                left += 1;
                TextOutput.Text += "lg(";
            }
            else if (check_number(TextOutput.Text))
            {
                left += 1;
                TextOutput.Text += "lg(";
            }
        }

        private void btn_arg_Click(object sender, RoutedEventArgs e)
        {
            //atg
            if (TextOutput.Text.Length == 0)
            {
                left += 1;
                TextOutput.Text += "atg(";
            }
            else if (check_number(TextOutput.Text))
            {
                left += 1;
                TextOutput.Text += "atg(";
            }
        }

        private void btn_acos_Click(object sender, RoutedEventArgs e)
        {
            //acos
            if (TextOutput.Text.Length == 0)
            {
                left += 1;
                TextOutput.Text += "acos(";
            }
            else if (check_number(TextOutput.Text))
            {
                left += 1;
                TextOutput.Text += "acos(";
            }
        }

        private void btn_asin_Click(object sender, RoutedEventArgs e)
        {
            //asin
            if (TextOutput.Text.Length == 0)
            {
                left += 1;
                TextOutput.Text += "asin(";
            }
            else if (check_number(TextOutput.Text))
            {
                left += 1;
                TextOutput.Text += "asin(";
            }
        }

        private void btn_tg_Click(object sender, RoutedEventArgs e)
        {
            //tg
            if (TextOutput.Text.Length == 0)
            {
                left += 1;
                TextOutput.Text += "tg(";
            }
            else if (check_number(TextOutput.Text))
            {
                left += 1;
                TextOutput.Text += "tg(";
            }
        }

        private void btn_cos_Click(object sender, RoutedEventArgs e)
        {
            //cos
            if (TextOutput.Text.Length == 0)
            {
                left += 1;
                TextOutput.Text += "cos(";
            }
            else if (check_number(TextOutput.Text))
            {
                left += 1;
                TextOutput.Text += "cos(";
            }
        }

        private void btn_sin_Click(object sender, RoutedEventArgs e)
        {
            //sin
            if (TextOutput.Text.Length == 0)
            {
                left += 1;
                TextOutput.Text += "sin(";
            }
            else if (check_number(TextOutput.Text))
            {
                left += 1;
                TextOutput.Text += "sin(";
            }
        }

        private void btn_percent_Click(object sender, RoutedEventArgs e)
        {
            //процент
            TextOutput.Text += "%";
        }

        private void btn_1_x_Click(object sender, RoutedEventArgs e)
        {
            //1/x
            if (TextOutput.Text.Length == 0) TextOutput.Text += "1/";
            else if (check_number(TextOutput.Text)) TextOutput.Text += "1/";
        }

        private void btn_x2_Click(object sender, RoutedEventArgs e)
        {
            //x^2
            TextOutput.Text += "^2";
        }

        private void btn_xy_Click(object sender, RoutedEventArgs e)
        {
            //x^y
            TextOutput.Text += "^";
        }

        private void btn_sqrt_Click(object sender, RoutedEventArgs e)
        {
            //sqrt
            if (TextOutput.Text.Length == 0)
            {
                left += 1;
                TextOutput.Text += "sqrt(";
            }
            else if (check_number(TextOutput.Text))
            {
                left += 1;
                TextOutput.Text += "sqrt(";
            }
        }

        private void btn_n__Click(object sender, RoutedEventArgs e)
        {
            //факториал
            TextOutput.Text += "!";
        }

        private void btn_dot_Click(object sender, RoutedEventArgs e)
        {
            if (check_output(TextOutput.Text)) TextOutput.Text += ".";
        }

        /*РЕШЕНИЕ ВЫРАЖЕНИЯ + ВЫВОД*/
        private void btn_equal_Click(object sender, RoutedEventArgs e)
        {
            left = 0; right = 0;
            try
            {
                if (check_output(TextOutput.Text))
                {
                    TextHistory.Text += TextOutput.Text + "=";
                    double result = RPN.Calculate(TextOutput.Text);
                    TextOutput.Text = Convert.ToString(result);
                    TextHistory.Text += TextOutput.Text + "\n";
                }
                else if (TextOutput.Text.Length != 0)
                {
                    TextOutput.Text = TextOutput.Text.Remove(TextOutput.Text.Length - 1);
                    TextHistory.Text += TextOutput.Text + "=";
                    double result = RPN.Calculate(TextOutput.Text);
                    TextOutput.Text = Convert.ToString(result);
                    TextHistory.Text += TextOutput.Text + "\n";
                }
            }
            catch (MyException ex) { TextOutput.Text = ex.type; }
        }
    }

}
