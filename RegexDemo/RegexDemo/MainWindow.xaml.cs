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
    }
}
