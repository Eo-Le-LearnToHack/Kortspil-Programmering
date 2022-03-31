using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Kortspil
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// 
    /// Kortene er hentet fra https://acbl.mybigcommerce.com/52-playing-cards/
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int kortnummer = Convert.ToInt32(Kort.Text);
            string filnavn = FindBillede(kortnummer);
            string url = $"/Billeder/{filnavn}";
            Uri uri = new (url, UriKind.Relative);
            BitmapImage image = new(uri);
           
            Billede.Source = image;
            
        }

        private string FindBillede(int kortnummer)
        {
			// string resultat = "2-Spar.jpg";

			// Skriv din løsning her...
			// Test first commitment after fork "https://github.com/SmartLearning-Org/Kortspil-Programmering" and clone respository to local PC

			int cardNum = Convert.ToInt32(Kort.Text);
			string cardValue = cardNum.ToString();
			string cardColor = "Spar.jpg";
			string resultat = $"{cardNum}-{cardColor}";
		
			if (cardNum >= 1 && cardNum <= 13)
			{
				switch (cardNum)
				{
					case (1):
						cardValue = "Es";
						resultat = $"{cardValue}-{cardColor}";
						return resultat;
					case (13):
						cardValue = "Konge";
						resultat = $"{cardValue}-{cardColor}";
						return resultat;
					case (12):
						cardValue = "Dame";
						resultat = $"{cardValue}-{cardColor}";
						return resultat;
					case (11):
						cardValue = "Knægt";
						resultat = $"{cardValue}-{cardColor}";
						return resultat;
					default:
						resultat = $"{cardNum}-{cardColor}";
						return resultat;
				}
			}
			else if (cardNum >= 14 && cardNum <= 26)
			{
				cardColor = "Ruder.jpg";
				switch (cardNum)
				{
					case (14):
						cardValue = "Es";
						resultat = $"{cardValue}-{cardColor}";
						return resultat;
					case (26):
						cardValue = "Konge";
						resultat = $"{cardValue}-{cardColor}";
						return resultat;
					case (25):
						cardValue = "Dame";
						resultat = $"{cardValue}-{cardColor}";
						return resultat;
					case (24):
						cardValue = "Knægt";
						resultat = $"{cardValue}-{cardColor}";
						return resultat;
					default:
						resultat = $"{cardNum-13}-{cardColor}";
						return resultat;
				}
			}
			else if (cardNum >= 27 && cardNum <= 39)
			{
				cardColor = "Klør.jpg";
				switch (cardNum)
				{
					case (27):
						cardValue = "Es";
						resultat = $"{cardValue}-{cardColor}";
						return resultat;
					case (39):
						cardValue = "Konge";
						resultat = $"{cardValue}-{cardColor}";
						return resultat;
					case (38):
						cardValue = "Dame";
						resultat = $"{cardValue}-{cardColor}";
						return resultat;
					case (37):
						cardValue = "Knægt";
						resultat = $"{cardValue}-{cardColor}";
						return resultat;
					default:
						resultat = $"{cardNum-26}-{cardColor}";
						return resultat;
				}
			}
			else if (cardNum >= 40 && cardNum <= 52)
			{
				cardColor = "Hjerter.jpg";
				switch (cardNum)
				{
					case (40):
						cardValue = "Es";
						resultat = $"{cardValue}-{cardColor}";
						return resultat;
					case (52):
						cardValue = "Konge";
						resultat = $"{cardValue}-{cardColor}";
						return resultat;
					case (51):
						cardValue = "Dame";
						resultat = $"{cardValue}-{cardColor}";
						return resultat;
					case (50):
						cardValue = "Knægt";
						resultat = $"{cardValue}-{cardColor}";
						return resultat;
					default:
						resultat = $"{cardNum-39}-{cardColor}";
						return resultat;
				}
            }
			else
			{
						resultat = "purple_back.jpg";
						Kort.Text = "Kun tal mellem 1-52";
			}

			return resultat;
        }
    }
}
