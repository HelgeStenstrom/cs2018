namespace Assignment1
{
    public class Eagle : Bird
    {
        public double FlightSpeed { get; set; }

        public Eagle(string givenId) : base(givenId)
        {
            FlightSpeed = 17;
        }
        
        public override string ToString()
        {
            return $"{base.ToString()} FLight speed is {FlightSpeed} km/h";
        }
    }
}