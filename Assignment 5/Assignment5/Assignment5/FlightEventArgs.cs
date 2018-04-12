// Helge Stenström 
// ah7875
// C# del II 2018

using System;

namespace Assignment5
{
    /// <summary>
    /// Event data used by starts, landings and route changes from planes.
    /// </summary>
    public class FlightEventArgs : EventArgs
    {
        public string FlightNo { get; set; }
        public string FlightAction  { get; set; }
        public DateTime DateTime  { get; set; }
    }
}
