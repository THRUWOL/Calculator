using System.Windows;

namespace Calculator
{
    /// <summary>
    /// interaction logic for mainwindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Panel.Content = new Standart();
        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
        private void Window_MouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            this.DragMove();
        }

        private void Standart_Click(object sender, RoutedEventArgs e)
        {
            Panel.Content = new Standart();
        }
        private void Scientific_Click(object sender, RoutedEventArgs e)
        {
            Panel.Content = new Scientific();
        }

        private void CloseProgramm(object sender, RoutedEventArgs e)
        {
            UserAnswer userAnswer = new UserAnswer();
            userAnswer.ShowDialog();
        }

        private void Weight_Click(object sender, RoutedEventArgs e)
        {
            Panel.Content = new Weight();
        }

        private void Minimized(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Panel_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }
    }
}
