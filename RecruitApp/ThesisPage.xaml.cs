using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
    public sealed partial class ThesisPage : RecruitApp.Common.LayoutAwarePage
    {
        public ThesisPage()
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

        private void TextBlock_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            TextBlock txtBlock = sender as TextBlock;
            Title.Text = txtBlock.Text;

            //load the contents
            switch (txtBlock.Text)
            {
                case "Onderzoeksvraag":
                    Content.Text = "De onderzoeksvraag van dit onderzoek is: Wat zijn de kenmerken van recruiters die online screenen en wat voor invloed heeft online screenen en online informatie op de uitkomst van een sollicitatie? Online screening is een vorm van referenties natrekken door werkgevers/recruiters over een sollicitant via een digitaal medium zoals een sociaal netwerk. Om de onderzoeksvraag te beantwoorden is een survey onder 100 respondenten afgenomen. Door de afgenomen survey is duidelijker geworden wat de eigenschappen van de werkgevers/recruiters voor invloed uitoefenen op de uiteindelijke waargenomen geschiktheid van een potentiële kandidaat.";
                    break;
                case "Probleemstelling":
                    Content.Text = "De probleemstelling die centraal staat in dit onderzoek is: Hoe vindt online screening anno 2013 plaats? Online recruitment en het gebruik van social media spelen een grote rol in de nieuwsbulletins. Om de probleemstelling te beantwoorden is er gebruik gemaakt van algemene theorie over Sociale media en Recruitment en het Warranting Principle (Walther en Parks, 2002). Dit principe geeft dat informatie verschaft door derden (other generated informatie) als meer betrouwbaar wordt gezien dan informatie uit de eerste hand.  De vraag die hierbij centraal stond is of de diverse onderdelen van sociale netwerken (self- en other generated) van invloed zijn op de waargenomen geschiktheid van een potentiele sollicitant.";
                    break;
                case "Onderzoek":
                    Content.Text = "Het onderzoek heeft plaatsgevonden door middel van een digitale survey. Deze surveys zijn via sociale media verspreid onder 112 respondenten. Uiteindelijk zijn hier 98 bruikbare respondenten uit voort gekomen. De steekproef bestond uit mannen en vrouwen met een gemiddelde leeftijd tussen 31 en 35 jaar. De respondenten zijn woonachtig door heel Nederland, waarbij de provincies Utrecht, Noord-Holland en Zuid-Holland de meeste proefpersonen heeft voortgebracht.";
                    break;
                case "Conclusie":
                    Content.Text = "De algemene conclusie die voortvloeit uit dit onderzoek is dat het Warranting Principle niet volledig wordt ondersteund. Wanneer het gaat om informatie van derden op Facebook, wordt de potentiële kandidaat slechter beoordeeld en wordt het Warranting Principle dus niet ondersteund. Bij de overige netwerken zijn er geen significante verschillen aangetroffen en kan er dus niet met zekerheid gezegd worden of self- of othergenerated informatie een grotere invloed heeft. Daarnaast is gebleken in deze steekproef dat er vrijwel altijd gebruik gemaakt wordt van sociale media tijdens de online screening, en geeft 58.6 % van de respondenten aan zich te laten beïnvloeden door sociale media. De resultaten ondersteunen dit. Er zijn namelijk vaak kleine verschillen aangetoond tussen diverse eigenschappen van de respondenten. Een algemene verklaring hiervoor kan zijn dat sociale media een zodanig grote rol spelen in het dagelijks leven, dat zelfs diegene die objectief moeten blijven, zich laten beïnvloeden door de informatie op sociale media.\r\n\r\nVerder zijn er verschillen aangetroffen tussen de vestigingslocatie van een bedrijf en de woonplaats van de respondent. De verwachting was dat de uitkomsten met betrekking tot de voorkeur naar het zoeken van informatie gelijk zou zijn. De analyse gaf aan dat dit, wat vestiginslocatie betreft, enkel geldt voor Twitter en Linkedin en voor wat de woonplaats betreft wordt de hypothese niet ondersteund. Tevens is er aanleiding gevonden voor een verschuiving van het belang van opleidingsniveau naar de indruk van iemands persoonlijkheid. De negatieve versies van de survey scoorden namelijk beter dan de positieve versies.";
                    break;
                case "Implicaties":
                    Content.Text = "Werkgevers kunnen dankzij dit onderzoek hun eigen gedrag onder de loep leggen en bekijken of zij zich ook laten leiden door sociale netwerken, terwijl er verwacht wordt dat zij objectief zijn. Daarnaast is wetenschappelijk bewezen dat de steekproef uit dit onderzoek de negatieve foto’s, waarop sollicitanten bijvoorbeeld met alcohol afgebeeld waren, beter beoordeelden dan de positieve foto’s. Hiermee lijkt de persoonlijkheid van de sollicitant voorop te staan, waar voorheen een perfecte eerste indruk belangrijker leek te zijn. Starters op de arbeidsmarkt kunnen de analyse met betrekking tot de kenmerken van de respondenten raadplegen in de RecruitApp en zodoende deze uitkomsten inzetten om hun de onderdelen van hun sociale netwerken te optimaliseren voor betere kansen op de arbeidsmarkt.";
                    break;
            }

        }
    }
}
