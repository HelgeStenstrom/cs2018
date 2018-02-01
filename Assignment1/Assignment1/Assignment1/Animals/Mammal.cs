namespace Assignment1
{
    public class Mammal : Animal
    {
        public int ToothCount { get; }

        public Mammal(string givenId) : base(givenId)
        {
            ToothCount = 17;
        }
        
        public override string ToString()
        {
            return $"Has is {ToothCount} teeth.";
        }
    }
}