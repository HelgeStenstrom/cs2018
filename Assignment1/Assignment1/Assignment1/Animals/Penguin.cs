namespace Assignment1
{
    public class Penguin : Bird
    {
        public double SwimSpeed { get; }

        public Penguin(string givenId) : base(givenId)
        {
            SwimSpeed = 17;
        }
        
        public override string ToString()
        {
            return $"{base.ToString()} Swim speed is {SwimSpeed} knots,";
        }
    }
}