using System.Windows;

namespace RegexDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Example1_Click(object sender, RoutedEventArgs e)
        {
            Example1 example1 = new Example1();
            example1.Show();
        }

        private void Example2_Click(object sender, RoutedEventArgs e)
        {
            Example2 example2 = new Example2();
            example2.Show();
        }

        private void Sair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
