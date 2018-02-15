// Helge Stenström 
// ah7875
// C# del II 2018

namespace Assignment2
{
    /// <summary>
    /// The Eagle is a Bird.
    /// </summary>
    public class Eagle : Bird
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="givenId"></param>
        /// <param name="name"></param>
        /// <param name="gender"></param>
        /// <param name="age"></param>
        /// <param name="wingSpan"></param>
        /// <param name="flightSpeed">in km/h</param>
        public Eagle(string givenId, string name, Gender gender, int age, double wingSpan, double flightSpeed) : base(givenId, name, gender, age, wingSpan)
        {
            FlightSpeed = flightSpeed;
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

        public override EaterType GetEaterType()
        {
            return EaterType.Carnivore;
        }

    }
}