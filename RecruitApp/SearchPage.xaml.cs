using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace RecruitApp
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class SearchPage : RecruitApp.Common.LayoutAwarePage
    {
        public SearchPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        protected override void SaveState(Dictionary<String, Object> pageState)
        {
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string leeftijd = Leeftijd.SelectedItem as string;
            string online = Online.SelectedItem as string;
            string geslacht = Geslacht.SelectedItem as string;
            string bedrijfsomvang = Bedrijfsomvang.SelectedItem as string;

            StringBuilder sB = new StringBuilder();

            if(leeftijd != null && !leeftijd.Equals("Onbekend"))
            {
                if (leeftijd == "Jong (t/m 35 jaar)")
                {
                    sB.Append("Recruiters in de leeftijdscategorie onder de 35 jaar halen informatie over sollicitanten voor het grootste deel van Linkedin. Zij vinden Twitter als medium voor informatie het minst geschikt.");               
                }
                if (leeftijd == "Oud (35 jaar en ouder)")
                {
                    sB.Append("Recruiters in de leeftijdscategorie ouder dan 35 jaar halen informatie over sollicitanten voor het grootste deel van Linkedin. Zij vinden Facebook het minst geschikt voor informatie vergaring over sollicitanten.");  
                }
                 sB.AppendLine();
                 sB.AppendLine();
            }

            if (geslacht != null && !geslacht.Equals("Onbekend"))
            {
                if (geslacht == "Man")
                {
                    sB.Append("Mannelijke recruiters zoeken voornamelijk informatie over sollicitanten op Twitter, Facebook en Linkedin. Google+ achten zij minder geschikt voor zoeken naar achtergrond informatie.");
                }
                if (geslacht == "Vrouw")
                {
                    sB.Append("Vrouwelijke recruiters zoeken voornamelijk informatie over sollicitanten op Twitter, Facebook en Linkedin. Google+ achten zij minder geschikt voor zoeken naar achtergrond informatie.");
                }
                sB.AppendLine();
                sB.AppendLine();
            }

            if (bedrijfsomvang != null && !bedrijfsomvang.Equals("Onbekend"))
            {
                if (bedrijfsomvang == "Minder dan 250")
                {
                    sB.Append("Recruiters werkzaam voor bedrijven met minder dan 250 medewerkers zoeken voornamelijk op Linkedin en significant minder op Google+.");
                }
                if (bedrijfsomvang == "Meer dan 250")
                {
                    sB.Append("Recruiters werkzaam voor bedrijven met meer dan 250 medewerkers zoeken voornamelijk op Linkedin en significant minder op Google+.");
                }
                sB.AppendLine();
                sB.AppendLine();
            }

            if (online != null && !online.Equals("Onbekend"))
            {
                if (online == "Facebook")
                {
                    sB.Append("Recruiters worden op Facebook het meest beїnvloed door berichten geplaatst door anderen.");
                }
                if (online == "Twitter")
                {
                    sB.Append("Recruiters worden op Twitter het meest beїnvloed door de tweets geplaatst door de profielhouder zelf en het aantal followers.");
                }
                if (online == "Google+")
                {
                    sB.Append("Recruiters worden op Google+ het meest beїnvloed door de profielfoto en het aantal '+1's van de profielhouder zelf.");
                }
                if (online == "Linkedin")
                {
                    sB.Append("Recruiters worden op Linkedin het meest beїnvloed door de aanbevelingen van connecties van de profielhouder.");
                }
                sB.AppendLine();
                sB.AppendLine();
            }

            Content.Text = sB.ToString();
        }
    }
}
