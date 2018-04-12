using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Assignment5
{
    /// <summary>
    /// Interaction logic for FlightWindow.xaml
    /// </summary>
    public partial class FlightWindow : Window
    {
        private readonly string _flightName;
        private bool _isFlying;
        public event EventHandler<FlightEventArgsMain> FlightChanged;

        public FlightWindow(string flightName)
        {
            _flightName = flightName;
            _isFlying = false;
            InitializeComponent();
            InitializeGui();

        }

        private void InitializeGui()
        {
            Title = $"Flight {_flightName}";
            var uri = new Uri(@"/icons/" + Airline(_flightName), UriKind.Relative);
            logo.Source = new BitmapImage(uri);
            UpdateGui();
            Show();
        }

        private void UpdateGui()
        {
            direction.IsEnabled = _isFlying;
            Land.IsEnabled = _isFlying;
            Start.IsEnabled = !_isFlying;
        }

        /// <summary>
        /// Convert a flight code to an airline logo filename, 
        /// by looking at the first two characters of the flight code.
        /// </summary>
        /// <param name="code">flight code</param>
        /// <returns>file name of logo file (not including containing path)</returns>
        private string Airline(string code)
        {
            // https://en.wikipedia.org/wiki/List_of_airline_codes
            // DL Delta
            // KL KLM
            // DY Norwegian
            // QR Qatar
            // SQ Singapore

            code = code.ToUpper() + "  "; // Ensure string is at least two characters long.
            switch (code.Substring(0, 2))
            {
                case "DL":
                    return @"delta.png";
                case "KL":
                    return @"klm.png";
                case "DY":
                    return @"norwegian.png";
                case "QR":
                    return @"qatar.jpeg";
                case "SQ":
                    return @"singapore.png";
                default:
                    return @"question-128sq.png";
            }
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            _isFlying = true;
            UpdateGui();
            OnFlightChanged("Starting");
        }

        private void OnFlightChanged(string flightAction)
        {
            FlightChanged?.Invoke(this, new FlightEventArgsMain()
            {
                FlightNo = _flightName,
                FlightAction = flightAction,
                DateTime = DateTime.Now
            });
        }

        private void Land_Click(object sender, RoutedEventArgs e)
        {
            _isFlying = false;
            UpdateGui();
            OnFlightChanged("Landed");
            Close();
        }

        private void direction_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var newDirection = direction.SelectedItem.ToString();
            UpdateGui();
            OnFlightChanged($"Changed route: {newDirection}");
        }
    }
}
