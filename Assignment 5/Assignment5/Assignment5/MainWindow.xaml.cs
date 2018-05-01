// Helge Stenström 
// ah7875
// C# del II 2018

using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace Assignment5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Holds information for the ListView of flight actions
        /// </summary>
        private List<FlightEventArgs> flightItems = new List<FlightEventArgs>();

        /// <summary>
        /// Constructor.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            InitializeGui();
        }

        /// <summary>
        /// Initialize the GUI.
        /// Fill the flight action list with some example information until it is filled with real action.
        /// </summary>
        private void InitializeGui()
        {
            btnSend.IsEnabled = false;
            ValidateFlightButton();
            var items = new List<FlightEventArgs>();
            items.Add(new FlightEventArgs() {FlightNo="fl 1", FlightAction = "crach", DateTime = DateTime.Now });
            items.Add(new FlightEventArgs() { FlightNo = "FL 2", FlightAction = "crackle", DateTime = DateTime.Now });
            items.Add(new FlightEventArgs() { FlightNo = "FL 3", FlightAction = "pop", DateTime = DateTime.Now });
            Flights.ItemsSource = items;
        }

        /// <summary>
        /// Control the state (enabled or not) for the main window buttons.
        /// The flight number field must not be empty when a plane is to be sent
        /// to the runway.
        /// </summary>
        private void ValidateFlightButton()
        {
            var txt = txtFlightCode.Text;
            btnSend.IsEnabled = !(string.IsNullOrEmpty(txt));
        }

        /// <summary>
        /// Called when the Send button is clicked. 
        /// Create a subwindow for the given flight, and add listeners for its events.
        /// </summary>
        private void Button_Send_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Du klickade Sänd plan till starten");
            var flightName = txtFlightCode.Text;
            if (string.IsNullOrEmpty(flightName))
                throw new InvalidOperationException("flight code must not be empty when the Send button is clicked.");
            var flightWindow = new FlightWindow(flightName);
            flightWindow.FlightChanged_handlers += OnFlightChanged_handler;
            flightWindow.StartedOrLanded_handlers += OnFlightChanged_handler;
            flightWindow.StartedOrLanded_handlers += OnStartedOrLanded_handler;
        }

        /// <summary>
        /// Event handler for FlightChanged events
        /// </summary>
        /// <param name="sender">sender of the event</param>
        /// <param name="e">event arguments</param>
        private void OnFlightChanged_handler(object sender, FlightEventArgs e)
        {
            Console.Out.WriteLine($"{e.FlightNo}: {e.FlightAction}, {e.DateTime} ");
            //TODO: Skriv i tabellen istället
            flightItems.Add(e);
            Flights.ItemsSource = null;
            Flights.ItemsSource = flightItems;

            Flights.UpdateLayout();
        }

        /// <summary>
        /// Event handler for StartedOrLanded events
        /// </summary>
        /// <param name="sender">sender of the event</param>
        /// <param name="e">event arguments</param>
        private void OnStartedOrLanded_handler(object sender, FlightEventArgs e)
        {
            Console.Out.WriteLine($"Extrafunktion: {e.FlightNo}: {e.FlightAction}, {e.DateTime} ");
            StartsAndLandings.Text += $"Flight {e.FlightNo} is  {e.FlightAction} at {e.DateTime}\n";
        }

        /// <summary>
        /// Call for validation of Start button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidateFlightButton(object sender, RoutedEventArgs e)
        {
            ValidateFlightButton();
        }

        /// <summary>
        /// Call for validation of Start button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidateFlightButton(object sender, DependencyPropertyChangedEventArgs e)
        {
            ValidateFlightButton();
        }

        /// <summary>
        /// Call for validation of Start button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFlightCode_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateFlightButton();
        }
    }
}
