namespace Assignment1
{
    public class Bird : Animal
    {
        public double WingSpan { get; }

        public override string Abstrakt()
        {
            throw new System.NotImplementedException();
        }

        public override string Virtuell()
        {
            return "Bird";
        }

        public Bird(string givenId) : base(givenId)
        {
        }
    }
}