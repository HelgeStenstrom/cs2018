namespace Assignment1
{
    public class Penguin : Bird
    {
        public Penguin(string givenId, string name, Gender gender, int age, double wingSpan, double swimSpeed) : base(givenId, name, gender, age, wingSpan)
        {
            SwimSpeed = swimSpeed;
        }

        public double SwimSpeed { get; }

        
        public override string ToString()
        {
            return $"{base.ToString()} Swim speed is {SwimSpeed} knots,";
        }
    }
}