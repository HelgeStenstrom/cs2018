// Helge Stenström 
// ah7875
// C# del II 2018

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
        public event EventHandler<FlightEventArgs> FlightChanged;
        public event EventHandler<FlightEventArgs> StartedOrLanded;

        /// <summary>
        /// Constructor. Set up the flightWindow object.
        /// </summary>
        /// <param name="flightName"></param>
        public FlightWindow(string flightName)
        {
            _flightName = flightName;
            _isFlying = false;
            InitializeComponent();
            InitializeGui();

        }

        /// <summary>
        /// Initialize the GUI. Set the window title. 
        /// Set a logo, based on the flight number.
        /// </summary>
        private void InitializeGui()
        {
            Title = $"Flight {_flightName}";
            var uri = new Uri(@"/icons/" + Airline(_flightName), UriKind.Relative);
            logo.Source = new BitmapImage(uri);
            UpdateGui();
            Show();
        }

        /// <summary>
        /// Update the GUI.
        /// The buttons are enabled or disabled, based on if the plane is flying or not.
        /// </summary>
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

        /// <summary>
        /// Called when Start is clicked.
        /// Set the plane as flying. Send events.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            _isFlying = true;
            UpdateGui();
            OnStartedOrLanded("Starting");
        }

        /// <summary>
        /// Event when the route is changed.
        /// </summary>
        /// <param name="flightAction"></param>
        private void OnRouteChanged(string flightAction)
        {
            FlightChanged?.Invoke(this, new FlightEventArgs()
            {
                FlightNo = _flightName,
                FlightAction = flightAction,
                DateTime = DateTime.Now
            });
        }

        /// <summary>
        /// Event when the plane is started or landed.
        /// </summary>
        /// <param name="flightAction"></param>
        private void OnStartedOrLanded(string flightAction)
        {
            StartedOrLanded?.Invoke(this, new FlightEventArgs()
            {
                FlightNo = _flightName,
                FlightAction = flightAction,
                DateTime = DateTime.Now
            });
        }

        /// <summary>
        /// Called when Land is clicked. Send an event and close the window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Land_Click(object sender, RoutedEventArgs e)
        {
            _isFlying = false;
            UpdateGui();
            OnStartedOrLanded("Landed");
            Close();
        }

        /// <summary>
        /// Called when the direction is changed, by the combo box is used.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void direction_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var newDirection = direction.SelectedItem.ToString();
            UpdateGui();
            OnRouteChanged($"Changed route: {newDirection}");
        }
    }
}
