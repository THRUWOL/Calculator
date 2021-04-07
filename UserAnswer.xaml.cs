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
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for UserAnswer.xaml
    /// </summary>
    public partial class UserAnswer : Window
    {
        public UserAnswer()
        {
            InitializeComponent();
        }
        private void Window_MouseButtonDown(object sender, RoutedEventArgs e)
        {
            this.DragMove();
        }

        private void Yes_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void No_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
