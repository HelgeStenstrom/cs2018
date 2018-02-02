namespace Assignment1
{
    public class Bird : Animal
    {
        public Bird(string givenId, string name, Gender gender, int age, double wingSpan) : base(givenId, name, gender, age)
        {
            WingSpan = wingSpan;
        }

        public double WingSpan { get; }


        public Bird(string givenId) : base(givenId)
        {
            WingSpan = 17;
        }

        public override string ToString()
        {
            return $"Wingspan is {WingSpan} cm.";
        }

    }
}