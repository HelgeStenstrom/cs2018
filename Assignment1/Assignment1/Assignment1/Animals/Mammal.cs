namespace Assignment1
{
    public class Mammal : Animal
    {
        public Mammal(string givenId, string name, Gender gender, int age, int toothCount) : base(givenId, name, gender, age)
        {
            ToothCount = toothCount;
        }

        public int ToothCount { get; }

        protected Mammal(string givenId) : this(givenId, "no name", Gender.Unknown, 0, 17)
        {
        }

        public override string ToString()
        {
            return $"Has is {ToothCount} teeth.";
        }
    }
}