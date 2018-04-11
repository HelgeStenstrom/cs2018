﻿using System;
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
        private bool isFlying;
        public event EventHandler<FlightEventArgsMain> FlightChanged;

        public FlightWindow(string flightName)
        {
            this.flightName = flightName;
            isFlying = false;
            InitializeComponent();
            InitializeGUI();

        }

        private void InitializeGUI()
        {
            this.Title = $"Flight {flightName}";
            Uri uri;
            uri = new Uri(@"/icons/" + Airline(flightName), UriKind.Relative);
            this.logo.Source = new BitmapImage(uri);
            UpdateGui();
            this.Show();
        }

        private void UpdateGui()
        {
            this.direction.IsEnabled = isFlying;
            this.Land.IsEnabled = isFlying;
            this.Start.IsEnabled = !isFlying;
        }

        // TODO: Disable rutt och Land
        // TODO: Visa logga

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
            isFlying = true;
            UpdateGui();
            OnStart();
        }

        private void OnStart()
        {
            //FlightChanged?.Invoke(this, EventArgs.Empty);
            if (FlightChanged != null)
                FlightChanged(this, new FlightEventArgsMain()
                {
                    FlightNo = flightName,
                    FlightAction = "Start",
                    DateTime = DateTime.Now
                });
        }

        private void Land_Click(object sender, RoutedEventArgs e)
        {
            isFlying = false;
            UpdateGui();
            // TODO: ta bort fönstret
            Close();
        }

        private void direction_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Console.Out.WriteLine("Ändrade kurs");
        }
    }

    public class FlightEventArgs : EventArgs
    {
        public string ChangeDescription { get; set; }
        public DateTime DateTime  { get; set; }
    }
}
