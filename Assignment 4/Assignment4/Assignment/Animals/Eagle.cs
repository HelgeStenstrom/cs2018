// Helge Stenström 
// ah7875
// C# del II 2018

using System;
using System.Collections.Generic;

namespace Assignment
{
    /// <summary>
    /// The Eagle is a Bird.
    /// </summary>
    [Serializable]
    public class Eagle : Bird
    {
        //private EaterType 
        
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        /// <param name="age"></param>
        /// <param name="wingSpan"></param>
        /// <param name="flightSpeed">in km/h</param>
        public Eagle(string name, Gender gender, int age, double wingSpan, double flightSpeed) : base(name, gender, age, wingSpan)
        {
            FlightSpeed = flightSpeed;
            FoodSchedule = new FoodSchedule(new List<string> { "Sork till frukost", "Kattunge till lunch" });
        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="other"></param>
        public Eagle(Eagle other) : base(other)
        {
            FlightSpeed = other.FlightSpeed;
        }

        /// <summary>
        /// Flightspeed is a property that is particular to birds. For dead birds, it's zero.
        /// </summary>
        private double FlightSpeed { get; }

        /// <summary>
        /// A string that represents this particular Eagle.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{base.ToString()} Flight speed is {FlightSpeed} km/h";
        }

        /// <summary>
        /// Clone this animal.
        /// </summary>
        /// <returns>a copy of this animal</returns>
        public override IAnimal Clone()
        {
            return new Eagle(this);
        }

        /// <summary>
        /// Return the eater type of this animal.
        /// </summary>
        /// <returns>the eater type of this animal</returns>
        public override EaterType GetEaterType()
        {
            return EaterType.Carnivore;
        }
    }
}