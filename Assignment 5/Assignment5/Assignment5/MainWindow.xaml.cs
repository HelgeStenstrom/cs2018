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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            btnSend.IsEnabled = false;
            ValidateFlightButton();
            
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
            var x = new FlightWindow(flightName);
        }

        private void Validate(object sender, RoutedEventArgs e)
        {

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



        // TODO: Läs in bild när klassobjektet skapas
        // TODO: Publicera event när någon knapp klickas
        // TODO: Hitta på ett event-objekt. Ska innehålla flight#
        // TODO: SetupGUI: flyll i något plan som har landat.

    }

    public class FlightEventArgsMain : EventArgs
    {
        public string FlightNo { get; set; }
        public string FlightAction  { get; set; }
        public DateTime DateTime  { get; set; } // TODO: Ska tiden sättas av planet eller tornet?
    }

}
