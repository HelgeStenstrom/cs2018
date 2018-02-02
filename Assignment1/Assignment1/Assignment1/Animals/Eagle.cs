namespace Assignment1
{
    public class Eagle : Bird
    {
        public Eagle(string givenId, string name, Gender gender, int age, double wingSpan, double flightSpeed) : base(givenId, name, gender, age, wingSpan)
        {
            FlightSpeed = flightSpeed;
        }

        public double FlightSpeed { get; set; }

        
        public override string ToString()
        {
            return $"{base.ToString()} FLight speed is {FlightSpeed} km/h";
        }
    }
}