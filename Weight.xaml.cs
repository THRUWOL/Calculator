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
    /// Interaction logic for Weight.xaml
    /// </summary>
    public partial class Weight : Page
    {
        public Weight()
        {
            InitializeComponent();
        }

        private string BMI(double result)
        {
            if (result < 16) return "Ваш индекс массы тела: " + result + "\nВыраженный дефицит массы тела";
            else if (result < 18.5 && result >= 16) return "Ваш индекс массы тела: " + result + "\nНедостаточная масса тела";
            else if(result < 25 && result >= 18.5) return "Ваш индекс массы тела: " + result + "\nНормальная масса тела";
            else if(result < 30 && result >= 25) return "Ваш индекс массы тела: " + result + "\nИзбыточная масса тела (предожирение)";
            else if(result < 35 && result >= 30) return "Ваш индекс массы тела: " + result + "\nОжирение 1-ой степени";
            else if(result < 40 && result >= 35) return "Ваш индекс массы тела: " + result + "\nОжирение 2-ой степени";
            else if(result > 40) return "Ваш индекс массы тела: " + result + "\nОжирение 3-ей степени";
            else return "Ошибка вычислений. \nНе удалось расчитать ваш индекс массы тела ＞﹏＜";
                
        }
        private bool W_H(string content)
        {
            if (content == "H") return true;
            else return false;
        }

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            if (W_H(WH_text.Text))
            {
                HeigthOutput.Text += '1';
            }
            else WeightOutput.Text += '1';
        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            if (W_H(WH_text.Text))
            {
                HeigthOutput.Text += '2';
            }
            else WeightOutput.Text += '2';
        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            if (W_H(WH_text.Text))
            {
                HeigthOutput.Text += '3';
            }
            else WeightOutput.Text += '3';
        }

        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            if (W_H(WH_text.Text))
            {
                HeigthOutput.Text += '4';
            }
            else WeightOutput.Text += '4';
        }

        private void btn_5_Click(object sender, RoutedEventArgs e)
        {
            if (W_H(WH_text.Text))
            {
                HeigthOutput.Text += '5';
            }
            else WeightOutput.Text += '5';
        }

        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            if (W_H(WH_text.Text))
            {
                HeigthOutput.Text += '6';
            }
            else WeightOutput.Text += '6';
        }

        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            if (W_H(WH_text.Text))
            {
                HeigthOutput.Text += '7';
            }
            else WeightOutput.Text += '7';
        }

        private void btn_8_Click(object sender, RoutedEventArgs e)
        {
            if (W_H(WH_text.Text))
            {
                HeigthOutput.Text += '8';
            }
            else WeightOutput.Text += '8';
        }

        private void btn_9_Click(object sender, RoutedEventArgs e)
        {
            if (W_H(WH_text.Text))
            {
                HeigthOutput.Text += '9';
            }
            else WeightOutput.Text += '9';
        }

        private void btn_0_Click_1(object sender, RoutedEventArgs e)
        {
            if (W_H(WH_text.Text))
            {
                 HeigthOutput.Text += '0';
            }
            else WeightOutput.Text += '0';
        }

        private void btn_dot_Click(object sender, RoutedEventArgs e)
        {
            if (W_H(WH_text.Text))
            {
                if (HeigthOutput.Text.Contains('.') == false &&
                    HeigthOutput.Text.Length != 0) HeigthOutput.Text += '.';
            }
            else 
            {
                if (WeightOutput.Text.Contains('.') == false &&
                    WeightOutput.Text.Length != 0) WeightOutput.Text += '.';
            } 
        }

        private void btn_clear_Click(object sender, RoutedEventArgs e)
        {
            if (W_H(WH_text.Text))
            {
                WH_text.Text = "W";
            }
            else WH_text.Text = "H";
        }

        private void btn_DEL_Click(object sender, RoutedEventArgs e)
        {
            if (W_H(WH_text.Text))
            {
                if (HeigthOutput.Text.Length != 0)
                {
                    HeigthOutput.Text = HeigthOutput.Text.Remove(HeigthOutput.Text.Length - 1);
                }
                else
                    HeigthOutput.Text = HeigthOutput.Text.Insert(HeigthOutput.Text.Length, "");
            }
            else if (W_H(WH_text.Text) != true) 
            {
                if (WeightOutput.Text.Length != 0)
                {
                    WeightOutput.Text = WeightOutput.Text.Remove(WeightOutput.Text.Length - 1);
                }
                else
                    WeightOutput.Text = WeightOutput.Text.Insert(WeightOutput.Text.Length, "");
            };
        }

        private void btn_percent_Click(object sender, RoutedEventArgs e)
        {
            HeigthOutput.Clear();
            WeightOutput.Clear();
        }

        private void btn_equal_Click(object sender, RoutedEventArgs e)
        {
            if (HeigthOutput.Text.Length !=0  && WeightOutput.Text.Length != 0) {
                double result;
                double h2;

                h2 = Convert.ToDouble(HeigthOutput.Text) * Convert.ToDouble(HeigthOutput.Text);

                result = Math.Round((Convert.ToDouble(WeightOutput.Text) / h2) * 10000, 2);
                ResultOutput.Content = BMI(result);
            }
            else
            {
                ErrorMessage errorMessage = new ErrorMessage();
                errorMessage.MessageLabel.Content = "Для расчёта ИМТ вы должны заполнить все поля.";
                errorMessage.ShowDialog();
            }
            
        }
    }
}
