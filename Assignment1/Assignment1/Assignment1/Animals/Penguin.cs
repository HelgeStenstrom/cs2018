namespace Assignment1
{
    public class Penguin : Bird
    {
        public double RunSpeed { get; }
        public double SwimSpeed { get; }

        public Penguin(string givenId) : base(givenId)
        {
        }
    }
}