using System.Net;
using System.Text.RegularExpressions;
using System.Windows;

namespace RegexDemo
{
    /// <summary>
    /// Interaction logic for Example1.xaml
    /// </summary>
    public partial class Example1 : Window
    {
        public Example1()
        {
            InitializeComponent();
        }

        private void Match_Click(object sender, RoutedEventArgs e)
        {
            WebClient webClient = new WebClient();
            var fonte = webClient.DownloadString("https://github.com/openfootball/england/blob/master/2019-20/1-premierleague.txt");

            var rgxDiaSemana = new Regex(@"\[([a-zA-z]){3}");
            var rgxMesDia = new Regex(@"([A-Za-z]{3}\/\d{0,2}\])");

            var semanaMatch = rgxDiaSemana.Matches(fonte);
            var mesMatch = rgxMesDia.Matches(fonte);

            for (int i = 0; i < semanaMatch.Count; i++)
            {
                dgData.Items.Add(new Data() { DiaSemana = semanaMatch[i].Value.Replace("[",""), MesDia = mesMatch[i].Value.Replace("]","")});
            }
        }

        public class Data
        {
            public string DiaSemana { get; set; }

            public string MesDia { get; set; }

        }
    }
}
