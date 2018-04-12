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
        private List<FlightEventArgsMain> flightItems = new List<FlightEventArgsMain>();

        public MainWindow()
        {
            InitializeComponent();
            InitializeGui();
        }

        private void InitializeGui()
        {
            btnSend.IsEnabled = false;
            ValidateFlightButton();
            var items = new List<FlightEventArgsMain>();
            items.Add(new FlightEventArgsMain() {FlightNo="DummyFlight 1", FlightAction = "crach", DateTime = DateTime.Now });
            items.Add(new FlightEventArgsMain() { FlightNo = "DummyFlight 2", FlightAction = "crackle", DateTime = DateTime.Now });
            items.Add(new FlightEventArgsMain() { FlightNo = "Dumbo Flight 3", FlightAction = "pop", DateTime = DateTime.Now });
            Flights.ItemsSource = items;
        }

        private void ValidateFlightButton()
        {
            var txt = txtFlightCode.Text;
            btnSend.IsEnabled = !(string.IsNullOrEmpty(txt));
        }

        private void Button_Send_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Du klickade Sänd plan till starten");
            var flightName = txtFlightCode.Text;
            if (string.IsNullOrEmpty(flightName))
                throw new InvalidOperationException("flight code must not be empty when the Send button is clicked.");
            var flightWindow = new FlightWindow(flightName);
            flightWindow.FlightChanged += OnFlightChanged;
        }

        private void OnFlightChanged(object sender, FlightEventArgsMain e)
        {
            Console.Out.WriteLine($"{e.FlightNo}: {e.FlightAction}, {e.DateTime} ");
            //TODO: Skriv i tabellen istället
            flightItems.Add(e);
            Flights.ItemsSource = null;
            Flights.ItemsSource = flightItems;

            Flights.UpdateLayout();
        }

        private void ValidateFlightButton(object sender, RoutedEventArgs e)
        {
            ValidateFlightButton();
        }

        private void ValidateFlightButton(object sender, DependencyPropertyChangedEventArgs e)
        {
            ValidateFlightButton();
        }

        private void txtFlightCode_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateFlightButton();
        }
    }

    public class FlightEventArgsMain : EventArgs
    {
        public string FlightNo { get; set; }
        public string FlightAction  { get; set; }
        public DateTime DateTime  { get; set; }
    }
}
