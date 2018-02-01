namespace Assignment1
{
    public class Bird : Animal
    {
        public double WingSpan { get; }


        public Bird(string givenId) : base(givenId)
        {
        }

        public override string ToString()
        {
            return $"Wingspan is {WingSpan} cm.";
        }

    }
}