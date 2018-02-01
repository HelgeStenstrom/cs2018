namespace Assignment1
{
    public class Mammal : Animal
    {
        public int ToothCount { get; }

        public Mammal(string givenId) : base(givenId)
        {
        }
        
        public override string ToString()
        {
            return $"Has is {ToothCount} teeth.";
        }
    }
}