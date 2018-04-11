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

namespace Assignment5
{
    /// <summary>
    /// Interaction logic for FlightWindow.xaml
    /// </summary>
    public partial class FlightWindow : Window
    {
        private string flightName;
        public FlightWindow(string flightName)
        {
            this.flightName = flightName;
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            this.Title = $"Flight {flightName}";
            Uri uri;
            uri = new Uri(@"/icons/qatar.jpeg", UriKind.Relative);
            uri = new Uri(@"/icons/klm.png", UriKind.Relative);
            //var x = this.logo.Source.
           this.logo.Source = new BitmapImage(uri);
            //throw new NotImplementedException();
        }

        // TODO: Disable rutt och Land
        // TODO: Visa logga

        private string airline(string code)
        {
	    // https://en.wikipedia.org/wiki/List_of_airline_codes
            // DL Delta
            // KL KLM
            // DY Norwegian
            // QR Qatar
            // SQ Singapore
            return "";
        }
    }
}
