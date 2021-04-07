using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for Programmer.xaml
    /// </summary>

    public partial class Standart : Page
    {
        public Standart()
        {
            InitializeComponent();
        }
        //Проверка окна вывода на наличие лишних символов
        private bool check_output(string output)
        {
            if (TextOutput.Text.Length != 0 &&
                TextOutput.Text[TextOutput.Text.Length - 1] != '+' &&
                TextOutput.Text[TextOutput.Text.Length - 1] != '-' &&
                TextOutput.Text[TextOutput.Text.Length - 1] != '*' &&
                TextOutput.Text[TextOutput.Text.Length - 1] != '/') return true;
            else return false;
        }
        /*ОЧИСТКА ПОЛЕЙ*/
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
        //Очистка поля вывода и поля истории
        private void btn_clear_all_Click(object sender, RoutedEventArgs e)
        {
            TextOutput.Clear();
            TextHistory.Text = "";
        }
        //Очистка поля истории операций
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
        private void btn_0_Click_1(object sender, RoutedEventArgs e) => TextOutput.Text += "0";

        /*ВВОД ОПЕРАЦИЙ*/
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
        //возведение в квадрат
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (check_output(TextOutput.Text)) TextOutput.Text += "^2";
        }
        //отделение целой части от дробной (точечка)
        private void btn_dot_Click(object sender, RoutedEventArgs e)
        {
            TextOutput.Text += "."; //проблемная зона
        }

        /*ВЫВОД РЕШЕНИЯ*/

        //Вывод решения на экран (используется обратная польская запись)
        private void btn_equal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (check_output(TextOutput.Text))
                {
                    TextHistory.Text += TextOutput.Text + "=";
                    double result = Math.Round(RPN.Calculate(TextOutput.Text), 10);
                    TextOutput.Text = Convert.ToString(result);
                    TextHistory.Text += TextOutput.Text + "\n";
                }
                //Удаляется лишний символ в конце выражения для вывода решения
                else if (TextOutput.Text.Length != 0)
                {
                    TextOutput.Text = TextOutput.Text.Remove(TextOutput.Text.Length - 1);
                    TextHistory.Text += TextOutput.Text + "=";
                    double result = Math.Round(RPN.Calculate(TextOutput.Text), 10);
                    TextOutput.Text = Convert.ToString(result);
                    TextHistory.Text += TextOutput.Text + "\n";
                }
            }
            catch (MyException ex) { TextOutput.Text = ex.type; }
        }

    }

}
