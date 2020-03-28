using System.Net;
using System.Text.RegularExpressions;
using System.Windows;

namespace RegexDemo
{
    /// <summary>
    /// Interaction logic for Example2.xaml
    /// </summary>
    public partial class Example2 : Window
    {
        public Example2()
        {
            InitializeComponent();
        }

        private void Match_Click(object sender, RoutedEventArgs e)
        {
            WebClient webClient = new WebClient();
            var fonte = webClient.DownloadString("https://github.com/openfootball/england/blob/master/2019-20/1-premierleague.txt");

            var rgxMatch = new Regex(@"(Mat[a-z]+\s\d+)");

            var match = rgxMatch.Matches(fonte);

            for (int i = 0; i < match.Count; i++)
            {
                dgData.Items.Add(new Match() { Matchday = match[i].Value.Replace("[", "") });
            }
        }

        public class Match
        {
            public string Matchday { get; set; }

        }
    }
}
